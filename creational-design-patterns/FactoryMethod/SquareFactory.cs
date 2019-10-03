using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_patterns.FactoryMethod
{
    public class SquareFactory : IShapeFactory
    {
        public Shape CreateShape()
        {
            Square squre = new Square();
            squre.ShapeName = "Square";
            return squre;
        }
    }
}
