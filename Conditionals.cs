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
            Console.WriteLine("Image orientation is " + orientation);
        }

        public void Exercise4()
        {
            Console.WriteLine("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;

                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }

        static void Main(string[] args)
        {
            Conditionals conditionals = new Conditionals();

            conditionals.Exercise1();
            conditionals.Exercise2();
            conditionals.Exercise3();
            conditionals.Exercise4();


        }
    }
}
