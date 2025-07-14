using System;
using ClassLibrary;


namespace CSharpOOP
{
    internal class DotNETClassLibrary
    {


        public static void Run()
        {


            Console.WriteLine("_______________________.NET Class Library_______________________");

            Console.WriteLine("Using clsMath in ClassLibrary:");
            Console.WriteLine("Sum of (10, 20): {0}",clsMath.Sum(10, 20));
            Console.WriteLine("Sum of (10, 20, 30): {0}", clsMath.Sum(10, 20, 30));


            Console.WriteLine("________________________________________________________________\n");


        }


    }
}
