using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("calculator")]

namespace playground
{
    class MyClass
    {
        public static void Main()
        {
            Console.WriteLine("this test is running 'calculator'");
            MainClass.Calculate();
        }
    }
}