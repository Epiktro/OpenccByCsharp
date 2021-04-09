using System;
using System.Collections.Generic;
using System.Text;
using OpenccByCsharp.Src.DataTool;

namespace OpenccByCsharp.Src.DataDemo
{
    public class TSCharClass
    {
        private TSCharClass() { }

        public static Dictionary<string, List<string>> GetTSCharDictionary()
        {
            return DataProcess.DictionaryBuild("..\\..\\..\\Src\\DataSource\\TSCharacters.txt");
        }
    }
}
