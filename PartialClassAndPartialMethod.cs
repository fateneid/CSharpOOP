using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    internal class PartialClassAndPartialMethod
    {


        /* Partial Class:
         * If any part is declared abstract, then the whole type is considered abstract.
         * If any part is declared sealed, then the whole type is considered sealed.
         * If any part declares a base type, then the whole type inherits that class.
         * Any class member declared in a partial definition are available to all other parts.
         * All parts of a partial class should be in the same namespace.
         */


        /* Partial Method:
         * partial keyword.
         * return type void.
         * implicitly private.
         * and cannot be virtual.
         
         * partial methods can only be defined in a partial class or partial struct, 
           and their return type must be void. 
           Also, partial methods cannot be accessed outside of the partial class or struct where they are defined, 
           so they can't be used to implement a public API.
         */


        public static void Run()
        {

            Console.WriteLine("________________Partial Class and Partial Method________________");


            Console.WriteLine("\n**Partial Class**");

            //the code of MyClass is seperated in 2 files PartialClass1.cs and PartialClass2.cs
            MyClass obj = new MyClass();
            obj.Method1();
            obj.Method2();

            /*********************************************************/

            Console.WriteLine("\n**Partial Method**");

            //the code of MyClass is seperated in 2 files PartialClass1.cs and PartialClass2.cs
            MyClass person1 = new MyClass();
            person1.Age = 25;
            person1.Birthday(); // Output: "Current age: 26"


            Console.WriteLine("________________________________________________________________\n");

        }


    }
}
