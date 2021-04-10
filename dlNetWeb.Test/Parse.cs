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
            tokenizer.Run();
        }

        [Fact]
        public void ReadNamedCharacterREferenceFile()
        {
            //Newtonsoft.Json.JsonConvert.DeserializeObject(Path.)
        }
    }
}
