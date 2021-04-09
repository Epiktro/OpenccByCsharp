using System;
using System.Collections.Generic;
using System.Text;
using OpenccByCsharp.Src.DataDemo;

namespace OpenccByCsharp.Src.DataDictionary
{
    public class DictionarysDemo:Dictionarys
    {
        
        public Dictionary<string, List<string>> TSChar()
        {
            return TSCharClass.GetTSCharDictionary();
        }


        public Dictionary<string, List<string>> TSPhrases()
        {
            return TSPhrasesClass.GetTSPhrasesDictionary();
        }


        public Dictionary<string, List<string>> STChar()
        {
            return STCharclass.GetSTCharDictionary();
        }


        public Dictionary<string, List<string>> STPhrases()
        {
            
            return STPhrasesClass.GetSTPhrasesDictionary();
        }
    }
}
