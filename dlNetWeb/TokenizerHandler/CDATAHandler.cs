using dlNetWeb.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public class CDATAHandler : BaseHandler<Tokens.CharacterToken>
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
                    case Tokens.State.CDATASection:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u005D'))
                            {
                                OnChangeState(Tokens.State.CDATASectionBracket);
                            }
                            else
                            {
                                OnEmitToken(new Tokens.CharacterToken { Value = currentInputCharacter.Span[0].ToString() });
                            }
                        }
                        else
                        {
                            OnSetParseError(ParseError.EofInCdata);
                            OnEmitToken(new Tokens.EndOfFileToken());
                            isEOF = true;
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.CDATASectionBracket:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u005D'))
                            {
                                OnChangeState(Tokens.State.CDATASectionEnd);
                            }
                            else
                            {
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u005D'.ToString() });
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.CDATASection);
                            }
                        }
                        break;
                    case Tokens.State.CDATASectionEnd:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.AnyOf('\u005D'))
                            {
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u005D'.ToString() });
                            } else if (currentInputCharacter.AnyOf('\u003E'))
                            {
                                OnChangeState(Tokens.State.Data);
                            }
                            else
                            {
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u005D'.ToString() });
                                OnEmitToken(new Tokens.CharacterToken { Value = '\u005D'.ToString() });
                                data.ReadPosition--;
                                OnChangeState(Tokens.State.CDATASection);
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
