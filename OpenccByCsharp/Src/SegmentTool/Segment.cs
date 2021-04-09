using System;
using System.Collections.Generic;
using System.Text;

namespace OpenccByCsharp.Src.SegmentTool
{
    public interface Segment
    {
        /// <summary>
        /// 返回分词的结果
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
         string[] doSegment(string source);
    }
}
