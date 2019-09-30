using System;
using System.Collections.Generic;
using System.Text;
using creational_design_patterns.AbstractFactory.Models;

namespace creational_design_patterns.AbstractFactory.Factories
{
    /// <summary>
    /// Actual implementaiton for Abstract Factory for Dodge
    /// </summary>
    public class DodgeCarFactory : AbstractCarFactory
    {
        /// <summary>
        /// Create Dodge Headlight
        /// </summary>
        /// <returns>Dodge Headlight</returns>
        public override Headlight CreateHeadlight()
        {
            return new DodgeHeadlight();
        }

        /// <summary>
        /// Create Dodge Tire
        /// </summary>
        /// <returns>Dodge Tire</returns>
        public override Tire CreateTire()
        {
            return new DodgeTire();
        }
    }
}
