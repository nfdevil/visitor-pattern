using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    class CarView
    {
        private readonly IEnumerable<Car> _cars;

        public CarView(IEnumerable<Car> cars)
        {
            _cars = new List<Car>(cars);
        }

        public void Render()
        {
            foreach (Car car in _cars)
            {
                var converter = new CarToStringVisitor();
                car.Accept(converter);
                Console.WriteLine(converter.GetCarDescription());

            }
        }
    }
}
