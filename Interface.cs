using System;


namespace CSharpOOP
{
    internal class Interface
    {

        /*
         * An interface is a completely "abstract class",
           which can only contain abstract methods and properties(with empty bodies).
         * We must provide the implementation of all the methods of interface inside the class that implements it.
         * We cannot create objects of an interface. To use an interface, other classes must implement it.
           Same as in C# Inheritance, we use : symbol to implement an interface. 

         * By convention, interface starts with I so that we can identify it just by seeing its name.
         * We cannot use access modifiers inside an interface.
         * All members of an interface are public by default.
         * An interface doesn't allow fields.
         * Like abstract classes, interfaces cannot be used to create objects.
         * Interface methods do not have a body - the body is provided by the "implement" class.
         * Interfaces can contain properties and methods, but not fields/variables
         * Interface members are by default abstract and public
         * An interface cannot contain a constructor (as it cannot be used to create objects)
         */

        public interface IPerson
        {
            string FirstName { get; set; }
            string LastName { get; set; }

            void Introduce();

            void Print();

            string To_String();
        }

        public interface ICommunicate
        {

            void CallPhone();

            void SendEmail(string Title, string Body);

            void SendSMS(string Title, string Body);

            void SendFax(string Title, string Body);

        }

        /*
         * Unlike inheritance, a class can implement multiple interfaces.
         * To implement multiple interfaces, separate them with a comma.
         */

        public abstract class Person : IPerson, ICommunicate

        {

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public abstract void Introduce();


            public void SayGoodbye()
            {
                Console.WriteLine("Goodbye!");
            }


            public void Print()
            {
                Console.WriteLine("Hi I'm the print method");
            }

            public string To_String()
            {
                return "Hi this is the complete string....";
            }

            public void CallPhone()
            {
                Console.WriteLine("Calling Phone... :-)");
            }

            public void SendEmail(string Title, string Body)
            {
                Console.WriteLine("Email Sent :-)");
            }

            public void SendSMS(string Title, string Body)
            {
                Console.WriteLine("SMS Sent :-)");
            }

            public void SendFax(string Title, string Body)
            {
                Console.WriteLine("Fax Sent :-)");
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

            Console.WriteLine("___________________________Interface____________________________");

            //You cannot create an object of an Interface, you can only Implement it.
            //IPerson Person1 = new IPerson();

            Employee employee = new Employee();
            employee.FirstName = "Nefertari";
            employee.LastName = "Vivi";
            employee.EmployeeId = 127;
            employee.Introduce(); 
            employee.SayGoodbye(); 
            employee.Print();
            employee.CallPhone();
            employee.SendEmail("hi", "Message...");
            employee.SendSMS("hi", "Message...");
            employee.SendFax("hi", "Message...");


            Console.WriteLine("________________________________________________________________\n");


        }



    }
}
