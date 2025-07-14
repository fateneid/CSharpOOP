using System;


namespace CSharpOOP
{
    internal class AbstractClass
    {


        /*
         *Abstract class: is a restricted class that cannot be used to create objects
          (to access it, it must be inherited from another class).
         *Abstract method: can only be used in an abstract class, 
          and it does not have a body.The body is provided by the derived class (inherited from).
         *An abstract class can have both abstract and regular methods.
        */

        public abstract class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public abstract void Introduce();

            public void SayGoodbye()
            {
                Console.WriteLine("Goodbye!");
            }
        }

        public class Employee : Person
        {
            public int EmployeeId { get; set; }

            public override void Introduce()
            {
                Console.WriteLine($"Hi, my name is {FirstName} {LastName}, and my employee ID is {EmployeeId}.");
            }
        }


        public static void Run()
        {

            Console.WriteLine("____________________Abstract Class & Methods____________________");

            //You cannot create an object of an abstract class, you can only inherit it.
            //Person Person1 = new Person();

            Employee employee = new Employee();
            employee.FirstName = "Nefertari";
            employee.LastName = "Vivi";
            employee.EmployeeId = 127;
            employee.Introduce();
            employee.SayGoodbye();


            Console.WriteLine("________________________________________________________________\n");

        }


    }

}
