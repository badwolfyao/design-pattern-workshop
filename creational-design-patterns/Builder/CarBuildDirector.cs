using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_patterns.Builder
{
    public class CarBuildDirector
    {
        private ICarBuilder _builder;

        public CarBuildDirector(ICarBuilder builder)
        {
            _builder = builder;
        }

        public void Build(string color, int doorCnt, string switchType)
        {
            _builder.SetColor(color);
            _builder.SetDoorCount(doorCnt);
            _builder.SetSwitch(switchType);
        }
    }
}
