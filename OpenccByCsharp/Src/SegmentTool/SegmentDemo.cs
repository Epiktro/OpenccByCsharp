using System;
using System.Collections.Generic;
using JiebaNet.Segmenter;
using System.Linq;

//使用结巴分词实现分词
namespace OpenccByCsharp.Src.SegmentTool
{
    public class SegmentDemo : Segment
    {
        public string[] doSegment(string source)
        {
            JiebaSegmenter jiebaSegmenter = new JiebaSegmenter();

            string[] strings = jiebaSegmenter.Cut(source).ToArray();

            return strings;
        }
    }
}
