using System;
using System.Collections.Generic;
using System.Text;

namespace OpenccByCsharp.Src.ZhconvertFunc
{
    public interface ZhConvert
    {
        /// <summary>
        /// 句子繁体转简体
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public string TraditionalToSimple(string source);

        /// <summary>
        /// 句子简体转繁体
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public string SimpleToTraditional(string source);

       


    }
}
