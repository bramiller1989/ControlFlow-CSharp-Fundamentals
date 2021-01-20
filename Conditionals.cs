using System;

namespace ControlFlow
{
    class Conditionals
    {
        public void Exercise1()
        {
            Console.WriteLine("Enter a number between 1 and 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid number");
            else 
                Console.WriteLine("Invalid number");
        }

        public void Exercise2()
        {
            Console.WriteLine("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);
        }

        public void Exercise3()
        {
            Console.WriteLine("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation;
        }

        static void Main(string[] args)
        {

        }
    }
}
