using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_patterns.Builder
{
    public class FordBuilder : ICarBuilder
    {
        private Car _car;

        public FordBuilder()
        {
            _car = new Car();
            _car.Name = "Ford";
        }

        public Car GetCar()
        {
            return _car;
        }

        public void SetColor(string color)
        {
            _car.Color = "Ford " + color;
        }

        public void SetDoorCount(int doorCnt)
        {
            _car.DoorCount = doorCnt;
        }

        public void SetSwitch(string swithType)
        {
            _car.Switch = "Ford " + swithType;
        }
    }
}
