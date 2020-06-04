using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
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
