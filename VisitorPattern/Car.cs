using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Car
    {
        public string Make { get; set; }
        public string Type { get; set; }

        public Car(string make, string type)
        {
            Make = make;
            Type = type;
        }

        public string GetDescription()
            => $"{Make} {Type}";
    }
}
