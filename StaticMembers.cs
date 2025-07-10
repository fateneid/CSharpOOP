using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{

    internal class StaticMembers
    {

        class clsA
        {
            public int x1;
            //x2 is shared for all object because it's on the class level
            public static int x2;

            public int Method1()
            {
                //non-static methods can always access the static members
                return x1 + x2;
            }

            public static int Method2()
            {
                return x2;
            }

        }

        public static void Run()
        {


            Console.WriteLine("_________________________Static Members_________________________");


            clsA objA1 = new clsA();
            clsA objA2 = new clsA();

            objA1.x1 = 7;
            objA2.x1 = 10;

            //cannot be accessed through object, only through the class itself. but in C++ it is Ok.
            //objA1.x2 = 100;   //wrong

            //x2 is shared for all object because it's on the class level, it can be accessed using the class name.
            clsA.x2 = 100;

            Console.WriteLine("objA1.x1: {0}", objA1.x1);
            Console.WriteLine("objA2.x1: {0}", objA2.x1);
            Console.WriteLine("objA1.method1 results: {0}", objA1.Method1());
            Console.WriteLine("objA2.method1 results: {0}", objA2.Method1());

            //Method 2 cannot be accessed through object, only through the class itself.
            //Console.WriteLine(objA1.Method2()); //wrong

            Console.WriteLine("static method2 results: {0}", clsA.Method2());
            Console.WriteLine("static x2: {0}", clsA.x2);

            Console.WriteLine("________________________________________________________________\n");


        }


    }

}
