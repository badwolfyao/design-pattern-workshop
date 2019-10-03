using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_patterns.FactoryMethod
{
    public interface IShapeFactory
    {
        Shape CreateShape();
    }
}
