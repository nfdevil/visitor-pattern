using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public interface ICarVisitor<T> : ICarVisitor
    {
        T ProduceResult();
    }
}
