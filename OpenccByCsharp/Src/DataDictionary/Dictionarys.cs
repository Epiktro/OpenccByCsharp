using System;
using System.Collections.Generic;
using System.Text;


namespace OpenccByCsharp.Src.DataDictionary
{
    public interface Dictionarys
    {
        /// <summary>
        /// 返回 繁体->简体 的单字Dictionary
        /// </summary>
        /// <returns></returns>
        Dictionary<string, List<string>> TSChar();

        /// <summary>
        /// 返回 繁体->简体 的词组Dictionary
        /// </summary>
        /// <returns></returns>
        Dictionary<string, List<string>> TSPhrases();

        /// <summary>
        /// 返回 简体->繁体 的单字Dictionary
        /// </summary>
        /// <returns></returns>
        Dictionary<string, List<string>> STChar();

        /// <summary>
        /// 返回 简体->繁体 的词组Dictionary
        /// </summary>
        /// <returns></returns>
        Dictionary<string, List<string>> STPhrases();


    }
}
