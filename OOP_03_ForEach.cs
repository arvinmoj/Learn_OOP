using System;
using System.Collections.Generic;

namespace My_Application
{
    public class OOP_03_ForEach
    {
        public void Main()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Foreach
            // foreach (var num in numbers)
            // {
            //     System.Console.WriteLine(num);
            // }

            //GetEnumerator
            // var e = numbers.GetEnumerator();

            // bool num1 = e.MoveNext();
            // int current1 = e.Current;

            // bool num2 = e.MoveNext();
            // int current2 = e.Current;

            // bool num3 = e.MoveNext();
            // int current3 = e.Current;

            // bool num4 = e.MoveNext();
            // int current4 = e.Current;

            // bool num5 = e.MoveNext();
            // int current5 = e.Current;

            // bool num6 = e.MoveNext();
            // int current6 = e.Current;

            // bool num7 = e.MoveNext();
            // int current7 = e.Current;

            // bool num8 = e.MoveNext();
            // int current8 = e.Current;

            // bool num9 = e.MoveNext();
            // int current9 = e.Current;

            // bool num10 = e.MoveNext();
            // int current10 = e.Current;
            //bool istrue = (numbers is IEnumerable<int>);

            // While
            var e = numbers.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
        }
    }
}