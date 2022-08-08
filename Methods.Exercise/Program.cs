using System;

namespace Methods.Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            var name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("What is you favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine(color);

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine(animal);

            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();
            Console.WriteLine(band);

            Console.WriteLine(Methods.Add(77, 53));
            Console.WriteLine(Methods.Multiply(24, 56));
            Console.WriteLine(Methods.Subtract(76, 78));
            Console.WriteLine(Methods.Divide(566, 4012));
            Console.WriteLine(Methods.Modulus(566, 4012));
        }
    }
}
