using System;

namespace Learn_OOP_Console
{
    public class OOP_09_Static
    {
        public void Main()
        {
            Person p1=new Person();
            p1.Name = "Iman";

            Person p2=new Person();
            p2.Name = "Ali";

            Person p3=new Person();
            p3.Name = "Mina";


            Console.WriteLine(p1.ToString());
           
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p2.Sum());
            Console.WriteLine(p3.ToString());
            Console.WriteLine(Person.SayHello("Iman Madaeny"));

            People.Sum(4, 5);
        }
    }

    static class People
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }

    class Person
    {
        public static string Gender = "Male";
        public string Name;
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public override string ToString()
        {
            return this.Name + Gender;
        }

        public string Sum()
        {
            return this.Name;
        }

        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}