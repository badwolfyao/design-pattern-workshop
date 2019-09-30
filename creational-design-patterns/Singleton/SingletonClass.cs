using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_patterns.Singleton
{
    public class SingletonClass
    {
        private static SingletonClass _instance = null; // private static instance to be the actual instance
        private Guid _classID = Guid.Empty; // example field use to compare returned instances

        /// <summary>
        /// public static instance used to access the private instance
        /// </summary>
        public static SingletonClass Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SingletonClass();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Example property used to compare returned instances
        /// </summary>
        public Guid ClassID
        {
            get
            {
                return _classID;
            }
            set
            {
                _classID = value;
            }
        }

        /// <summary>
        /// Private class constructor, so it can only be access within this class, therefore 
        /// class will never be able to be created from outside
        /// </summary>
        private SingletonClass()
        {
            _classID = Guid.NewGuid();
            Console.WriteLine($"SingletonClass Created with ID={this.ClassID}");
        }
    }
}
