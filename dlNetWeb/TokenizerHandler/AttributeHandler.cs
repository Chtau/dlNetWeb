using System;
using System.Collections.Generic;
using System.Text;
using dlNetWeb.Extensions;

namespace dlNetWeb.TokenizerHandler
{
    public class AttributeHandler : BaseHandler<Tokens.BaseTagToken>
    {
        // TODO: When the user agent leaves the attribute name state (and before emitting the tag token, if appropriate), the complete attribute's name must be compared to the other attributes on the same token; if there is already an attribute on the token with the exact same name, then this is a duplicate-attribute parse error and the new attribute must be removed from the token.

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
                    case Tokens.State.BeforeAttributeName:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009','\u000A','\u000C','\u0020'))
                            {
                                // ignore
                            } else if (currentInputCharacter.AnyOf('/', '>'))
                            {
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.AfterAttributeName);
                            } else if (currentInputCharacter.AnyOf('='))
                            {
                                OnSetParseError(ParseError.UnexpectedEqualsSignBeforeAttributeName);
                                Token.Attributes.Add(new Tokens.TokenAttribute
                                {
                                    Name = currentInputCharacter.Span[0].ToString(),
                                    Value = string.Empty
                                });
                                OnChangeState(Tokens.State.AttributeName);
                            } else
                            {
                                Token.Attributes.Add(new Tokens.TokenAttribute
                                {
                                    Name = string.Empty,
                                    Value = string.Empty
                                });
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.AttributeName);
                            }
                        } else
                        {
                            data.ReadPosition--;
                            OnChangeState(Tokens.State.AfterAttributeName);
                        }
                        break;
                    case Tokens.State.AttributeName:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009','\u000A','\u000C','\u0020','/','>'))
                            {
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.AfterAttributeName);
                            } else if (currentInputCharacter.AnyOf('='))
                            {
                                OnChangeState(Tokens.State.BeforeAttributeValue);
                            } else if (currentInputCharacter.IsLetterUpper())
                            {
                                Token.Attributes[^1].Name += currentInputCharacter.Span[0].ToString().ToLower();
                            } else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                Token.Attributes[^1].Name += '\uFFFD';
                            } else if (currentInputCharacter.AnyOf('\u0022','\u0027','<'))
                            {
                                OnSetParseError(ParseError.UnexpectedCharacterInAttributeName);
                                Token.Attributes[^1].Name += currentInputCharacter.Span[0].ToString();
                            } else
                            {
                                Token.Attributes[^1].Name += currentInputCharacter.Span[0].ToString();
                            }
                        } else
                        {
                            OnChangeState(Tokens.State.AfterAttributeName);
                            data.ReadPosition--;
                        }
                        break;
                    case Tokens.State.AfterAttributeName:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009','\u000A','\u000C','\u0020'))
                            {
                                // ignore
                            } else if (currentInputCharacter.AnyOf('/'))
                            {
                                OnChangeState(Tokens.State.SelfClosingStartTag);
                            }
                            else if (currentInputCharacter.AnyOf('='))
                            {
                                OnChangeState(Tokens.State.BeforeAttributeValue);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            } else
                            {
                                Token.Attributes.Add(new Tokens.TokenAttribute
                                {
                                    Name = string.Empty,
                                    Value = string.Empty
                                });
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.AttributeName);
                            }
                        } else
                        {
                            OnSetParseError(ParseError.EofInTag);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.BeforeAttributeValue:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009','\u000A','\u000C','\u0020'))
                            {
                                // ignore
                            } else if (currentInputCharacter.AnyOf('\u0022'))
                            {
                                OnChangeState(Tokens.State.AttributeValueDoubleQuoted);
                            }
                            else if (currentInputCharacter.AnyOf('\u0027'))
                            {
                                OnChangeState(Tokens.State.AttributeValueSingleQuoted);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnSetParseError(ParseError.MissingAttributeValue);
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            } else
                            {
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.AttributeValueUnquoted);
                            }
                        }
                        else
                        {
                            data.ReadPosition--;
                            OnChangeState(Tokens.State.AttributeValueUnquoted);
                        }
                        break;
                    case Tokens.State.AttributeValueDoubleQuoted:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0022'))
                            {
                                OnChangeState(Tokens.State.AfterAttributeValueQuoted);
                            } else if (currentInputCharacter.AnyOf('\u0026'))
                            {
                                state.ReturnState = Tokens.State.AttributeValueDoubleQuoted;
                                OnChangeState(Tokens.State.CharacterReference);
                            }
                            else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                Token.Attributes[^1].Value += '\uFFFD';
                            } else
                            {
                                Token.Attributes[^1].Value += currentInputCharacter.Span[0];
                            }
                        } else
                        {
                            OnSetParseError(ParseError.EofInTag);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.AttributeValueSingleQuoted:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0027'))
                            {
                                OnChangeState(Tokens.State.AfterAttributeValueQuoted);
                            }
                            else if (currentInputCharacter.AnyOf('\u0026'))
                            {
                                state.ReturnState = Tokens.State.AttributeValueSingleQuoted;
                                OnChangeState(Tokens.State.CharacterReference);
                            }
                            else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                Token.Attributes[^1].Value += '\uFFFD';
                            }
                            else
                            {
                                Token.Attributes[^1].Value += currentInputCharacter.Span[0];
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInTag);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.AttributeValueUnquoted:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009','\u000A','\u000C','\u0020'))
                            {
                                OnChangeState(Tokens.State.BeforeAttributeName);
                            } else if (currentInputCharacter.AnyOf('\u0026'))
                            {
                                state.ReturnState = Tokens.State.AttributeValueUnquoted;
                                OnChangeState(Tokens.State.CharacterReference);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            }
                            else if (currentInputCharacter.AnyOf('\u0000'))
                            {
                                OnSetParseError(ParseError.UnexpectedNullCharacter);
                                Token.Attributes[^1].Value += '\uFFFD';
                            } else if (currentInputCharacter.AnyOf('\u0022','\u0027','\u003C','\u003D','\u0060'))
                            {
                                OnSetParseError(ParseError.UnexpectedCharacterInUnquotedAttributeValue);
                                Token.Attributes[^1].Value += currentInputCharacter.Span[0];
                            } else
                            {
                                Token.Attributes[^1].Value += currentInputCharacter.Span[0];
                            }
                        } else
                        {
                            OnSetParseError(ParseError.EofInTag);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                        }
                        break;
                    case Tokens.State.AfterAttributeValueQuoted:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u0009','\u000A','\u000C','\u0020'))
                            {
                                OnChangeState(Tokens.State.BeforeAttributeName);
                            } else if (currentInputCharacter.AnyOf('/'))
                            {
                                OnChangeState(Tokens.State.SelfClosingStartTag);
                            }
                            else if (currentInputCharacter.AnyOf('>'))
                            {
                                OnChangeState(Tokens.State.Data);
                                OnEmitToken(Token);
                            } else
                            {
                                OnSetParseError(ParseError.MissingWhitespaceBetweenAttributes);
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.BeforeAttributeName);
                            }
                        } else
                        {
                            OnSetParseError(ParseError.EofInTag);
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
