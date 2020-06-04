using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class CarToStringVisitor : ICarVisitor
    {
        private readonly StringBuilder _report = new StringBuilder();
        private int _seatCount;
        public void Visit(Engine engine)
        {
            _report.Append($" {engine.CylinderCount}cc {engine.HorsePower}hp");
        }

        public void Visit(Seat seat)
        {
            _seatCount += seat.Capacity;
        }

        public void Visit(string make, string model)
        {
            _report.Append($"{make} {model}");
        }

        public string GetCarDescription()
        {
            _report.Append($" {_seatCount} passengers");
            return _report.ToString();
        }
    }
}
