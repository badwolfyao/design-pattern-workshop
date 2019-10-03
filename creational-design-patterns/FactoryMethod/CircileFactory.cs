using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_patterns.FactoryMethod
{
    public class CircileFactory : IShapeFactory
    {
        public Shape CreateShape()
        {
            Circle circle = new Circle();
            circle.ShapeName = "Circle";
            return circle;
        }
    }
}
