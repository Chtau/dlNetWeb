using System;
using System.Collections.Generic;
using System.Text;
using dlNetWeb.Extensions;

namespace dlNetWeb
{
    public class Tokenizer
    {
        public event EventHandler<Tokens.BaseToken> EmitToken;

        private readonly Data.NamedCharacterReferenceData _namedCharacterReference = new Data.NamedCharacterReferenceData();
        private readonly Helper.ILogger _logger = new Helper.InternalLogger();
        private readonly TokenizerHandler.ISharedState _sharedState = new TokenizerHandler.SharedState();
        private readonly TokenizerHandler.IDataSource _data;
        private readonly TokenizerHandler.DocTypeHandler _docTypeHandler = new TokenizerHandler.DocTypeHandler();
        private readonly TokenizerHandler.TagHandler _tagHandler = new TokenizerHandler.TagHandler();

        //private Tokens.State state = Tokens.State.Data;
        //private Tokens.State returnState = Tokens.State.Data;
        private string temporaryBuffer = null;
        private bool consumeAsAttribute = false;
        private Tokens.BaseToken currentToken;

        public ParseError Error => _sharedState.Error;

        public Tokenizer(string content)
        {
            _data = new TokenizerHandler.DataSourceMemory(content);
            _docTypeHandler.Initialize(_data, _logger, _sharedState);
            _docTypeHandler.EmitToken += (obj, token) =>
            {
                EmitToken.Invoke(obj, token);
            };
            _tagHandler.Initialize(_data, _logger, _sharedState);
            _tagHandler.EmitToken += (obj, token) =>
            {
                EmitToken.Invoke(obj, token);
            };
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
                        if (_tagHandler.Run())
                            exitLoop = true;
                        break;
                    case Tokens.State.MarkupDeclarationOpen:
                        if (_data.NextChar(_data.ReadPosition, 2).ToString() == "--")
                        {
                            _data.ReadPosition += 2;
                            currentToken = new Tokens.CommantToken
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
                            // parse error for "incorrectly-opened-comment"
                            currentToken = new Tokens.CommantToken
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
                    case Tokens.State.CharacterReference:
                        temporaryBuffer = string.Empty;
                        currentInputCharacter = _data.NextChar(_data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0].IsAlphaNumeric())
                            {
                                // Reconsume in the named character reference state.
                                _sharedState.State = Tokens.State.NamedCharacterReference;
                            } else if (currentInputCharacter.Span[0] == '#')
                            {
                                temporaryBuffer += currentInputCharacter.Span[0];
                                _sharedState.State = Tokens.State.NumericCharacterReference;
                                break;
                            } else
                            {
                                _data.ReadPosition--;
                                _sharedState.State = _sharedState.ReturnState;
                                break;
                            }
                        }
                        else
                        {
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.NamedCharacterReference:
                        string namedChar = string.Empty + currentInputCharacter.Span[0];
                        //temporaryBuffer += namedChar;
                        if (!consumeAsAttribute)
                        {
                            // peak till no match for a key in _namedCharacterReference
                            string matchKey = null;
                            for (int i = 1; i < _namedCharacterReference.MaxKeyLength; i++)
                            {
                                var match = _namedCharacterReference.HasMatchingKeys(namedChar);
                                if (string.IsNullOrWhiteSpace(match))
                                    break;
                                else
                                {
                                    matchKey = match;
                                    namedChar += _data.NextChar(_data.ReadPosition + 1, 1 + i);
                                }
                            }
                            if (matchKey.Length > 0)
                            {
                                if (matchKey[^1] != ';')
                                {
                                    // set parse error for "missing-semicolon-after-character-reference"
                                }
                                // append characters from key to buffer
                                temporaryBuffer += _namedCharacterReference.Entities[matchKey].Characters;
                                // mark as consumed
                                _data.ReadPosition += matchKey.Length - 1; // -1 because & was already consumed
                                _sharedState.State = _sharedState.ReturnState;
                                break;
                            } else
                            {
                                temporaryBuffer += currentInputCharacter.Span[0];
                                _sharedState.State = Tokens.State.AmbiguousAmpersand;
                                break;
                            }
                        }
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
                                // parse error for "unknown-named-character-reference"
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
                    case Tokens.State.NumericCharacterReference:
                        if (Char.IsLetter(currentInputCharacter.Span[0]))
                        {
                            temporaryBuffer += currentInputCharacter.Span[0];
                            _sharedState.State = Tokens.State.HexadecimalCharacterReferenceStart;
                            break;
                        } else
                        {
                            _sharedState.State = Tokens.State.DecimalCharacterReferenceStart;
                            _data.ReadPosition--;
                            break;
                        }
                    case Tokens.State.HexadecimalCharacterReferenceStart:
                        currentInputCharacter = _data.NextChar(_data.ReadPosition++);
                        if (Char.IsLetter(currentInputCharacter.Span[0]))
                        {
                            _sharedState.State = Tokens.State.HexadecimalCharacterReference;
                            _data.ReadPosition--;
                            break;
                        } else
                        {
                            //  parse error for "absence-of-digits-in-numeric-character-reference"
                            _sharedState.State = _sharedState.ReturnState;
                            _data.ReadPosition--;
                            break;
                        }
                    case Tokens.State.DecimalCharacterReferenceStart:
                        currentInputCharacter = _data.NextChar(_data.ReadPosition++);
                        if (Char.IsDigit(currentInputCharacter.Span[0]))
                        {
                            _sharedState.State = Tokens.State.DecimalCharacterReference;
                            _data.ReadPosition--;
                            break;
                        } else
                        {
                            // parse error for "absence-of-digits-in-numeric-character-reference"
                            _sharedState.State = _sharedState.ReturnState;
                            _data.ReadPosition--;
                            break;
                        }
                    default:
                        break;
                }
            } while (!exitLoop);
        }
    }
}
