using System;
using OpenccByCsharp.Src.SegmentTool;
using OpenccByCsharp.Src.DataDictionary;
using System.Collections.Generic;
using System.Text;

namespace OpenccByCsharp.Src.ZhconvertFunc
{
    public class ZhConvertDemo:ZhConvert
    {
        private Segment segment = new SegmentDemo();

        private Dictionarys dictionarys = new DictionarysDemo();

        // 句子繁体转简体
        public string TraditionalToSimple(string source)
        {
            return this.Convert(source, segment, dictionarys.TSChar(), dictionarys.TSPhrases());
        }

        
        /// 句子简体转繁体
        public string SimpleToTraditional(string source)
        {
            return this.Convert(source, segment, dictionarys.STChar(), dictionarys.STPhrases());
        }


        private string Convert(string source,Segment segment,Dictionary<string,List<string>> CharDic, Dictionary<string, List<string>> PhrasesDic)
        {
            if (source.Length==0)
                return source;

            string[] strings = segment.doSegment(source);

            StringBuilder stringBuilder = new StringBuilder();
            for(int i=0;i<strings.Length;i++)
            {
                List<string> resultlist;
                try
                {
                    resultlist = PhrasesDic[strings[i]];
                }
                catch (Exception)
                {
                    resultlist = null;
                }

                if (resultlist != null)
                    stringBuilder.Append(resultlist[0]);
                else
                {
                    for(int j=0;j<strings[i].Length;j++)
                    {
                        try
                        {
                            resultlist = CharDic[strings[i][j].ToString()];
                        }
                        catch (Exception)
                        {
                            resultlist = null;
                        }
                        if (resultlist != null)
                            stringBuilder.Append(resultlist[0]);
                        else
                            stringBuilder.Append(strings[i][j]);
                    }
                }
            }
            return stringBuilder.ToString();
            
        }
    }
}
