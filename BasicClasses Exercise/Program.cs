using System;

namespace BasicClasses_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myFirstCar = new Car();

            myFirstCar.Make = "Toyota";
            myFirstCar.Model = "Tacoma";
            myFirstCar.Year = 1999;

            Console.WriteLine($"My first car was a {myFirstCar.Make} {myFirstCar.Model} that was made in the year {myFirstCar.Year}");
        }
    }
}
