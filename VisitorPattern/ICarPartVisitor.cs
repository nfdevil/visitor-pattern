using System;
using System.Collections.Generic;
using System.Text;

using VisitorPattern.EngineData;

namespace VisitorPattern
{
    public interface ICarPartVisitor
    {
        // Engine has behavior (StartEngine()), so its data is also encapsulated
        // The Visit receives its data
        // void VisitEngine(float cylinderCount, float horsePower, bool engineStarted);
        void VisitEngine(EngineStructure engineStructure, EngineStatus engineStatus);
        // Seat has no behavior, it is a simple data structure, so it can be passed as full object
        void VisitSeat(Seat seat);
    }
}
