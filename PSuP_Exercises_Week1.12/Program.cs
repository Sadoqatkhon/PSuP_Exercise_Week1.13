using System;


namespace PSuP_Exercises_Week1._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (volume, r1, r2, time) = GetMeasures();

            CalculateAndPrint(volume, r1, r2, time);    

        }

        static (int volume, double r1, double r2, double time) GetMeasures()
        {
            Console.Write("V = ");
            int volume = int.Parse(Console.ReadLine());

            Console.Write("R1 = ");
            double r1 = double.Parse(Console.ReadLine());

            Console.Write("R2 = ");
            double r2 = double.Parse(Console.ReadLine());

            Console.Write("T = ");
            double time = Convert.ToDouble(Console.ReadLine());

            return (volume, r1, r2, time);
        }





        static void CalculateAndPrint( int volume,double r1, double r2, double time)
        {
            
            double fullVolume = (r1 + r2) * time;
                      
                       

            if ( (volume - fullVolume )> 0)
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
    }
}
