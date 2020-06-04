using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    // Separate visitor for the object structure as a specification of the ICarPartVisitor
    // An implementation of this can receive the car object structure as well as data of the parts
    public interface ICarVisitor : ICarPartVisitor
    {
        //void Visit(Car car);
        // Preserve encapsulation by having the visit receive the needed data instead of the whole Car object
        // which does not have any data publicly available (all data are private fields)
        void VisitCar(string make, string model);
    }
}
