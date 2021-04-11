using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public class DocTypeHandler : BaseHandler<Tokens.DOCTYPEToken>
    {
        internal override void OnRun()
        {
            base.OnRun();
            bool exitLoop = false;
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
                                //  parse error for "missing-whitespace-before-doctype-name"
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
                                token = new Tokens.DOCTYPEToken
                                {
                                    Name = currentInputCharacter.Span[0].ToString().ToLower()
                                };
                                state.State = Tokens.State.DOCTYPEName;
                            }
                            else if (currentInputCharacter.Span[0] == '\u0000')
                            {
                                token = new Tokens.DOCTYPEToken
                                {
                                    Name = '\uFFFD'.ToString()
                                };
                                state.State = Tokens.State.DOCTYPEName;
                            }
                            else if (currentInputCharacter.Span[0] == '>')
                            {
                                // parse error for "missing-doctype-name"
                                OnEmitToken(new Tokens.DOCTYPEToken
                                {
                                    ForceQuirks = true
                                });
                                state.State = Tokens.State.Data;
                            }
                            else
                            {
                                token = new Tokens.DOCTYPEToken
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
                                OnEmitToken(token);
                            }
                            else if (Char.IsLetter(currentInputCharacter.Span[0]) && Char.IsUpper(currentInputCharacter.Span[0]))
                            {
                                token.Name += currentInputCharacter.Span[0].ToString().ToLower();
                            }
                            else if (currentInputCharacter.Span[0] == '\u0000')
                            {
                                // parse error for "unexpected-null-character"
                                token.Name += '\uFFFD'.ToString();
                            }
                            else
                            {
                                token.Name += currentInputCharacter.Span[0].ToString();
                            }
                        }
                        else
                        {
                            //  eof-in-doctype parse error
                            token.ForceQuirks = true;
                            OnEmitToken(token);
                            OnEmitToken(new Tokens.EndOfFileToken());
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
                                OnEmitToken(token);
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
                                    //  invalid-character-sequence-after-doctype-name parse error
                                    token.ForceQuirks = true;
                                    data.ReadPosition--;
                                    state.State = Tokens.State.BogusDOCTYPE;
                                }
                            }
                        }
                        else
                        {
                            //  eof-in-doctype parse error
                            token.ForceQuirks = true;
                            OnEmitToken(token);
                            OnEmitToken(new Tokens.EndOfFileToken());
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
        }
    }
}
