using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_patterns.Prototype
{
    public abstract class Car : ICloneable
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public Guid ID { get; set; }

        public object Clone()
        {
            Car newCar = (Car) this.MemberwiseClone();
            newCar.ID = Guid.NewGuid();
            return newCar;
        }
    }
}
