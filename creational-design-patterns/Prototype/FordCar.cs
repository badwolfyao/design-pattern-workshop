using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_patterns.Prototype
{
    public class FordCar : Car
    {
        public FordCar()
        {
            base.Model = "Ford";
            base.ID = Guid.NewGuid();
        }
        public string FordCarFamily { get; set; }
    }
}
