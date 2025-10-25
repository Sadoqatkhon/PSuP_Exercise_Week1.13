using System;
using System.Text;


namespace PSuP_Exercises_Week1._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume = GetDouble("V = ");
            double r1 = GetDouble("R1 = ");
            double r2 = GetDouble("R2 = ");
            double time = GetDouble("T = ");


            CalculateAndPrint(volume, r1, r2, time);

        }

        static void CalculateAndPrint(double volume, double r1, double r2, double time)
        {

            double fullVolume = (r1 + r2) * time;



            if ((volume - fullVolume) > 0)
            {
                double percentFull = (fullVolume / volume) * 100;
                Console.WriteLine($"--> The tank will be {percentFull:F2}% full ");

            }
            else
            {
                double overfill = fullVolume - volume;
                Console.WriteLine($"The tank will be overfilled by {overfill:F2} m3");
            }
        }


        static double GetDouble(string prompt)
        {
            double value;
            while (true)
            {

                Console.Write(promp);
                if (double.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.WriteLine("Invalid input! Please enter a number.");
            }
        }
    }
}
