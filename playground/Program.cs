using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("test")]

namespace playground
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
            MainClass.Calculate();
        }

        public static void Calculate()
        {
            Console.WriteLine("Would you like to add, subtract, multiply or divide? - ");
            string input = Console.ReadLine();

            Console.WriteLine("First Number: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Second Number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Answer:");
            switch (input)
            {
                case "add":
                    Console.WriteLine(num1 + num2);
                    break;

                case "subtract":
                    Console.WriteLine(num1 - num2);
                    break;

                case "multiply":
                    Console.WriteLine(num1 * num2);
                    break;

                case "divide":
                    Console.WriteLine(num1 / num2);
                    break;

                default:
                    Console.WriteLine("Please type 'add' 'subtract' 'multiply' or 'divide'");
                    break;

            }
        }
    }
}
