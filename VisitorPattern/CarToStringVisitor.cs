using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VisitorPattern.EngineData;

namespace VisitorPattern
{
    public class CarToStringVisitor : ICarVisitor<string>
    {
        // Separate detail fields to make sure if the order of the "Visit()" calls is changed, the order
        // of the strings is still OK, which is defined in the GetCarDescription() method
        private string _carDetails;
        private string _engineDetails;
        
        private int _seatCount;
        public void VisitEngine(EngineStructure engineStructure, EngineStatus engineStatus)
        {
            _engineDetails = $"{engineStructure.CylinderCount}cc {engineStructure.HorsePower}hp";
        }

        public void VisitSeat(Seat seat)
        {
            _seatCount += seat.Capacity;
        }

        public void VisitCar(string make, string model)
        {
            _carDetails = $"{make} {model}";
        }

        public string ProduceResult()
        {
            return $"{_carDetails} {_engineDetails} {_seatCount} passengers";
        }
    }
}
