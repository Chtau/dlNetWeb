using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace dlNetWeb.Test
{
    public class Parse
    {
        [Fact]
        public void Tokenizer()
        {
            var file = System.IO.File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "TestFiles", "simple.html"));
            var tokenizer = new Tokenizer(file, new Data.SharedState());
            bool isEOF = false;
            tokenizer.EmitToken += (obj, token) =>
            {
                //System.Diagnostics.Debug.Print($"Token Emit: {token}{Environment.NewLine}{Newtonsoft.Json.JsonConvert.SerializeObject(token, Newtonsoft.Json.Formatting.Indented)}");
                if (token is Tokens.EndOfFileToken)
                    isEOF = true;
            };
            tokenizer.Run();
            do
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            } while (!isEOF);
            if (tokenizer.Error != ParseError.None)
                System.Diagnostics.Debug.Print($"Tokenizer Parse Error: {tokenizer.Error}");
            foreach (var token in tokenizer.EmittedTokens)
            {
                System.Diagnostics.Debug.Print($"Token Emit: {token}{Environment.NewLine}{Newtonsoft.Json.JsonConvert.SerializeObject(token, Newtonsoft.Json.Formatting.Indented)}");
            }
        }

        [Fact]
        public void TokenParse()
        {
            var sharedState = new Data.SharedState();
            var file = System.IO.File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "TestFiles", "simple.html"));
            var tokenizer = new Tokenizer(file, sharedState);
            var tokenParser = new TokenParser(sharedState);
            bool isEOF = false;
            tokenizer.EmitToken += (obj, token) =>
            {
                if (token is Tokens.EndOfFileToken)
                    isEOF = true;
            };
            tokenizer.Run();
            do
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            } while (!isEOF);
            if (tokenizer.Error != ParseError.None)
                System.Diagnostics.Debug.Print($"Tokenizer Parse Error: {tokenizer.Error}");
            
        }
    }
}
