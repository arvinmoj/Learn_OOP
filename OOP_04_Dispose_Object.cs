using System.IO;

namespace My_Application
{
    public class OOP_04_Dispose_Object
    {
        public void Main()
        {

        }

        public void Test1()
        {
            // Be Har Dalili Exception Tollid Shavad Close Nmishavad ;  
            string projectPath = Directory.GetCurrentDirectory();
            string filePath = (@"/Text/Text.txt");
            string path = projectPath + filePath;
            System.Console.WriteLine(path);
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            var txt = fs.ReadByte();
            fs.Close();
        }

        public void Test2()
        {
            string projectPath = Directory.GetCurrentDirectory();
            string filePath = (@"/Text/Text.txt");
            string path = projectPath + filePath;
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
                // Be Dalil Ghavanin C# Har Moteghayer Dar Dakhel {} Khodash Tarif Mishavad
                // fs.Close();
            }
        }

        public void Test3()
        {
            string projectPath = Directory.GetCurrentDirectory();
            string filePath = (@"/Text/Text.txt");
            string path = projectPath + filePath;

            // Kharej {} Tarif Mikonim
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                var txt = fs.ReadByte();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Error:" + ex);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }

                // Or 

                fs?.Close();
            }
        }
    }
}