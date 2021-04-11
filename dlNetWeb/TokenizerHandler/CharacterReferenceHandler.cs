using System;
using System.Collections.Generic;
using System.Text;

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
                            if (Char.IsLetterOrDigit(currentInputCharacter.Span[0]))
                            {
                                // Reconsume in the named character reference state.
                                state.State = Tokens.State.NamedCharacterReference;
                            }
                            else if (currentInputCharacter.Span[0] == '#')
                            {
                                temporaryBuffer += currentInputCharacter.Span[0];
                                state.State = Tokens.State.NumericCharacterReference;
                            }
                            else
                            {
                                data.ReadPosition--;
                                state.State = state.ReturnState;
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
                                    state.Error = ParseError.MissingSemicolonAfterCharacterReference;
                                }
                                // append characters from key to buffer
                                temporaryBuffer += _namedCharacterReference.Entities[matchKey].Characters;
                                // mark as consumed
                                data.ReadPosition += matchKey.Length - 1; // -1 because & was already consumed
                                state.State = state.ReturnState;
                            }
                            else
                            {
                                temporaryBuffer += currentInputCharacter.Span[0];
                                state.State = Tokens.State.AmbiguousAmpersand;
                            }
                        }
                        break;
                    case Tokens.State.NumericCharacterReference:
                        if (Char.IsLetter(currentInputCharacter.Span[0]))
                        {
                            temporaryBuffer += currentInputCharacter.Span[0];
                            state.State = Tokens.State.HexadecimalCharacterReferenceStart;
                        }
                        else
                        {
                            state.State = Tokens.State.DecimalCharacterReferenceStart;
                            data.ReadPosition--;
                        }
                        break;
                    case Tokens.State.HexadecimalCharacterReferenceStart:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (Char.IsLetter(currentInputCharacter.Span[0]))
                        {
                            state.State = Tokens.State.HexadecimalCharacterReference;
                        }
                        else
                        {
                            state.Error = ParseError.AbsenceOfDigitsInNumericCharacterReference;
                            state.State = state.ReturnState;
                        }
                        data.ReadPosition--;
                        break;
                    case Tokens.State.DecimalCharacterReferenceStart:
                        currentInputCharacter = data.NextChar(data.ReadPosition++);
                        if (Char.IsDigit(currentInputCharacter.Span[0]))
                        {
                            state.State = Tokens.State.DecimalCharacterReference;
                        }
                        else
                        {
                            state.Error = ParseError.AbsenceOfDigitsInNumericCharacterReference;
                            state.State = state.ReturnState;
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
