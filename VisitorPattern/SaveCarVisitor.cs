using System;
using System.Collections.Generic;

using VisitorPattern.EngineData;

namespace VisitorPattern
{
    public class SaveCarVisitor : ICarVisitor
    {
        private readonly CarPersistence persistence = new CarPersistence();
        private int carId;
        private string make;
        private string model;
        private float power;
        private float cylinderVolume;
        private readonly Queue<(string name, int capacity)> seats = new Queue<(string name, int capacity)>();

        public void VisitCar(string make, string model)
        {
            this.make = make;
            this.model = model;
            ProcessQueue();
        }

        public void VisitEngine(EngineStructure structure, EngineStatus status)
        {
            power = structure.HorsePower;
            cylinderVolume = structure.CylinderCount;
            ProcessQueue();
        }

        public void VisitSeat(Seat seat)
        {
            seats.Enqueue((seat.Name, seat.Capacity));
            ProcessQueue();
        }

        private void ProcessQueue()
        {
            SaveCar();
            SaveEngine();
            SaveSeats();
        }

        private void SaveCar()
        {
            if (carId == 0 && model != null)
            {
                carId = persistence.InsertCar(make, model);
            }
        }

        private void SaveEngine()
        {
            if (carId > 0 && power > 0)
            {
                persistence.InsertEngine(carId, power,
                                         cylinderVolume);
                power = 0;
            }
        }

        private void SaveSeats()
        {
            if (carId <= 0)
            {
                return;
            }

            while (seats.Count > 0)
            {
                (string name, int capacity) = seats.Dequeue();
                persistence.InsertSeat(carId, name, capacity);
            }
        }
    }
}