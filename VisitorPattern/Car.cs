using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            => new CarRegistration(_make, _model, _engine.CylinderCount, _seats.Sum(x => x.Capacity));

        public void Accept(ICarVisitor visitor)
        {
            visitor.Visit(_make, _model);
            visitor.Visit(_engine);
            foreach (Seat seat in _seats)
            {
                visitor.Visit(seat);
            }
        }
    }
}
