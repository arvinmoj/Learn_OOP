using System;
using System.IO;

namespace My_Application
{
    public class OOP_05_IDisposable
    {
        public void Main()
        {

        }

        public void Test1()
        {
            string projectPath = Directory.GetCurrentDirectory();
            string filePath = (@"/Text/Text.txt");
            string path = projectPath + filePath;
            FileStream fileStream = null;
            IDisposable idFileStram = fileStream;

            try
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                var txt = fs.ReadByte();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Error:" + ex);
            }
            finally
            {
                if (idFileStram != null)
                {
                    idFileStram.Dispose();
                }
                idFileStram?.Dispose();
            }
        }

        public void Test2()
        {
            string projectPath = Directory.GetCurrentDirectory();
            string filePath = (@"/Text/Text.txt");
            string path = projectPath + filePath;

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                var txt = fs.ReadByte();
            }
        }
    }
}