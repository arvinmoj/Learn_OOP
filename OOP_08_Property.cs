using System;

namespace Learn_OOP_Console
{
    public class OOP_08_Property
    {
        public void Main()
        {
            Car car = new Car();
            car.Speed = 119;
            car.Name = "Peykan";
            car.DoorCount = 4;
            Console.WriteLine($"Name : {car.Name} Speed : {car.Speed} Door Count : {car.DoorCount} ");
        }

    }

    public class Car
    {
        private int _speed;
        private string _name;
        private int _doorCount;

        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value > 120)
                {
                    Console.WriteLine("Value Not Valid ....");
                    _speed = 120;
                }
                else
                {
                    _speed = value;
                }
            }
        } 

        public string Name { get; set; } = "Pride";

        public int DoorCount
        {
            get { return _doorCount; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _doorCount = value;
                }
                else
                {
                    throw new Exception("Value Not Valid");
                }
            }
        } 
    }   
}