using System;

namespace ClassBox
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double[] tokens = new double[3];

            for (int i = 0; i < 3; i++)
            {
                double currentData = double.Parse(Console.ReadLine());

                tokens[i] = currentData;
            }

            double length = tokens[0];
            double width = tokens[1];
            double height = tokens[2];

            Box box = null;

            try
            {
                box = new Box(length, width, height);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");

            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");

            Console.WriteLine($"Volume - {box.Volume():f2}");

        }
    }
}
