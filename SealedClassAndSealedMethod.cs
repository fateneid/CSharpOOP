using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    internal class SealedClassAndSealedMethod
    {
        
        /*
         * In C#, when we don't want a class to be inherited by another class,
           we can declare the class as a sealed class.
         */

        public sealed class clsA
        {
            public void Sayhello()
            {
                Console.WriteLine("Hello!");
            }
        }

        // trying to inherit sealed class
        // Error Code

        //class clsB : clsA
        //{


        //}


        public class Person
        {
            public virtual void Greet()
            {
                Console.WriteLine("The person says hello.");
            }
        }

        /*
         * During method overriding, if we don't want an overridden method to be further overridden by another class,
           we can declare it as a sealed method.
         * We use a sealed keyword with an overridden method to create a sealed method.
         */

        public class Employee : Person
        {
            public sealed override void Greet()
            {
                Console.WriteLine("The employee greets you.");
            }
        }

        public class Manager : Employee
        {
            //This will produce a compile-time error because the Greet method in Employee is
            //sealed and cannot be overridden.
            //public override void Greet()
            //{
            //    Console.WriteLine("The manager greets you warmly.");
            //}
        }


        public static void Run()
        {

            Console.WriteLine("_________________Sealed Class and Sealed Method_________________");


            Console.WriteLine("\n**Sealed Class**");


            clsA A = new clsA();

            A.Sayhello();

            //clsB B1 = new clsB();


            /*********************************************************/

            Console.WriteLine("\n**Sealed Method**");


            Person person = new Person();
            person.Greet(); // outputs "The person says hello."

            Employee employee = new Employee();
            employee.Greet(); // outputs "The employee greets you."

            Manager manager = new Manager();
            manager.Greet(); // outputs "The employee greets you."


            Console.WriteLine("________________________________________________________________\n");

        }


    }
}
