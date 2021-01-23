using System;

namespace My_Application
{
    public class OOP_01_Inheritance
    {
        public void Main()
        {
            PersionCarpet persion = new PersionCarpet();
            persion.Exhibit();
        }
        public class Carpe : ICleanable
        {
            public int Lenght { get; set; }
            public int Width { get; set; }
            public string Pattern { get; set; }
            public string Origin { get; set; }

            public void Sweep()
            {
                throw new NotImplementedException();
            }
        }

        public class PersionCarpet : IExhibit, ICleanable
        {
            public int Lenght { get; set; }
            public int Width { get; set; }
            public string Pattern { get; set; }
            public string Origin { get; set; }

            public void Exhibit()
            {
                throw new NotImplementedException();
            }

            public void Sweep()
            {
                throw new NotImplementedException();
            }
        }

        public interface ICleanable
        {
            void Sweep();
        }
        public interface IExhibit
        {
            void Exhibit();
        }

    }
}