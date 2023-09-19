using System;

namespace enumExample
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine($"{Colors.Red}, Index: {(int)Colors.Red}");
            Console.WriteLine($"{Colors.Green}, Index: {(int)Colors.Green}");
            Console.WriteLine($"{Colors.Blue}, Index: {(int)Colors.Blue}");

            int colorValue = 256;
            if (colorValue <= (int)ColorIntensity.Low)
                Console.WriteLine("The color intensity is low.");
            else if (colorValue >= (int)ColorIntensity.Medium && colorValue < (int)ColorIntensity.High)
                Console.WriteLine("The color intensity is medium.");
            else if (colorValue >= (int)ColorIntensity.High)
                Console.WriteLine("The color intensity is high.");
        }

        enum Colors
        {
            Red,
            Green,
            Blue
        }

        enum ColorIntensity
        {
            Low = 50,
            Medium = 150,
            High = 255
        }
    }
}
