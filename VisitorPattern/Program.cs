using System;
using System.Collections.Generic;
using System.Linq;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Car> cars = new CarRepository().GetAll();

            Car oneCar = cars.First();
            CarRegistration carRegistration = oneCar.Register();
            Console.WriteLine(carRegistration);

            oneCar.Accept(() => new SaveCarVisitor());

            var carView = new CarView(cars);

            
            carView.Render();
        }
    }
}
