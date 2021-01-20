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

        static void Main(string[] args)
        {

        }
    }
}
