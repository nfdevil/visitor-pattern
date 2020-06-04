using System;
using System.Collections.Generic;
using System.Text;

using VisitorPattern.EngineData;

namespace VisitorPattern
{
    class CarRepository
    {
        public IEnumerable<Car> GetAll() => new [] {
            new Car("BMW", "3 Touring", new Engine(1821, 150), Seat.FourSeatConfiguration),
            new Car("Audi", "R8", new Engine(2011, 520), Seat.SportSeatConfiguration),
            new Car("Renault", "Clio", new Engine(1567, 100), Seat.FourSeatConfiguration),
            new Car("Toyota", "Auris", new Engine(1432, 75), Seat.FourSeatConfiguration)
        };
}
}
