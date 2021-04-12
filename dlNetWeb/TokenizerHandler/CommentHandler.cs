using System;
using System.Collections.Generic;
using System.Text;
using dlNetWeb.Extensions;

namespace dlNetWeb.TokenizerHandler
{
    public class CommentHandler : BaseHandler<Tokens.CommantToken>
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
                    case Tokens.State.BogusComment:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('>'))
                            {
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            } else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                Token.Value += '\uFFFD';
                            } else
                            {
                                Token.Value += currentInputCharacter.Span[0];
                            }
                        } else
                        {
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.CommentStart:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('-'))
                            {
                                OnChangeState(Tokens.State.CommentStartDash);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.AbruptClosingOfEmptyComment);
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else
                            {
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.Comment);
                            }
                        }
                        break;
                    case Tokens.State.CommentStartDash:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('-'))
                            {
                                OnChangeState(Tokens.State.CommentEnd);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.AbruptClosingOfEmptyComment);
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else
                            {
                                Token.Value += '\u002D';
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.Comment);
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInComment);
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.Comment:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('<'))
                            {
                                Token.Value += currentInputCharacter.Span[0];
                                OnChangeState(Tokens.State.CommentLessThanSign);
                            }
                            else if (currentInputCharacter.AnyOf('-'))
                            {
                                OnChangeState(Tokens.State.CommentEndDash);
                            }
                            else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                Token.Value += '\uFFFD';
                            }
                            else
                            {
                                Token.Value += currentInputCharacter.Span[0];
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInComment);
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.CommentLessThanSign:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('!'))
                            {
                                OnChangeState(Tokens.State.CommentLessThanSignBang);
                                Token.Value += currentInputCharacter.Span[0];
                            }
                            else if (currentInputCharacter.AnyOf('<'))
                            {
                                Token.Value += currentInputCharacter.Span[0];
                            }
                            else
                            {
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.Comment);
                            }
                        }
                        break;
                    case Tokens.State.CommentLessThanSignBang:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('-'))
                            {
                                OnChangeState(Tokens.State.CommentLessThanSignBangDash);
                            }
                            else
                            {
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.Comment);
                            }
                        }
                        break;
                    case Tokens.State.CommentLessThanSignBangDash:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('-'))
                            {
                                OnChangeState(Tokens.State.CommentLessThanSignBangDashDash);
                            }
                            else
                            {
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.CommentEndDash);
                            }
                        }
                        break;
                    case Tokens.State.CommentLessThanSignBangDashDash:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('>'))
                            {
                                OnChangeState(Tokens.State.CommentEnd);
                                data.ReadPosition--;
                            }
                            else
                            {
                                OnSetParseError(ParseError.NestedComment);
                                OnChangeState(Tokens.State.CommentEnd);
                                data.ReadPosition--;
                            }
                        }
                        else
                        {
                            OnChangeState(Tokens.State.CommentEnd);
                            data.ReadPosition--;
                        }
                        break;
                    case Tokens.State.CommentEndDash:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('-'))
                            {
                                OnChangeState(Tokens.State.CommentEnd);
                            }
                            else
                            {
                                Token.Value += '\u002D';
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.Comment);
                            }
                        } else
                        {
                            OnSetParseError(ParseError.EofInComment);
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.CommentEnd:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('>'))
                            {
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            } else if (currentInputCharacter.AnyOf('!'))
                            {
                                OnChangeState(Tokens.State.CommentEndBang);
                            }
                            else if (currentInputCharacter.AnyOf('-'))
                            {
                                Token.Value += '\u002D';
                            }
                            else
                            {
                                Token.Value += '\u002D';
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.Comment);
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInComment);
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.CommentEndBang:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('-'))
                            {
                                Token.Value += '\u002D';
                                OnChangeState(Tokens.State.CommentEndDash);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.IncorrectlyClosedComment);
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            } else
                            {
                                Token.Value += '\u002D';
                                Token.Value += '\u0021';
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.Comment);
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInComment);
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
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
