using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_patterns.Builder
{
    public class DodgeBuilder : ICarBuilder
    {
        private Car _car;

        public DodgeBuilder()
        {
            _car = new Car();
            _car.Name = "Dodge";
        }

        public Car GetCar()
        {
            return _car;
        }

        public void SetColor(string color)
        {
            _car.Color = "Dodge " + color;
        }

        public void SetDoorCount(int doorCnt)
        {
            _car.DoorCount = doorCnt;
        }

        public void SetSwitch(string switchType)
        {
            _car.Switch = "Dodge " + switchType;
        }
    }
}
