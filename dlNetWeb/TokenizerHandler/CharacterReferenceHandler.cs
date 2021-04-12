using System;
using System.Collections.Generic;
using System.Text;
using dlNetWeb.Extensions;

namespace dlNetWeb.TokenizerHandler
{
    public class CharacterReferenceHandler : BaseHandler<Tokens.BaseToken>
    {
        private readonly Data.NamedCharacterReferenceData _namedCharacterReference = new Data.NamedCharacterReferenceData();

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
                    case Tokens.State.CharacterReference:
                        temporaryBuffer = string.Empty;
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (!currentInputCharacter.IsEmpty)
                        {
                            if (currentInputCharacter.IsLetterOrDigit())
                            {
                                // Reconsume in the named character reference state.
                                OnChangeState(Tokens.State.NamedCharacterReference);
                            }
                            else if (currentInputCharacter.AnyOf('#'))
                            {
                                temporaryBuffer += currentInputCharacter.Span[0];
                                OnChangeState(Tokens.State.NumericCharacterReference);
                            }
                            else
                            {
                                data.ReadPosition--;
                                OnChangeState(state.ReturnState);
                            }
                        }
                        else
                        {
                            exitLoop = true;
                        }
                        break;
                    case Tokens.State.NamedCharacterReference:
                        string namedChar = string.Empty + currentInputCharacter.Span[0];
                        //temporaryBuffer += namedChar;
                        if (true)//!consumeAsAttribute)
                        {
                            // peak till no match for a key in _namedCharacterReference
                            string matchKey = null;
                            for (int i = 1; i < _namedCharacterReference.MaxKeyLength; i++)
                            {
                                var match = _namedCharacterReference.HasMatchingKeys(namedChar);
                                if (string.IsNullOrWhiteSpace(match))
                                    break;
                                else
                                {
                                    matchKey = match;
                                    namedChar += data.NextChar(data.ReadPosition + 1, 1 + i);
                                }
                            }
                            if (matchKey.Length > 0)
                            {
                                if (matchKey[^1] != ';')
                                {
                                    OnSetParseError(ParseError.MissingSemicolonAfterCharacterReference);
                                }
                                // append characters from key to buffer
                                temporaryBuffer += _namedCharacterReference.Entities[matchKey].Characters;
                                // mark as consumed
                                data.ReadPosition += matchKey.Length - 1; // -1 because & was already consumed
                                OnChangeState(state.ReturnState);
                            }
                            else
                            {
                                temporaryBuffer += currentInputCharacter.Span[0];
                                OnChangeState(Tokens.State.AmbiguousAmpersand);
                            }
                        }
                        break;
                    case Tokens.State.NumericCharacterReference:
                        if (currentInputCharacter.IsLetter())
                        {
                            temporaryBuffer += currentInputCharacter.Span[0];
                            OnChangeState(Tokens.State.HexadecimalCharacterReferenceStart);
                        }
                        else
                        {
                            OnChangeState(Tokens.State.DecimalCharacterReferenceStart);
                            data.ReadPosition--;
                        }
                        break;
                    case Tokens.State.HexadecimalCharacterReferenceStart:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (currentInputCharacter.IsLetter())
                        {
                            OnChangeState(Tokens.State.HexadecimalCharacterReference);
                        }
                        else
                        {
                            OnSetParseError(ParseError.AbsenceOfDigitsInNumericCharacterReference);
                            OnChangeState(state.ReturnState);
                        }
                        data.ReadPosition--;
                        break;
                    case Tokens.State.DecimalCharacterReferenceStart:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (currentInputCharacter.IsDigit())
                        {
                            OnChangeState(Tokens.State.DecimalCharacterReference);
                        }
                        else
                        {
                            OnSetParseError(ParseError.AbsenceOfDigitsInNumericCharacterReference);
                            OnChangeState(state.ReturnState);
                        }
                        data.ReadPosition--;
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
