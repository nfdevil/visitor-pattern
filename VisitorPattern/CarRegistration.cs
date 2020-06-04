using System;
using System.Collections.Generic;
using System.Text;

using VisitorPattern.EngineData;

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

        public void VisitEngine(EngineStructure engineStructure, EngineStatus engineStatus)
        {
            _cylinders = engineStructure.CylinderCount;
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
