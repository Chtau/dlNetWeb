using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.TokenizerHandler
{
    public class AttributeHandler : BaseHandler<Tokens.BaseToken>
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
                    case Tokens.State.BeforeAttributeName:
                        break;
                    case Tokens.State.AttributeName:
                        break;
                    case Tokens.State.AfterAttributeName:
                        break;
                    case Tokens.State.BeforeAttributeValue:
                        break;
                    case Tokens.State.AttributeValueDoubleQuoted:
                        break;
                    case Tokens.State.AttributeValueSingleQuoted:
                        break;
                    case Tokens.State.AttributeValueUnquoted:
                        break;
                    case Tokens.State.AfterAttributeValueQuoted:
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
