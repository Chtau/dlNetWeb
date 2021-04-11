using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public class DocTypeHandler : BaseHandler<Tokens.DOCTYPEToken>
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
                    case Tokens.State.DOCTYPE:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '\u0009'
                                || currentInputCharacter.Span[0] == '\u000A'
                                || currentInputCharacter.Span[0] == '\u000C'
                                || currentInputCharacter.Span[0] == '\u0020')
                            {
                                state.State = Tokens.State.BeforeDOCTYPEName;
                            }
                            else if (currentInputCharacter.Span[0] == '>')
                            {
                                state.State = Tokens.State.BeforeDOCTYPEName;
                                data.ReadPosition--;
                            }
                            else
                            {
                                state.Error = ParseError.MissingWhitespaceBeforeDoctypeName;
                                state.State = Tokens.State.BeforeDOCTYPEName;
                                data.ReadPosition--;
                            }
                        }
                        else
                        {
                            OnEmitToken(new Tokens.DOCTYPEToken
                            {
                                ForceQuirks = true
                            });
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.BeforeDOCTYPEName:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '\u0009'
                                || currentInputCharacter.Span[0] == '\u000A'
                                || currentInputCharacter.Span[0] == '\u000C'
                                || currentInputCharacter.Span[0] == '\u0020')
                            {
                                // ignore character
                            }
                            else if (Char.IsLetter(currentInputCharacter.Span[0]) && Char.IsUpper(currentInputCharacter.Span[0]))
                            {
                                Token = new Tokens.DOCTYPEToken
                                {
                                    Name = currentInputCharacter.Span[0].ToString().ToLower()
                                };
                                state.State = Tokens.State.DOCTYPEName;
                            }
                            else if (currentInputCharacter.Span[0] == '\u0000')
                            {
                                Token = new Tokens.DOCTYPEToken
                                {
                                    Name = '\uFFFD'.ToString()
                                };
                                state.State = Tokens.State.DOCTYPEName;
                            }
                            else if (currentInputCharacter.Span[0] == '>')
                            {
                                state.Error = ParseError.MissingDoctypeName;
                                OnEmitToken(new Tokens.DOCTYPEToken
                                {
                                    ForceQuirks = true
                                });
                                state.State = Tokens.State.Data;
                            }
                            else
                            {
                                Token = new Tokens.DOCTYPEToken
                                {
                                    Name = currentInputCharacter.Span[0].ToString()
                                };
                                state.State = Tokens.State.DOCTYPEName;
                            }
                        }
                        else
                        {
                            OnEmitToken(new Tokens.DOCTYPEToken
                            {
                                ForceQuirks = true
                            });
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.DOCTYPEName:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '\u0009'
                                || currentInputCharacter.Span[0] == '\u000A'
                                || currentInputCharacter.Span[0] == '\u000C'
                                || currentInputCharacter.Span[0] == '\u0020')
                            {
                                state.State = Tokens.State.AfterDOCTYPEName;
                            }
                            else if (currentInputCharacter.Span[0] == '>')
                            {
                                state.State = Tokens.State.Data;
                                OnEmitToken(Token);
                            }
                            else if (Char.IsLetter(currentInputCharacter.Span[0]) && Char.IsUpper(currentInputCharacter.Span[0]))
                            {
                                Token.Name += currentInputCharacter.Span[0].ToString().ToLower();
                            }
                            else if (currentInputCharacter.Span[0] == '\u0000')
                            {
                                state.Error = ParseError.UnexpectedNullCharacter;
                                Token.Name += '\uFFFD'.ToString();
                            }
                            else
                            {
                                Token.Name += currentInputCharacter.Span[0].ToString();
                            }
                        }
                        else
                        {
                            state.Error = ParseError.EofInDoctype;
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.AfterDOCTYPEName:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '\u0009'
                                || currentInputCharacter.Span[0] == '\u000A'
                                || currentInputCharacter.Span[0] == '\u000C'
                                || currentInputCharacter.Span[0] == '\u0020')
                            {
                                // ignore character
                            }
                            else if (currentInputCharacter.Span[0] == '>')
                            {
                                state.State = Tokens.State.Data;
                                OnEmitToken(Token);
                            }
                            else
                            {
                                var afterDocTypeStartPositon = data.ReadPosition--;
                                string afterDocTypeValue = data.NextChar(afterDocTypeStartPositon, 6).ToString();
                                if (string.Equals("PUBLIC", afterDocTypeValue, StringComparison.OrdinalIgnoreCase))
                                {
                                    data.ReadPosition += 5;
                                    state.State = Tokens.State.AfterDOCTYPEPublicKeyword;
                                }
                                else if (string.Equals("SYSTEM", afterDocTypeValue, StringComparison.OrdinalIgnoreCase))
                                {
                                    data.ReadPosition += 5;
                                    state.State = Tokens.State.AfterDOCTYPESystemKeyword;
                                }
                                else
                                {
                                    state.Error = ParseError.InvalidCharacterSequenceAfterDoctypeName;
                                    Token.ForceQuirks = true;
                                    data.ReadPosition--;
                                    state.State = Tokens.State.BogusDOCTYPE;
                                }
                            }
                        }
                        else
                        {
                            state.Error = ParseError.EofInDoctype;
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.AfterDOCTYPEPublicKeyword:
                        break;
                    case Tokens.State.BeforeDOCTYPEPublicIdentifier:
                        break;
                    case Tokens.State.DOCTYPEPublicIdentifierDoubleQuoted:
                        break;
                    case Tokens.State.DOCTYPEPublicIdentifierSingleQuoted:
                        break;
                    case Tokens.State.AfterDOCTYPEPublicIdentifier:
                        break;
                    case Tokens.State.BetweenDOCTYPEPublicAndSystemIdentifiers:
                        break;
                    case Tokens.State.AfterDOCTYPESystemKeyword:
                        break;
                    case Tokens.State.BeforeDOCTYPESystemIdentifier:
                        break;
                    case Tokens.State.DOCTYPESystemIdentifierDoubleQuoted:
                        break;
                    case Tokens.State.DOCTYPESystemIdentifierSingleQuoted:
                        break;
                    case Tokens.State.AfterDOCTYPESystemIdentifier:
                        break;
                    case Tokens.State.BogusDOCTYPE:
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
