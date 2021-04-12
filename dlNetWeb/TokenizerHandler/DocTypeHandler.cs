using dlNetWeb.Extensions;
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
                            if (currentInputCharacter.AnyOf('\u0009','\u000A','\u000C','\u0020'))
                            {
                                OnChangeState(Tokens.State.BeforeDOCTYPEName);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnChangeState(Tokens.State.BeforeDOCTYPEName);
                                data.ReadPosition--;
                            }
                            else
                            {
                                OnSetParseError(ParseError.MissingWhitespaceBeforeDoctypeName);
                                OnChangeState(Tokens.State.BeforeDOCTYPEName);
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
                            if (currentInputCharacter.AnyOf('\u0009','\u000A','\u000C','\u0020'))
                            {
                                // ignore character
                            }
                            else if (currentInputCharacter.IsLetterUpper())
                            {
                                Token = new Tokens.DOCTYPEToken
                                {
                                    Name = currentInputCharacter.Span[0].ToString().ToLower()
                                };
                                OnChangeState(Tokens.State.DOCTYPEName);
                            }
                            else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                Token = new Tokens.DOCTYPEToken
                                {
                                    Name = '\uFFFD'.ToString()
                                };
                                OnChangeState(Tokens.State.DOCTYPEName);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.MissingDoctypeName);
                                OnEmitToken(new Tokens.DOCTYPEToken
                                {
                                    ForceQuirks = true
                                });
                                OnChangeState(Tokens.State.Data);
                            }
                            else
                            {
                                Token = new Tokens.DOCTYPEToken
                                {
                                    Name = currentInputCharacter.Span[0].ToString()
                                };
                                OnChangeState(Tokens.State.DOCTYPEName);
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
                            if (currentInputCharacter.AnyOf('\u0009', '\u000A', '\u000C', '\u0020'))
                            {
                                OnChangeState(Tokens.State.AfterDOCTYPEName);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else if (currentInputCharacter.IsLetterUpper())
                            {
                                Token.Name += currentInputCharacter.Span[0].ToString().ToLower();
                            }
                            else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                Token.Name += '\uFFFD'.ToString();
                            }
                            else
                            {
                                Token.Name += currentInputCharacter.Span[0].ToString();
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInDoctype);
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
                            if (currentInputCharacter.AnyOf('\u0009', '\u000A', '\u000C', '\u0020'))
                            {
                                // ignore character
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else
                            {
                                var afterDocTypeStartPositon = data.ReadPosition--;
                                string afterDocTypeValue = data.NextChar(afterDocTypeStartPositon, 6).ToString();
                                if (string.Equals("PUBLIC", afterDocTypeValue, StringComparison.OrdinalIgnoreCase))
                                {
                                    data.ReadPosition += 5;
                                    OnChangeState(Tokens.State.AfterDOCTYPEPublicKeyword);
                                }
                                else if (string.Equals("SYSTEM", afterDocTypeValue, StringComparison.OrdinalIgnoreCase))
                                {
                                    data.ReadPosition += 5;
                                    OnChangeState(Tokens.State.AfterDOCTYPESystemKeyword);
                                }
                                else
                                {
                                    OnSetParseError(ParseError.InvalidCharacterSequenceAfterDoctypeName);
                                    Token.ForceQuirks = true;
                                    data.ReadPosition--;
                                    OnChangeState(Tokens.State.BogusDOCTYPE);
                                }
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInDoctype);
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.AfterDOCTYPEPublicKeyword:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009', '\u000A', '\u000C', '\u0020'))
                            {
                                OnChangeState(Tokens.State.BeforeDOCTYPEPublicIdentifier);
                            }
                            else if (currentInputCharacter.AnyOf('\u0022'))
                            {
                                OnSetParseError(ParseError.MissingWhitespaceAfterDoctypePublicKeyword);
                                Token.Identifier = string.Empty;
                                OnChangeState(Tokens.State.DOCTYPEPublicIdentifierDoubleQuoted);
                            }
                            else if (currentInputCharacter.AnyOf('\u0027'))
                            {
                                OnSetParseError(ParseError.MissingWhitespaceAfterDoctypePublicKeyword);
                                Token.Identifier = string.Empty;
                                OnChangeState(Tokens.State.DOCTYPEPublicIdentifierSingleQuoted);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.MissingDoctypePublicIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else
                            {
                                OnSetParseError(ParseError.MissingQuoteBeforeDoctypePublicIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.BogusDOCTYPE);
                                data.ReadPosition--;
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInDoctype);
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.BeforeDOCTYPEPublicIdentifier:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009', '\u000A', '\u000C', '\u0020'))
                            {
                                // ignore
                            }
                            else if (currentInputCharacter.AnyOf('\u0022'))
                            {
                                Token.Identifier = string.Empty;
                                OnChangeState(Tokens.State.DOCTYPEPublicIdentifierDoubleQuoted);
                            }
                            else if (currentInputCharacter.AnyOf('\u0027'))
                            {
                                Token.Identifier = string.Empty;
                                OnChangeState(Tokens.State.DOCTYPEPublicIdentifierSingleQuoted);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.MissingDoctypePublicIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else
                            {
                                OnSetParseError(ParseError.MissingQuoteBeforeDoctypePublicIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.BogusDOCTYPE);
                                data.ReadPosition--;
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInDoctype);
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.DOCTYPEPublicIdentifierDoubleQuoted:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0022'))
                            {
                                OnChangeState(Tokens.State.AfterDOCTYPEPublicIdentifier);
                            }
                            else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                Token.Identifier += '\uFFFD';
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.AbruptDoctypePublicIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else
                            {
                                Token.Identifier += currentInputCharacter.Span[0];
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInDoctype);
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.DOCTYPEPublicIdentifierSingleQuoted:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0027'))
                            {
                                OnChangeState(Tokens.State.AfterDOCTYPEPublicIdentifier);
                            }
                            else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                Token.Identifier += '\uFFFD';
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.AbruptDoctypePublicIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else
                            {
                                Token.Identifier += currentInputCharacter.Span[0];
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInDoctype);
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.AfterDOCTYPEPublicIdentifier:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009', '\u000A', '\u000C', '\u0020'))
                            {
                                OnChangeState(Tokens.State.BetweenDOCTYPEPublicAndSystemIdentifiers);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnEmitToken(Token);
                                OnChangeState(Tokens.State.Data);
                            }
                            else if (currentInputCharacter.AnyOf('\u0022'))
                            {
                                OnSetParseError(ParseError.MissingWhitespaceBetweenDoctypePublicAndSystemIdentifiers);
                                Token.SystemIdentifier = string.Empty;
                                OnChangeState(Tokens.State.DOCTYPESystemIdentifierDoubleQuoted);
                            }
                            else if (currentInputCharacter.AnyOf('\u0027'))
                            {
                                OnSetParseError(ParseError.MissingWhitespaceBetweenDoctypePublicAndSystemIdentifiers);
                                Token.SystemIdentifier = string.Empty;
                                OnChangeState(Tokens.State.DOCTYPESystemIdentifierSingleQuoted);
                            }
                            else
                            {
                                OnSetParseError(ParseError.MissingQuoteBeforeDoctypeSystemIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.BogusDOCTYPE);
                                data.ReadPosition--;
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInDoctype);
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.BetweenDOCTYPEPublicAndSystemIdentifiers:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009', '\u000A', '\u000C', '\u0020'))
                            {
                                // ignore
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else if (currentInputCharacter.AnyOf('\u0022', '\u0027'))
                            {
                                Token.SystemIdentifier = string.Empty;
                                OnChangeState(Tokens.State.DOCTYPESystemIdentifierSingleQuoted);
                            }
                            else
                            {
                                OnSetParseError(ParseError.MissingQuoteBeforeDoctypeSystemIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.BogusDOCTYPE);
                                data.ReadPosition--;
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInDoctype);
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.AfterDOCTYPESystemKeyword:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009', '\u000A', '\u000C', '\u0020'))
                            {
                                OnChangeState(Tokens.State.BeforeDOCTYPESystemIdentifier);
                            }
                            else if (currentInputCharacter.AnyOf('\u0022'))
                            {
                                OnSetParseError(ParseError.MissingWhitespaceAfterDoctypeSystemKeyword);
                                Token.SystemIdentifier = string.Empty;
                                OnChangeState(Tokens.State.DOCTYPESystemIdentifierDoubleQuoted);
                            }
                            else if (currentInputCharacter.AnyOf('\u0027'))
                            {
                                OnSetParseError(ParseError.MissingWhitespaceAfterDoctypeSystemKeyword);
                                Token.SystemIdentifier = string.Empty;
                                OnChangeState(Tokens.State.DOCTYPESystemIdentifierSingleQuoted);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.MissingDoctypeSystemIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else
                            {
                                OnSetParseError(ParseError.MissingQuoteBeforeDoctypeSystemIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.BogusDOCTYPE);
                                data.ReadPosition--;
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInDoctype);
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.BeforeDOCTYPESystemIdentifier:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009', '\u000A', '\u000C', '\u0020'))
                            {
                                // ignore
                            }
                            else if (currentInputCharacter.AnyOf('\u0022'))
                            {
                                Token.SystemIdentifier = string.Empty;
                                OnChangeState(Tokens.State.DOCTYPESystemIdentifierDoubleQuoted);
                            }
                            else if (currentInputCharacter.AnyOf('\u0027'))
                            {
                                Token.SystemIdentifier = string.Empty;
                                OnChangeState(Tokens.State.DOCTYPESystemIdentifierSingleQuoted);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.MissingDoctypeSystemIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else
                            {
                                OnSetParseError(ParseError.MissingQuoteBeforeDoctypeSystemIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.BogusDOCTYPE);
                                data.ReadPosition--;
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInDoctype);
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.DOCTYPESystemIdentifierDoubleQuoted:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0022'))
                            {
                                OnChangeState(Tokens.State.AfterDOCTYPESystemIdentifier);
                            }
                            else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                Token.SystemIdentifier += '\uFFFD';
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.AbruptDoctypeSystemIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else
                            {
                                Token.SystemIdentifier += currentInputCharacter.Span[0];
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInDoctype);
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.DOCTYPESystemIdentifierSingleQuoted:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0027'))
                            {
                                OnChangeState(Tokens.State.AfterDOCTYPESystemIdentifier);
                            }
                            else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                Token.SystemIdentifier += '\uFFFD';
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.AbruptDoctypeSystemIdentifier);
                                Token.ForceQuirks = true;
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else
                            {
                                Token.SystemIdentifier += currentInputCharacter.Span[0];
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInDoctype);
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.AfterDOCTYPESystemIdentifier:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009', '\u000A', '\u000C', '\u0020'))
                            {
                                // ignore
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else
                            {
                                OnSetParseError(ParseError.UnexpectedCharacterAfterDoctypeSystemIdentifier);
                                OnChangeState(Tokens.State.BogusDOCTYPE);
                                data.ReadPosition--;
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInDoctype);
                            Token.ForceQuirks = true;
                            OnEmitToken(Token);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.BogusDOCTYPE:
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
                            }
                        }
                        else
                        {
                            OnEmitToken(Token);
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
