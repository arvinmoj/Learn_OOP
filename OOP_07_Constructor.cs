using System;

namespace Learn_OOP_Console
{
    public class OOP_07_Constructor
    {
        public void Main()
        {
            Console.WriteLine("Hello World!");

            var car = new Car();
            car.Speed = 200;
            // car.name = "Pride";
            car.doorCount = 2;

            System.Console.WriteLine($"Name: {car.name} , Speed: {car.Speed} , DoorCount: {car.doorCount}");
        }

        public class Car
        {
            public Car()
            {
                System.Console.WriteLine("Constructor");
                this.name = "BMW";
            }

            public Car(int speed)
            {
                this.Speed = speed;
            }

            public int Speed;
            public string name;
            public int doorCount;

            ~Car()
            {
                System.Console.WriteLine("Destructor");
            }
        }
    }
}