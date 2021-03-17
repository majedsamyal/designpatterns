using System;
using Patterns.creational.factory;

namespace designpatters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region Creational
            // Factory Design Pattern

            SamsungFactory samsungFactory = null;
            int budget = 15000;
            switch (budget)
            {
                case 15000:
                    samsungFactory = new PSeriesFactory();
                    break;
                case 10000:
                    samsungFactory = new SSeriesFactory();
                    break;
                default:
                    throw new NotImplementedException("");
            }

            var mobile = samsungFactory.CreateMobile();
            Console.WriteLine($"Samsung mobile {mobile.ModelName} costs you {mobile.Prize}");


            #endregion
        }
    }
}
