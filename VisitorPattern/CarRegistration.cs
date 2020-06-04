using System;
using System.Collections.Generic;
using System.Text;

using VisitorPattern.EngineData;

namespace VisitorPattern
{
    // Made CarRegistration a CarVisitor, because Engine data is not publicly accessible
    public class CarRegistration
    {
        private readonly string _make;
        private readonly string _model;
        private readonly float _cylinders;
        private readonly int _maxPassengers;

        public CarRegistration(string make, string model, float cylinders, int maxPassengers)
        {
            _make = make;
            _model = model;
            _cylinders = cylinders;
            _maxPassengers = maxPassengers;
        }

        public override string ToString()
            => $"# Registered car: {_make} {_model} {_cylinders}cc {_maxPassengers} passengers";
    }
}
