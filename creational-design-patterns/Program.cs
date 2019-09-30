using creational_design_patterns.AbstractFactory.Factories;
using creational_design_patterns.AbstractFactory.Models;
using creational_design_patterns.Singleton;
using System;

namespace creational_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creational Design Pattern".PadLeft(50, '-').PadRight(100, '-'));

            #region Abstract Factory

            Console.WriteLine("Abstract Factory".PadLeft(50, '-').PadRight(100, '-'));

            string carModel = "Ford";
            CreateTire(carModel);

            carModel = "Dodge";
            CreateHeadlight(carModel);

            #endregion Abstract Factory

            #region Singleton

            Console.WriteLine("Singleton".PadLeft(50, '-').PadRight(100, '-'));

            ShowSinglton();

            #endregion Singleton

        }

        /// <summary>
        /// A method to show how singleton works
        /// </summary>
        static void ShowSinglton()
        {
            SingletonClass singletonClass1 = SingletonClass.Instance;
            SingletonClass singletonClass2 = SingletonClass.Instance;
            if(singletonClass1.ClassID == singletonClass2.ClassID)
            {
                Console.WriteLine($"ID for singletonClass1 is {singletonClass1.ClassID}");
                Console.WriteLine($"ID for singletonClass2 is {singletonClass2.ClassID}");
                Console.WriteLine("They are identical.");
            }
            else
            {
                Console.WriteLine("Something goes wrong");
            }
        }

        /// <summary>
        /// A method to show how AbstractFactory works
        /// </summary>
        static void CreateTire(string carModel)
        {
            AbstractCarFactory carFactory = null;

            Console.WriteLine("Creating Tire");

            switch (carModel)
            {
                case "Ford":
                    carFactory = new FordCarFactory();
                    break;
                case "Dodge":
                    carFactory = new DodgeCarFactory();
                    break;
                default:
                    break;
            }

            Tire tire = carFactory.CreateTire();

            Console.WriteLine($"Created Tire and the name = {tire.Name}");
        }

        /// <summary>
        /// A method to show how AbstractFactory works
        /// </summary>
        static void CreateHeadlight(string carModel)
        {
            AbstractCarFactory carFactory = null;

            Console.WriteLine("Creating Headlight");

            switch (carModel)
            {
                case "Ford":
                    carFactory = new FordCarFactory();
                    break;
                case "Dodge":
                    carFactory = new DodgeCarFactory();
                    break;
                default:
                    break;
            }

            Headlight headlight = carFactory.CreateHeadlight();

            Console.WriteLine($"Created Headlight and the name = {headlight.Name}");
        }
    }
}
