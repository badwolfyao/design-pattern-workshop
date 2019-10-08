using behavior_design_patterns.ChainOfResponsibility;
using System;

namespace behavior_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Behavior Design Pattern".PadLeft(50, '-').PadRight(100, '-'));

            #region Chain Of Responsibility

            Console.WriteLine("Chain Of Responsibility".PadLeft(50, '-').PadRight(100, '-'));

            ChainOfResponsibility();

            #endregion Chain Of Responsibility
        }

        static void ChainOfResponsibility()
        {
            ChainOfResponsibilityDemo demo = new ChainOfResponsibilityDemo();
            demo.DemoProcessing();
        }
    }
}
