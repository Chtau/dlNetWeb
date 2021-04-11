using System;
using System.Collections.Generic;
using System.Text;

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
                            if (currentInputCharacter.Span[0] == '>')
                            {
                                state.State = Tokens.State.Data;
                                OnEmitToken(Token);
                            } else if (currentInputCharacter.Span[0] == '\u0000')
                            {
                                state.Error = ParseError.UnexpectedNullCharacter;
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
                            if (currentInputCharacter.Span[0] == '-')
                            {
                                state.State = Tokens.State.CommentStartDash;
                            }
                            else if (currentInputCharacter.Span[0] == '>')
                            {
                                state.Error = ParseError.AbruptClosingOfEmptyComment;
                                state.State = Tokens.State.Data;
                                OnEmitToken(Token);
                            }
                            else
                            {
                                data.ReadPosition--;
                                state.State = Tokens.State.Comment;
                            }
                        }
                        break;
                    case Tokens.State.CommentStartDash:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '-')
                            {
                                state.State = Tokens.State.CommentEnd;
                            }
                            else if (currentInputCharacter.Span[0] == '>')
                            {
                                state.Error = ParseError.AbruptClosingOfEmptyComment;
                                state.State = Tokens.State.Data;
                                OnEmitToken(Token);
                            }
                            else
                            {
                                Token.Value += '\u002D';
                                data.ReadPosition--;
                                state.State = Tokens.State.Comment;
                            }
                        }
                        else
                        {
                            state.Error = ParseError.EofInComment;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.Comment:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '<')
                            {
                                Token.Value += currentInputCharacter.Span[0];
                                state.State = Tokens.State.CommentLessThanSign;
                            }
                            else if (currentInputCharacter.Span[0] == '-')
                            {
                                state.State = Tokens.State.CommentEndDash;
                            }
                            else if (currentInputCharacter.Span[0] == '\u0000')
                            {
                                state.Error = ParseError.UnexpectedNullCharacter;
                                Token.Value += '\uFFFD';
                            }
                            else
                            {
                                Token.Value += currentInputCharacter.Span[0];
                            }
                        }
                        else
                        {
                            state.Error = ParseError.EofInComment;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.CommentLessThanSign:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '!')
                            {
                                state.State = Tokens.State.CommentLessThanSignBang;
                                Token.Value += currentInputCharacter.Span[0];
                            }
                            else if (currentInputCharacter.Span[0] == '<')
                            {
                                Token.Value += currentInputCharacter.Span[0];
                            }
                            else
                            {
                                data.ReadPosition--;
                                state.State = Tokens.State.Comment;
                            }
                        }
                        break;
                    case Tokens.State.CommentLessThanSignBang:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '-')
                            {
                                state.State = Tokens.State.CommentLessThanSignBangDash;
                            }
                            else
                            {
                                data.ReadPosition--;
                                state.State = Tokens.State.Comment;
                            }
                        }
                        break;
                    case Tokens.State.CommentLessThanSignBangDash:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '-')
                            {
                                state.State = Tokens.State.CommentLessThanSignBangDashDash;
                            }
                            else
                            {
                                data.ReadPosition--;
                                state.State = Tokens.State.CommentEndDash;
                            }
                        }
                        break;
                    case Tokens.State.CommentLessThanSignBangDashDash:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '>')
                            {
                                state.State = Tokens.State.CommentEnd;
                                data.ReadPosition--;
                            }
                            else
                            {
                                state.Error = ParseError.NestedComment;
                                state.State = Tokens.State.CommentEnd;
                                data.ReadPosition--;
                            }
                        }
                        else
                        {
                            state.State = Tokens.State.CommentEnd;
                            data.ReadPosition--;
                        }
                        break;
                    case Tokens.State.CommentEndDash:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '-')
                            {
                                state.State = Tokens.State.CommentEnd;
                            }
                            else
                            {
                                Token.Value += '\u002D';
                                data.ReadPosition--;
                                state.State = Tokens.State.Comment;
                            }
                        } else
                        {
                            state.Error = ParseError.EofInComment;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.CommentEnd:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '>')
                            {
                                state.State = Tokens.State.Data;
                                OnEmitToken(Token);
                            } else if (currentInputCharacter.Span[0] == '!')
                            {
                                state.State = Tokens.State.CommentEndBang;
                            }
                            else if (currentInputCharacter.Span[0] == '-')
                            {
                                Token.Value += '\u002D';
                            }
                            else
                            {
                                Token.Value += '\u002D';
                                data.ReadPosition--;
                                state.State = Tokens.State.Comment;
                            }
                        }
                        else
                        {
                            state.Error = ParseError.EofInComment;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.CommentEndBang:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '-')
                            {
                                Token.Value += '\u002D';
                                state.State = Tokens.State.CommentEndDash;
                            }
                            else if (currentInputCharacter.Span[0] == '>')
                            {
                                state.Error = ParseError.IncorrectlyClosedComment;
                                state.State = Tokens.State.Data;
                                OnEmitToken(Token);
                            } else
                            {
                                Token.Value += '\u002D';
                                Token.Value += '\u0021';
                                data.ReadPosition--;
                                state.State = Tokens.State.Comment;
                            }
                        }
                        else
                        {
                            state.Error = ParseError.EofInComment;
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
