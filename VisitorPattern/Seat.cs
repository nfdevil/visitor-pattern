using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Seat : IVisitable<ICarPartVisitor>
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Seat(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        public static IEnumerable<Seat> FourSeatConfiguration
            => new[]
            {
                new Seat("Driver", 1),
                new Seat("Passenger", 1),
                new Seat("Rear bench", 2), 
            };

        public static IEnumerable<Seat> SportSeatConfiguration
            => new[]
            {
                new Seat("Driver", 1),
                new Seat("Passenger", 1),
            };

        public void Accept(ICarPartVisitor visitor)
        {
            visitor.VisitSeat(this);
        }
    }
}
