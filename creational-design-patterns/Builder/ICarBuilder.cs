using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_patterns.Builder
{
    public interface ICarBuilder
    {
        void SetColor(string color);
        void SetDoorCount(int doorCnt);
        void SetSwitch(string switchType);

        Car GetCar();
    }
}
