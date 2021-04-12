using System;
using System.Collections.Generic;
using System.Text;
using dlNetWeb.Extensions;

namespace dlNetWeb
{
    public class Tokenizer
    {
        public event EventHandler<Tokens.BaseToken> EmitToken;

        private readonly Helper.ILogger _logger = new Helper.InternalLogger();
        private readonly TokenizerHandler.ISharedState _sharedState = new TokenizerHandler.SharedState();
        private readonly TokenizerHandler.IDataSource _data;
        private readonly TokenizerHandler.DocTypeHandler _docTypeHandler = new TokenizerHandler.DocTypeHandler();
        private readonly TokenizerHandler.TagHandler _tagHandler = new TokenizerHandler.TagHandler();
        private readonly TokenizerHandler.AttributeHandler _attributeHandler = new TokenizerHandler.AttributeHandler();
        private readonly TokenizerHandler.CharacterReferenceHandler _characterReferenceHandler = new TokenizerHandler.CharacterReferenceHandler();
        private readonly TokenizerHandler.CommentHandler _commentHandler = new TokenizerHandler.CommentHandler();
        private readonly TokenizerHandler.CDATAHandler _cDATAHandler = new TokenizerHandler.CDATAHandler();
        private readonly TokenizerHandler.RCDATAHandler _rCDATAHandler = new TokenizerHandler.RCDATAHandler();

        public ParseError Error => _sharedState.Error;

        public Tokenizer(string content)
        {
            _data = new TokenizerHandler.DataSourceMemory(content);
            _docTypeHandler.Initialize(_data, _logger, _sharedState, OnTokenEmitted);
            _tagHandler.Initialize(_data, _logger, _sharedState, OnTokenEmitted);
            _attributeHandler.Initialize(_data, _logger, _sharedState, OnTokenEmitted);
            _characterReferenceHandler.Initialize(_data, _logger, _sharedState, OnTokenEmitted);
            _commentHandler.Initialize(_data, _logger, _sharedState, OnTokenEmitted);
        }

        private void OnTokenEmitted(Tokens.BaseToken token)
        {
            EmitToken.Invoke(this, token);
        }

        public void Run()
        {
            bool exitLoop = false;
            ReadOnlyMemory<char> currentInputCharacter = ReadOnlyMemory<char>.Empty;
            do
            {
                switch (_sharedState.State)
                {
                    case Tokens.State.Data:
                        currentInputCharacter = _data.NextChar(_data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '&')
                            {
                                _sharedState.ReturnState = Tokens.State.Data;
                                // Switch state to CharacterReference
                                _sharedState.State = Tokens.State.CharacterReference;
                                break;
                            }
                            else if (currentInputCharacter.Span[0] == '<')
                            {
                                // Switch state to TagOpen
                                _sharedState.State = Tokens.State.TagOpen;
                                break;
                            }
                        } else
                        {
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.TagOpen:
                    case Tokens.State.EndTagOpen:
                    case Tokens.State.TagName:
                    case Tokens.State.SelfClosingStartTag:
                        if (_tagHandler.Run())
                            exitLoop = true;
                        break;
                    case Tokens.State.MarkupDeclarationOpen:
                        if (_data.NextChar(_data.ReadPosition, 2).ToString() == "--")
                        {
                            _data.ReadPosition += 2;
                            _sharedState.Token = new Tokens.CommantToken
                            {
                                Value = string.Empty
                            };
                            _sharedState.State = Tokens.State.CommentStart;
                        } else if (string.Equals("DOCTYPE", _data.NextChar(_data.ReadPosition, 7).ToString(), StringComparison.OrdinalIgnoreCase))
                        {
                            _data.ReadPosition += 7;
                            _sharedState.State = Tokens.State.DOCTYPE;
                        } else if (string.Equals("[CDATA[", _data.NextChar(_data.ReadPosition, 7)))
                        {
                            _data.ReadPosition += 7;
                            // TODO: handle CDATA
                        } else
                        {
                            _sharedState.Error = ParseError.IncorrectlyOpenedComment;
                            _sharedState.Token = new Tokens.CommantToken
                            {
                                Value = string.Empty
                            };
                            _sharedState.State = Tokens.State.BogusComment;
                        }
                        break;
                    case Tokens.State.DOCTYPE:
                    case Tokens.State.BeforeDOCTYPEName:
                    case Tokens.State.DOCTYPEName:
                    case Tokens.State.AfterDOCTYPEName:
                    case Tokens.State.AfterDOCTYPEPublicKeyword:
                    case Tokens.State.BeforeDOCTYPEPublicIdentifier:
                    case Tokens.State.DOCTYPEPublicIdentifierDoubleQuoted:
                    case Tokens.State.DOCTYPEPublicIdentifierSingleQuoted:
                    case Tokens.State.AfterDOCTYPEPublicIdentifier:
                    case Tokens.State.BetweenDOCTYPEPublicAndSystemIdentifiers:
                    case Tokens.State.AfterDOCTYPESystemKeyword:
                    case Tokens.State.BeforeDOCTYPESystemIdentifier:
                    case Tokens.State.DOCTYPESystemIdentifierDoubleQuoted:
                    case Tokens.State.DOCTYPESystemIdentifierSingleQuoted:
                    case Tokens.State.AfterDOCTYPESystemIdentifier:
                    case Tokens.State.BogusDOCTYPE:
                        if (_docTypeHandler.Run())
                            exitLoop = true;
                        break;
                    case Tokens.State.AmbiguousAmpersand:
                        currentInputCharacter = _data.NextChar(_data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0].IsAlphaNumeric())
                            {
                                EmitToken?.Invoke(this, new Tokens.CharacterToken
                                {
                                    Value = currentInputCharacter.ToString()
                                });
                                break;
                            } else if (currentInputCharacter.Span[0] == ';')
                            {
                                _sharedState.Error = ParseError.UnknownNamedCharacterReference;
                            }
                            _sharedState.State = _sharedState.ReturnState;
                            _data.ReadPosition--; // reconsume in return
                            break;
                        }
                        else
                        {
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.CharacterReference:
                    case Tokens.State.NamedCharacterReference:
                    case Tokens.State.NumericCharacterReference:
                    case Tokens.State.HexadecimalCharacterReferenceStart:
                    case Tokens.State.DecimalCharacterReferenceStart:
                        if (_characterReferenceHandler.Run())
                            exitLoop = true;
                        break;
                    case Tokens.State.BeforeAttributeName:
                    case Tokens.State.AttributeName:
                    case Tokens.State.AfterAttributeName:
                    case Tokens.State.BeforeAttributeValue:
                    case Tokens.State.AttributeValueDoubleQuoted:
                    case Tokens.State.AttributeValueSingleQuoted:
                    case Tokens.State.AttributeValueUnquoted:
                    case Tokens.State.AfterAttributeValueQuoted:
                        if (_attributeHandler.Run())
                            exitLoop = true;
                        break;
                    case Tokens.State.BogusComment:
                    case Tokens.State.CommentStart:
                    case Tokens.State.CommentStartDash:
                    case Tokens.State.Comment:
                    case Tokens.State.CommentLessThanSign:
                    case Tokens.State.CommentLessThanSignBang:
                    case Tokens.State.CommentLessThanSignBangDash:
                    case Tokens.State.CommentLessThanSignBangDashDash:
                    case Tokens.State.CommentEndDash:
                    case Tokens.State.CommentEnd:
                    case Tokens.State.CommentEndBang:
                        if (_commentHandler.Run())
                            exitLoop = true;
                        break;
                    case Tokens.State.CDATASection:
                    case Tokens.State.CDATASectionBracket:
                    case Tokens.State.CDATASectionEnd:
                        if (_cDATAHandler.Run())
                            exitLoop = true;
                        break;
                    case Tokens.State.RCDATA:
                    case Tokens.State.RCDATALessThanSign:
                    case Tokens.State.RCDATAEndTagOpen:
                    case Tokens.State.RCDATAEndTagName:
                        if (_rCDATAHandler.Run())
                            exitLoop = true;
                        break;
                    default:
                        break;
                }
            } while (!exitLoop);
        }
    }
}
