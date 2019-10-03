using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_patterns.Prototype
{
    public class CarMaker
    {
        private Car _car;
        public CarMaker(Car car)
        {
            _car = car;
        }

        public Car MakeCar()
        {
            return (Car) _car.Clone();
        }
    }
}
