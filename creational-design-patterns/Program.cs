using creational_design_patterns.AbstractFactory.Factories;
using creational_design_patterns.AbstractFactory.Models;
using creational_design_patterns.Builder;
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

            #region Builder

            Console.WriteLine("Builder".PadLeft(50, '-').PadRight(100, '-'));

            Client client = new Client();

            Car dodge = client.OrderDodgeCar();

            Car ford = client.OrderFordCar();

            Console.WriteLine($"Client ordered a {ford.Name} car, and has color={ford.Color}, doorCount={ford.DoorCount} and switchtype={ford.Switch}.");

            Console.WriteLine($"Client ordered a {dodge.Name} car, and has color={dodge.Color}, doorCount={dodge.DoorCount} and switchtype={dodge.Switch}.");

            #endregion Builder

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
