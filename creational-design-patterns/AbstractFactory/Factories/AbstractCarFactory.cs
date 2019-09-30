using creational_design_patterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_patterns.AbstractFactory.Factories
{
    /// <summary>
    /// Abstract Car Factory will be responsible of creating Tire and Headlight
    /// This class is abstract, the implementation will be in each child factory class
    /// </summary>
    public abstract class AbstractCarFactory
    {
        /// <summary>
        /// CreateTire will create tire, the implementation will be 
        /// in the Child class
        /// </summary>
        /// <returns>Tire object with specific type</returns>
        public abstract Tire CreateTire();
        /// <summary>
        /// CreateHeadlight will create tire, the implementation will be 
        /// in the Child class
        /// </summary>
        /// <returns>Headlight object with specific type</returns>
        public abstract Headlight CreateHeadlight();
    }
}
