using System;
using System.Collections.Generic;
using System.Text;
using OpenccByCsharp.Src.DataTool;

namespace OpenccByCsharp.Src.DataDemo
{

    public class STCharclass
    {
        private STCharclass()
        {
        }

        public static Dictionary<string,List<string>> GetSTCharDictionary()
        {
            return DataProcess.DictionaryBuild("..\\..\\..\\Src\\DataSource\\STCharacters.txt");
        }
    }
}
