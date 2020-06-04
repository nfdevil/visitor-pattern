using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    // Made CarRegistration a CarVisitor, because Engine data is not publicly accessible
    public class CarRegistration : ICarVisitor
    {
        private string _make;
        private string _model;
        private float _cylinders;
        private int _maxPassengers;

        public override string ToString()
            => $"# Registered car: {_make} {_model} {_cylinders}cc {_maxPassengers} passengers";

        public void VisitEngine(float cylinderCount, float horsePower, bool engineStarted)
        {
            _cylinders = cylinderCount;
        }

        public void VisitSeat(Seat seat)
        {
            _maxPassengers += seat.Capacity;
        }

        public void Visit(string make, string model)
        {
            _make = make;
            _model = model;
        }
    }
}
