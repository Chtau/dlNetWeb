using dlNetWeb.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public class RCDATAHandler : BaseHandler<Tokens.BaseTagToken>
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
                    case Tokens.State.RCDATA:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0026'))
                            {
                                state.ReturnState = Tokens.State.RCDATA;
                                OnChangeState(Tokens.State.CharacterReference);
                            } else if (currentInputCharacter.AnyOf('\u003C'))
                            {
                                OnChangeState(Tokens.State.RCDATALessThanSign);
                            }
                            else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                OnEmitToken(new Tokens.CharacterToken { Value = '\uFFFD'.ToString() });
                            }
                            else
                            {
                                OnEmitToken(new Tokens.CharacterToken { Value = currentInputCharacter.Span[0].ToString() });
                            }
                        }
                        else
                        {
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.RCDATALessThanSign:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u002F'))
                            {
                                state.TemporaryBuffer = string.Empty;
                                OnChangeState(Tokens.State.RCDATAEndTagOpen);
                            }
                            else
                            {
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u003C'.ToString() });
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.RCDATA);
                            }
                        }
                        break;
                    case Tokens.State.RCDATAEndTagOpen:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.IsLetter())
                            {
                                Token = new Tokens.EndTagToken
                                {
                                    TagName = string.Empty
                                };
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.RCDATAEndTagName);
                            }
                            else
                            {
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u003C'.ToString() });
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u002F'.ToString() });
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.RCDATA);
                            }
                        }
                        break;
                    case Tokens.State.RCDATAEndTagName:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            bool changed = false;
                            if (currentInputCharacter.AnyOf('\u0009', '\u000A', '\u000C', '\u0020'))
                            {
                                if (OnHasAppropriateEndTagToken(Token.TagName))
                                {
                                    OnChangeState(Tokens.State.BeforeAttributeName);
                                    changed = true;
                                }
                            } else if (currentInputCharacter.AnyOf('\u002F'))
                            {
                                if (OnHasAppropriateEndTagToken(Token.TagName))
                                {
                                    OnChangeState(Tokens.State.SelfClosingStartTag);
                                    changed = true;
                                }
                            }
                            else if (currentInputCharacter.AnyOf('\u003F'))
                            {
                                if (OnHasAppropriateEndTagToken(Token.TagName))
                                {
                                    OnChangeState(Tokens.State.Data);
                                    OnEmitToken(Token);
                                    changed = true;
                                }
                            }
                            else if (currentInputCharacter.IsLetterUpper())
                            {
                                if (OnHasAppropriateEndTagToken(Token.TagName))
                                {
                                    Token.TagName += currentInputCharacter.Span[0].ToString().ToLower();
                                    state.TemporaryBuffer += currentInputCharacter.Span[0];
                                }
                            }
                            else if (currentInputCharacter.IsLetterLower())
                            {
                                if (OnHasAppropriateEndTagToken(Token.TagName))
                                {
                                    Token.TagName += currentInputCharacter.Span[0];
                                    state.TemporaryBuffer += currentInputCharacter.Span[0];
                                }
                            }
                            if (!changed)
                            {
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u003C'.ToString() });
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u002F'.ToString() });
                                OnFlushCodePoints();
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.RCDATA);
                            }
                        }
                        break;
                    default:
                        break;
                }
            } while (!exitLoop);
            return isEOF;
        }
    }
}
