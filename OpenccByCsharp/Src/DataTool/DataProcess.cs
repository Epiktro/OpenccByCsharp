using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace OpenccByCsharp.Src.DataTool
{
    public class DataProcess
    {
        private  DataProcess()
        {
        }


        /// <summary>
        /// 从给定的字典中构建Dictionary
        /// </summary>
        /// <param name="file_path"></param>
        /// <returns></returns>
        public static Dictionary<string, List<string>> DictionaryBuild(string file_path)
        {
            try
            {
                Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
                //"..\\..\\..\\Src\\DataSource\\STCharacters.txt"
                using (StreamReader sr = new StreamReader(file_path, Encoding.UTF8)) 
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Regex regex = new Regex(@"\s+");
                        string[] strings = regex.Split(line);

                        List<string> temp_list = new List<string>();
                        for (int i=1;i<strings.Length;i++)
                        {
                            temp_list.Add(strings[i]);
                        }
                        dic.Add(strings[0], temp_list);   
                    }
                }
                return dic;
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                throw;
            }

        }
    }
    
}
