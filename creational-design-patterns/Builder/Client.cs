using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_patterns.Builder
{
    public class Client
    {
        string color = "red";
        int doorCnt = 2;
        string switchType = "auto";
        public Car OrderFordCar()
        {
            ICarBuilder builder = new FordBuilder();
            CarBuildDirector director = new CarBuildDirector(builder);
            director.Build(color, doorCnt, switchType);
            return builder.GetCar();
        }

        public Car OrderDodgeCar()
        {
            ICarBuilder builder = new DodgeBuilder();
            CarBuildDirector director = new CarBuildDirector(builder);
            director.Build(color, doorCnt, switchType);
            return builder.GetCar();
        }
    }
}
