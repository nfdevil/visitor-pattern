using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public interface ICarPartVisitor : IVisitor
    {
        void Visit(Engine engine);
        void Visit(Seat seat);
    }
}
