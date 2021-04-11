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
            var tokenizer = new Tokenizer(file);
            tokenizer.EmitToken += (obj, token) =>
            {
                System.Diagnostics.Debug.Print($"Token Emit:{token}");
            };
            tokenizer.Run();
            do
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            } while (true);
        }
    }
}
