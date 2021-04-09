using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using OpenccByCsharp.Src.DataTool;
using JiebaNet.Segmenter;
using System.Linq;
using OpenccByCsharp.Src.ZhconvertFunc;

namespace OpenccByCsharp
{
    class ZhConvertTest
    {
        static void Main(string[] args)
        {
            string sff = "奮鬥奮鬥奮鬥奮鬥奮鬥奮鬥奮鬥奮鬥奮鬥奮鬥奮鬥奮鬥奮鬥";
            Console.WriteLine(new ZhConvertDemo().TraditionalToSimple(sff));

            
        }
    }
}
