using System;
using System.Collections.Generic;
using System.Text;
using creational_design_patterns.AbstractFactory.Models;

namespace creational_design_patterns.AbstractFactory.Factories
{
    /// <summary>
    /// Actual implementation of Ford Factory
    /// </summary>
    public class FordCarFactory : AbstractCarFactory
    {
        /// <summary>
        /// Create a Ford Headlight
        /// </summary>
        /// <returns>Ford Headlight</returns>
        public override Headlight CreateHeadlight()
        {
            return new FordHeadlight();
        }

        /// <summary>
        /// Create a Ford Tire
        /// </summary>
        /// <returns>Ford Tire</returns>
        public override Tire CreateTire()
        {
            return new FordTire();
        }
    }
}
