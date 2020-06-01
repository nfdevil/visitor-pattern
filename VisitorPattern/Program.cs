using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = {
                new Car("BMW", "3 Touring"),
                new Car("Audi", "A6"),
                new Car("Renault", "Clio"),
                new Car("Toyota", "Auris")
            };
            foreach (Car car in cars)
            {
                Console.WriteLine(car.GetDescription());
            }
        }
    }
}
