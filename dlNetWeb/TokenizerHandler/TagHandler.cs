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
                            if (currentInputCharacter.Span[0] == '!')
                            {
                                state.State = Tokens.State.MarkupDeclarationOpen;
                            }
                            else if (currentInputCharacter.Span[0] == '/')
                            {
                                state.State = Tokens.State.EndTagOpen;
                            }
                            else if (Char.IsLetter(currentInputCharacter.Span[0]))
                            {
                                Token = new Tokens.StartTagToken
                                {
                                    TagName = string.Empty
                                };
                                data.ReadPosition--;
                                state.State = Tokens.State.TagName;
                            }
                            else if (currentInputCharacter.Span[0] == '?')
                            {
                                // unexpected-question-mark-instead-of-tag-name parse error
                                state.Token = new Tokens.CommantToken { Value = string.Empty };
                                data.ReadPosition--;
                                state.State = Tokens.State.BogusComment;
                            }
                            else
                            {
                                // invalid-first-character-of-tag-name parse error
                                OnEmitToken(new Tokens.CharacterToken { Value = '<'.ToString() });
                                data.ReadPosition--;
                                state.State = Tokens.State.Data;
                            }
                        }
                        else
                        {
                            // eof-before-tag-name parse error
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
                            if (Char.IsLetter(currentInputCharacter.Span[0]))
                            {
                                Token = new Tokens.EndTagToken
                                {
                                    TagName = string.Empty
                                };
                                data.ReadPosition--;
                                state.State = Tokens.State.TagName;
                            }
                            else if (currentInputCharacter.Span[0] == '>')
                            {
                                //  missing-end-tag-name parse error
                                state.State = Tokens.State.Data;
                            }
                            else
                            {
                                // invalid-first-character-of-tag-name parse error
                                state.Token = new Tokens.CommantToken { Value = string.Empty };
                                data.ReadPosition--;
                                state.State = Tokens.State.BogusComment;
                            }
                        }
                        else
                        {
                            //  eof-before-tag-name parse error
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
                            if (currentInputCharacter.Span[0] == '\u0009'
                                || currentInputCharacter.Span[0] == '\u000A'
                                || currentInputCharacter.Span[0] == '\u000C'
                                || currentInputCharacter.Span[0] == '\u0020')
                            {
                                state.State = Tokens.State.BeforeAttributeName;
                            } else if (currentInputCharacter.Span[0] == '/')
                            {
                                state.State = Tokens.State.SelfClosingStartTag;
                            } else if (currentInputCharacter.Span[0] == '>')
                            {
                                OnEmitToken(Token);
                                state.State = Tokens.State.Data;
                            } else if (Char.IsLetter(currentInputCharacter.Span[0]) && Char.IsUpper(currentInputCharacter.Span[0]))
                            {
                                Token.TagName += currentInputCharacter.Span[0].ToString().ToLower();
                            } else if (currentInputCharacter.Span[0] == '\u0000')
                            {
                                // unexpected-null-character parse error
                                Token.TagName += '\uFFFD';
                            } else
                            {
                                Token.TagName += currentInputCharacter.Span[0].ToString();
                            }
                        }
                        else
                        {
                            // eof-in-tag parse error
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
