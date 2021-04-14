using dlNetWeb.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public class SharedHandler : BaseHandler<Tokens.BaseToken>
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
                    case Tokens.State.Data:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0026'))
                            {
                                state.ReturnState = Tokens.State.Data;
                                OnChangeState(Tokens.State.CharacterReference);
                                break;
                            }
                            else if (currentInputCharacter.AnyOf('\u003C'))
                            {
                                OnChangeState(Tokens.State.TagOpen);
                                break;
                            } else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                OnEmitToken(new Tokens.CharacterToken { Value = currentInputCharacter.Span[0].ToString() });
                            } else
                            {
                                OnEmitToken(new Tokens.CharacterToken { Value = currentInputCharacter.Span[0].ToString() });
                            }
                        }
                        else
                        {
                            exitLoop = true;
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.PLAINTEXT:
                        break;
                    case Tokens.State.MarkupDeclarationOpen:
                        if (data.NextChar(data.ReadPosition, 2).ToString() == "--")
                        {
                            data.ReadPosition += 2;
                            Token = new Tokens.CommantToken
                            {
                                Value = string.Empty
                            };
                            OnChangeState(Tokens.State.CommentStart);
                        }
                        else if (string.Equals("DOCTYPE", data.NextChar(data.ReadPosition, 7).ToString(), StringComparison.OrdinalIgnoreCase))
                        {
                            data.ReadPosition += 7;
                            OnChangeState(Tokens.State.DOCTYPE);
                        }
                        else if (string.Equals("[CDATA[", data.NextChar(data.ReadPosition, 7)))
                        {
                            data.ReadPosition += 7;
                            if (OnIsAdjustedCurrentNode())
                            {
                                OnChangeState(Tokens.State.CDATASection);
                            } else
                            {
                                OnSetParseError(ParseError.CdataInHtmlContent);
                                Token = new Tokens.CommantToken { Value = "[CDATA[" };
                                OnChangeState(Tokens.State.BogusComment);
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.IncorrectlyOpenedComment);
                            Token = new Tokens.CommantToken
                            {
                                Value = string.Empty
                            };
                            OnChangeState(Tokens.State.BogusComment);
                        }
                        break;
                    case Tokens.State.AmbiguousAmpersand:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.IsLetterOrDigit())
                            {
                                if (OnIsPartOfAttribute())
                                {
                                    if (Token is Tokens.BaseTagToken token)
                                        token.Attributes[^1].Value += currentInputCharacter.Span[0];
                                } else
                                {
                                    OnEmitToken(new Tokens.CharacterToken
                                    {
                                        Value = currentInputCharacter.ToString()
                                    });
                                }
                                break;
                            }
                            else if (currentInputCharacter.Span[0] == '\u003B')
                            {
                                OnSetParseError(ParseError.UnknownNamedCharacterReference);
                            }
                            OnChangeState(state.ReturnState);
                            data.ReadPosition--;
                            break;
                        }
                        else
                        {
                            exitLoop = true;
                            isEOF = true;
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
