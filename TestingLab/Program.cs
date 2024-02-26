using System;

namespace TestingLab
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            IdealWeightCalculator idealWeightCalculatorForWomen = new IdealWeightCalculator
            {
                Height=176,
                Gender='w'
            };
            double WomenWeight=idealWeightCalculatorForWomen.GetIdealWeight();
            Console.WriteLine($"IdealWeightCalculatorForWomen => {WomenWeight}");
            if (WomenWeight == 63)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Succeeded");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Failed");
            }

            IdealWeightCalculator idealWeightCalculatorForMan = new IdealWeightCalculator
            {
                Height = 170,
                Gender = 'm'
            };
            double ManWeight = idealWeightCalculatorForMan.GetIdealWeight();
            Console.WriteLine($"IdealWeightCalculatorForMan => {ManWeight}");


            IdealWeightCalculator idealWeightCalculatorForUnknown = new IdealWeightCalculator
            {
                Height = 170,
                Gender = 'f'
            };
            double UnWeight = idealWeightCalculatorForUnknown.GetIdealWeight();
            Console.WriteLine($"IdealWeightCalculatorForUnknown => {UnWeight}");
            Console.ReadKey();
        }
    }
}
