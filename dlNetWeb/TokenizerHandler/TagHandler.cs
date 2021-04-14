using dlNetWeb.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public class TagHandler : BaseHandler<Tokens.BaseTagToken>
    {
        internal override bool OnRun()
        {
            base.OnRun();
            bool exitLoop = false;
            bool isEOF = false;
            ReadOnlyMemory<char> currentInputCharacter = ReadOnlyMemory<char>.Empty;
            do
            {
                switch (state.State)
                {
                    case Tokens.State.TagOpen:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('!'))
                            {
                                OnChangeState(Tokens.State.MarkupDeclarationOpen);
                            }
                            else if (currentInputCharacter.AnyOf('/'))
                            {
                                OnChangeState(Tokens.State.EndTagOpen);
                            }
                            else if (currentInputCharacter.Alpha())
                            {
                                Token = new Tokens.StartTagToken
                                {
                                    TagName = string.Empty
                                };
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.TagName);
                            }
                            else if (currentInputCharacter.AnyOf('?'))
                            {
                                OnSetParseError(ParseError.UnexpectedQuestionMarkInsteadOfTagName);
                                state.Token = new Tokens.CommantToken { Value = string.Empty };
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.BogusComment);
                            }
                            else
                            {
                                OnSetParseError(ParseError.InvalidFirstCharacterOfTagName);
                                OnEmitToken(new Tokens.CharacterToken { Value = '<'.ToString() });
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.Data);
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofBeforeTagName);
                            OnEmitToken(new Tokens.CharacterToken { Value = '<'.ToString() });
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.EndTagOpen:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Alpha())
                            {
                                Token = new Tokens.EndTagToken
                                {
                                    TagName = string.Empty
                                };
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.TagName);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.MissingEndTagName);
                                OnChangeState(Tokens.State.Data);
                            }
                            else
                            {
                                OnSetParseError(ParseError.InvalidFirstCharacterOfTagName);
                                state.Token = new Tokens.CommantToken { Value = string.Empty };
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.BogusComment);
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofBeforeTagName);
                            OnEmitToken(new Tokens.CharacterToken { Value = '<'.ToString() });
                            OnEmitToken(new Tokens.CharacterToken { Value = '/'.ToString() });
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.TagName:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009','\u000A','\u000C','\u0020'))
                            {
                                OnChangeState(Tokens.State.BeforeAttributeName);
                            } else if (currentInputCharacter.AnyOf('/'))
                            {
                                OnChangeState(Tokens.State.SelfClosingStartTag);
                            } else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnEmitToken(Token);
                                OnChangeState(Tokens.State.Data);
                            } else if (currentInputCharacter.IsLetterUpper())
                            {
                                Token.TagName += currentInputCharacter.Span[0].ToString().ToLower();
                            } else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                Token.TagName += '\uFFFD';
                            } else
                            {
                                Token.TagName += currentInputCharacter.Span[0].ToString();
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInTag);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.SelfClosingStartTag:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('>'))
                            {
                                Token.SelfClosing = true;
                                OnEmitToken(Token);
                                OnChangeState(Tokens.State.Data);
                            } else
                            {
                                OnSetParseError(ParseError.UnexpectedSolidusInTag);
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.BeforeAttributeName);
                            }
                        } else
                        {
                            OnSetParseError(ParseError.EofInTag);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    default:
                        exitLoop = true; // exit because we switched to an state which we can't handle here
                        break;
                }
            } while (!exitLoop);
            return isEOF;
        }
    }
}
