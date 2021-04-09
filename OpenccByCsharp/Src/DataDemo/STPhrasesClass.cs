using System;
using System.Collections.Generic;
using System.Text;
using OpenccByCsharp.Src.DataTool;

namespace OpenccByCsharp.Src.DataDemo
{
    public class STPhrasesClass
    {
        private STPhrasesClass() { }

        public static Dictionary<string, List<string>> GetSTPhrasesDictionary()
        {
            return DataProcess.DictionaryBuild("..\\..\\..\\Src\\DataSource\\STPhrases.txt");
        }
    }
}
