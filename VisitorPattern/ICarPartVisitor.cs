using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public interface ICarPartVisitor : IVisitor
    {
        // Engine has behavior (StartEngine()), so its data is also encapsulated
        // The Visit receives its data
        void VisitEngine(float cylinderCount, float horsePower, bool engineStarted);
        // Seat has no behavior, it is a simple data structure, so it can be passed as full object
        void VisitSeat(Seat seat);
    }
}
