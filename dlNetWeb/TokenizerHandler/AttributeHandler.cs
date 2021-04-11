using System;
using System.Collections.Generic;
using System.Text;

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
                            if (currentInputCharacter.Span[0] == '\u0009'
                                || currentInputCharacter.Span[0] == '\u000A'
                                || currentInputCharacter.Span[0] == '\u000C'
                                || currentInputCharacter.Span[0] == '\u0020')
                            {
                                // ignore
                            } else if (currentInputCharacter.Span[0] == '/'
                                || currentInputCharacter.Span[0] == '>')
                            {
                                data.ReadPosition--;
                                state.State = Tokens.State.AfterAttributeName;
                            } else if (currentInputCharacter.Span[0] == '=')
                            {
                                state.Error = ParseError.UnexpectedEqualsSignBeforeAttributeName;
                                Token.Attributes.Add(new Tokens.TokenAttribute
                                {
                                    Name = currentInputCharacter.Span[0].ToString(),
                                    Value = string.Empty
                                });
                                state.State = Tokens.State.AttributeName;
                            } else
                            {
                                Token.Attributes.Add(new Tokens.TokenAttribute
                                {
                                    Name = string.Empty,
                                    Value = string.Empty
                                });
                                data.ReadPosition--;
                                state.State = Tokens.State.AttributeName;
                            }
                        } else
                        {
                            data.ReadPosition--;
                            state.State = Tokens.State.AfterAttributeName;
                        }
                        break;
                    case Tokens.State.AttributeName:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '\u0009'
                               || currentInputCharacter.Span[0] == '\u000A'
                               || currentInputCharacter.Span[0] == '\u000C'
                               || currentInputCharacter.Span[0] == '\u0020'
                               || currentInputCharacter.Span[0] == '/'
                               || currentInputCharacter.Span[0] == '>')
                            {
                                data.ReadPosition--;
                                state.State = Tokens.State.AfterAttributeName;
                            } else if (currentInputCharacter.Span[0] == '=')
                            {
                                state.State = Tokens.State.BeforeAttributeValue;
                            } else if (char.IsLetter(currentInputCharacter.Span[0]) && char.IsUpper(currentInputCharacter.Span[0]))
                            {
                                Token.Attributes[^1].Name += currentInputCharacter.Span[0].ToString().ToLower();
                            } else if (currentInputCharacter.Span[0] == '\u0000')
                            {
                                state.Error = ParseError.UnexpectedNullCharacter;
                                Token.Attributes[^1].Name += '\uFFFD';
                            } else if (currentInputCharacter.Span[0] == '\u0022'
                                || currentInputCharacter.Span[0] == '\u0027'
                                || currentInputCharacter.Span[0] == '<')
                            {
                                state.Error = ParseError.UnexpectedCharacterInAttributeName;
                                Token.Attributes[^1].Name += currentInputCharacter.Span[0].ToString();
                            } else
                            {
                                Token.Attributes[^1].Name += currentInputCharacter.Span[0].ToString();
                            }
                        } else
                        {
                            state.State = Tokens.State.AfterAttributeName;
                            data.ReadPosition--;
                        }
                        break;
                    case Tokens.State.AfterAttributeName:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '\u0009'
                               || currentInputCharacter.Span[0] == '\u000A'
                               || currentInputCharacter.Span[0] == '\u000C'
                               || currentInputCharacter.Span[0] == '\u0020')
                            {
                                // ignore
                            } else if (currentInputCharacter.Span[0] == '/')
                            {
                                state.State = Tokens.State.SelfClosingStartTag;
                            }
                            else if (currentInputCharacter.Span[0] == '=')
                            {
                                state.State = Tokens.State.BeforeAttributeValue;
                            }
                            else if (currentInputCharacter.Span[0] == '>')
                            {
                                state.State = Tokens.State.Data;
                                OnEmitToken(Token);
                            } else
                            {
                                Token.Attributes.Add(new Tokens.TokenAttribute
                                {
                                    Name = string.Empty,
                                    Value = string.Empty
                                });
                                data.ReadPosition--;
                                state.State = Tokens.State.AttributeName;
                            }
                        } else
                        {
                            state.Error = ParseError.EofInTag;
                            OnEmitToken(new Tokens.EndOfFileToken());
                        }
                        break;
                    case Tokens.State.BeforeAttributeValue:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '\u0009'
                               || currentInputCharacter.Span[0] == '\u000A'
                               || currentInputCharacter.Span[0] == '\u000C'
                               || currentInputCharacter.Span[0] == '\u0020')
                            {
                                // ignore
                            } else if (currentInputCharacter.Span[0] == '\u0022')
                            {
                                state.State = Tokens.State.AttributeValueDoubleQuoted;
                            }
                            else if (currentInputCharacter.Span[0] == '\u0027')
                            {
                                state.State = Tokens.State.AttributeValueSingleQuoted;
                            }
                            else if (currentInputCharacter.Span[0] == '>')
                            {
                                state.Error = ParseError.MissingAttributeValue;
                                state.State = Tokens.State.Data;
                                OnEmitToken(Token);
                            } else
                            {
                                data.ReadPosition--;
                                state.State = Tokens.State.AttributeValueUnquoted;
                            }
                        }
                        else
                        {
                            data.ReadPosition--;
                            state.State = Tokens.State.AttributeValueUnquoted;
                        }
                        break;
                    case Tokens.State.AttributeValueDoubleQuoted:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '\u0022')
                            {
                                state.State = Tokens.State.AfterAttributeValueQuoted;
                            } else if (currentInputCharacter.Span[0] == '\u0026')
                            {
                                state.ReturnState = Tokens.State.AttributeValueDoubleQuoted;
                                state.State = Tokens.State.CharacterReference;
                            }
                            else if (currentInputCharacter.Span[0] == '\u0000')
                            {
                                state.Error = ParseError.UnexpectedNullCharacter;
                                Token.Attributes[^1].Value += '\uFFFD';
                            } else
                            {
                                Token.Attributes[^1].Value += currentInputCharacter.Span[0];
                            }
                        } else
                        {
                            state.Error = ParseError.EofInTag;
                            OnEmitToken(new Tokens.EndOfFileToken());
                        }
                        break;
                    case Tokens.State.AttributeValueSingleQuoted:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '\u0027')
                            {
                                state.State = Tokens.State.AfterAttributeValueQuoted;
                            }
                            else if (currentInputCharacter.Span[0] == '\u0026')
                            {
                                state.ReturnState = Tokens.State.AttributeValueSingleQuoted;
                                state.State = Tokens.State.CharacterReference;
                            }
                            else if (currentInputCharacter.Span[0] == '\u0000')
                            {
                                state.Error = ParseError.UnexpectedNullCharacter;
                                Token.Attributes[^1].Value += '\uFFFD';
                            }
                            else
                            {
                                Token.Attributes[^1].Value += currentInputCharacter.Span[0];
                            }
                        }
                        else
                        {
                            state.Error = ParseError.EofInTag;
                            OnEmitToken(new Tokens.EndOfFileToken());
                        }
                        break;
                    case Tokens.State.AttributeValueUnquoted:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.Span[0] == '\u0009'
                               || currentInputCharacter.Span[0] == '\u000A'
                               || currentInputCharacter.Span[0] == '\u000C'
                               || currentInputCharacter.Span[0] == '\u0020')
                            {
                                state.State = Tokens.State.BeforeAttributeName;
                            } else if (currentInputCharacter.Span[0] == '\u0026')
                            {
                                state.ReturnState = Tokens.State.AttributeValueUnquoted;
                                state.State = Tokens.State.CharacterReference;
                            }
                            else if (currentInputCharacter.Span[0] == '>')
                            {
                                state.State = Tokens.State.Data;
                                OnEmitToken(Token);
                            }
                            else if (currentInputCharacter.Span[0] == '\u0000')
                            {
                                state.Error = ParseError.UnexpectedNullCharacter;
                                Token.Attributes[^1].Value += '\uFFFD';
                            } else if (currentInputCharacter.Span[0] == '\u0022'
                               || currentInputCharacter.Span[0] == '\u0027'
                               || currentInputCharacter.Span[0] == '\u003C'
                               || currentInputCharacter.Span[0] == '\u003D'
                               || currentInputCharacter.Span[0] == '\u0060')
                            {
                                state.Error = ParseError.UnexpectedCharacterInUnquotedAttributeValue;
                                Token.Attributes[^1].Value += currentInputCharacter.Span[0];
                            } else
                            {
                                Token.Attributes[^1].Value += currentInputCharacter.Span[0];
                            }
                        } else
                        {
                            state.Error = ParseError.EofInTag;
                            OnEmitToken(new Tokens.EndOfFileToken());
                        }
                        break;
                    case Tokens.State.AfterAttributeValueQuoted:
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
                            }
                            else if (currentInputCharacter.Span[0] == '>')
                            {
                                state.State = Tokens.State.Data;
                                OnEmitToken(Token);
                            } else
                            {
                                state.Error = ParseError.MissingWhitespaceBetweenAttributes;
                                data.ReadPosition--;
                                state.State = Tokens.State.BeforeAttributeName;
                            }
                        } else
                        {
                            state.Error = ParseError.EofInTag;
                            OnEmitToken(new Tokens.EndOfFileToken());
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
