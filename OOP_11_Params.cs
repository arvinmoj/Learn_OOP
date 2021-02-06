using System;

namespace Learn_OOP_Console
{
    public class OOP_11_Params
    {
        public void Main()
        {
            MyClass.ShowPerson("Iman", 30, "Iman", "Ali", "reza", "Mina", "Hosein");
        }
        class MyClass
        {
            public static void ShowPerson(string name, int age, params string[] childs)
            {
                Console.WriteLine(name + " - " + age);
                foreach (var child in childs)
                {
                    Console.WriteLine(child);
                }
            }
        }
    }
}