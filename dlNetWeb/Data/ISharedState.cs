using System;
using System.Collections.Generic;
using System.Text;

namespace dlNetWeb.Data
{
    public interface ISharedState
    {
        Tokens.State State { get; set; }
        Tokens.State ReturnState { get; set; }
        Tokens.BaseToken Token { get; set; }
        ParseError Error { get; set; }
        string TemporaryBuffer { get; set; }
        List<Tokens.BaseToken> Tokens { get; set; }
        Int32 CharacterReferenceCode { get; set; }
        InsertionMode InsertionMode { get; set; }
        /// <summary>
        /// This function calls an synchrone listener callback action
        /// </summary>
        /// <param name="token">Current emitted token from the Tokenizer</param>
        /// <returns></returns>
        bool EmitToken(Tokens.BaseToken token);
        void RegisterTokenEmitListener(Func<Tokens.BaseToken, bool> listenerAction);
    }
}
