using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VisitorPattern.EngineData;

namespace VisitorPattern
{
    public class CarRegistrationBuilder : ICarVisitor<CarRegistration>
    {

        private ICar _car;
        private string _make;
        private string _model;
        private float _engineCapacity;
        private int _seatsCount;

        public CarRegistrationBuilder(ICar car)
        {
            _car = car;
        }

        public void VisitCar(string make, string model)
        {
            _make = make;
            _model = model;
        }

        public void VisitEngine(EngineStructure structure, EngineStatus status)
        {
            _engineCapacity = structure.CylinderCount;
        }

        public void VisitSeat(Seat seat)
        {
            _seatsCount += seat.Capacity;
        }

        public CarRegistration ProduceResult()
        {
            _car.Accept(() => (ICarVisitor) this);
            return new CarRegistration(_make.ToUpper(), _model,
                                       _engineCapacity,
                                       _seatsCount);
        }
    }
}
