using System;
using System.Collections.Generic;
using System.Text;
using OpenccByCsharp.Src.DataTool;

namespace OpenccByCsharp.Src.DataDemo
{
    public class TSPhrasesClass
    {
        private TSPhrasesClass() { }

        public static Dictionary<string, List<string>> GetTSPhrasesDictionary()
        {
            return DataProcess.DictionaryBuild("..\\..\\..\\Src\\DataSource\\TSPhrases.txt");
        }
    }
}
