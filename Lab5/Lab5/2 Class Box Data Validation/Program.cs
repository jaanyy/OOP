using System;

namespace _2_Class_Box_Data_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = Convert.ToDouble(Console.ReadLine());
            double width = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());

            Box box = new Box(length, width, height);

            try
            {
                Console.WriteLine(box.GetSurfaceArea());
                Console.WriteLine(box.GetLateralSurfaceArea());
                Console.WriteLine(box.GetVolume());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
