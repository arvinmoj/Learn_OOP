using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace My_Application
{
    public class OOP_06_FileStream
    {
        public void Main()
        {
            OOP_06_FileStream pg = new OOP_06_FileStream();
            pg.Test4();
        }

        public void Test1()
        {
            string projectPath = Directory.GetCurrentDirectory();
            string filePath = (@"/Text/Text.txt");
            string path = projectPath + filePath;
            using (var sr = new StreamReader(path))
            {
                var line1 = sr.ReadLine();
            }
        }

        public void Test2()
        {
            string projectPath = Directory.GetCurrentDirectory();
            string filePath = (@"/Text/Text.txt");
            string path = projectPath + filePath;
            using (var sr = new StreamReader(path))
            {
                string line = null;

                while ((line = sr.ReadLine()) != null)
                {
                    var data = line.Split('\t');
                }
            }
        }

        public static IEnumerable<string> GetData(StreamReader sr)
        {
            string line = null;
            while ((line = sr.ReadLine()) != null)
            {
                yield return line;
            }
        }

        public void Test3()
        {
            string projectPath = Directory.GetCurrentDirectory();
            string filePath = (@"/Text/Text.txt");
            string path = projectPath + filePath;
            using (var sr = new StreamReader(path))
            {
                var data = GetData(sr);
                foreach (var line in data.ToList())
                {
                    Console.WriteLine(line);
                }
            }
        }

        public static IEnumerable<string> GetTextData(TextReader text)
        {
            string line = null;
            while ((line = text.ReadLine()) != null)
            {
                yield return line;
            }
        }

        public void Test4()
        {
            string projectPath = Directory.GetCurrentDirectory();
            string filePath = (@"/Text/Text.txt");
            string path = projectPath + filePath;
            using (var sr = new StreamReader(path))
            {
                foreach (var line in GetTextData(sr))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}