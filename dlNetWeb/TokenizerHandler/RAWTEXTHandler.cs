using dlNetWeb.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public class RAWTEXTHandler : BaseHandler<Tokens.BaseTagToken>
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
                    case Tokens.State.RAWTEXT:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u003C'))
                            {
                                OnChangeState(Tokens.State.RAWTEXTLessThanSign);
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
                    case Tokens.State.RAWTEXTLessThanSign:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u002F'))
                            {
                                state.TemporaryBuffer = string.Empty;
                                OnChangeState(Tokens.State.RAWTEXTEndTagOpen);
                            }
                            else
                            {
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u003C'.ToString() });
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.RAWTEXT);
                            }
                        }
                        break;
                    case Tokens.State.RAWTEXTEndTagOpen:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.IsLetter())
                            {
                                Token = new Tokens.EndTagToken { TagName = string.Empty };
                                OnChangeState(Tokens.State.RAWTEXTEndTagName);
                            }
                            else
                            {
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u003C'.ToString() });
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u002F'.ToString() });
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.RAWTEXT);
                            }
                        }
                        break;
                    case Tokens.State.RAWTEXTEndTagName:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            bool changes = false;
                            if (currentInputCharacter.AnyOf('\u0009', '\u000A', '\u000C', '\u0020'))
                            {
                                if (OnHasAppropriateEndTagToken(Token?.TagName))
                                {
                                    OnChangeState(Tokens.State.BeforeAttributeName);
                                    changes = true;
                                }
                            } else if (currentInputCharacter.AnyOf('\u002F'))
                            {
                                if (OnHasAppropriateEndTagToken(Token?.TagName))
                                {
                                    OnChangeState(Tokens.State.SelfClosingStartTag);
                                    changes = true;
                                }
                            }
                            else if (currentInputCharacter.AnyOf('\u003E'))
                            {
                                if (OnHasAppropriateEndTagToken(Token?.TagName))
                                {
                                    OnChangeState(Tokens.State.Data);
                                    OnEmitToken(Token);
                                    changes = true;
                                }
                            }
                            else if (currentInputCharacter.IsLetterUpper())
                            {
                                Token.TagName += currentInputCharacter.Span[0].ToString().ToLower();
                                state.TemporaryBuffer += currentInputCharacter.Span[0];
                                changes = true;
                            }
                            else if (currentInputCharacter.IsLetterLower())
                            {
                                Token.TagName += currentInputCharacter.Span[0];
                                state.TemporaryBuffer += currentInputCharacter.Span[0];
                                changes = true;
                            }
                            if (changes)
                            {
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u003C'.ToString() });
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u002F'.ToString() });
                                OnFlushCodePoints();
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.RAWTEXT);
                            }
                        }
                        break;
                    default:
                        exitLoop = true;
                        break;
                }
            } while (!exitLoop);
            return isEOF;
        }
    }
}
