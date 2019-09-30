using creational_design_patterns.Singleton;
using System;

namespace creational_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Singleton

            ShowSinglton();

            #endregion Singleton

        }

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
    }
}
