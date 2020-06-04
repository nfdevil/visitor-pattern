using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using VisitorPattern.EngineData;

namespace VisitorPattern
{
    public class Car : IVisitable<ICarVisitor>
    {
        private readonly string _make;
        private readonly string _model;
        private readonly Engine _engine;
        private readonly IEnumerable<Seat> _seats;

        public Car(string make, string model, Engine engine, IEnumerable<Seat> seats)
        {
            _make = make;
            _model = model;
            _engine = engine;
            _seats = new List<Seat>(seats);
        }

        public CarRegistration Register()
        {
            var carRegistration = new CarRegistration();
            Accept(carRegistration);
            return carRegistration;
        }
        public void Accept(ICarVisitor visitor)
        {
            visitor.Visit(_make, _model);
            _engine.Accept(visitor);
            foreach (Seat seat in _seats)
            {
                seat.Accept(visitor);
            }
        }
    }
}
