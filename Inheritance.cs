using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpOOP
{
    internal class Inheritance
    {

        // SECTION 1: Basic Inheritance Example
        public class clsBasicPerson
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }

            public string FullName
            {
                get
                {
                    return FirstName + ' ' + LastName;
                }
            }
        }
        public class clsBasicEmployee : clsBasicPerson
        {
            public float Salary { get; set; }
            public string DepartmentName { get; set; }

            public void IncreaseSalaryBy(float Amount)
            {
                Salary += Amount;
            }

        }

        // SECTION 2: Inheritance with Constructors
        public class clsPersonWithConstructor
        {
            public clsPersonWithConstructor(int ID, string FirstName, string LastName, string Title)
            {
                this.ID = ID;
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Title = Title;
            }

            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }

            public string FullName
            {
                get
                {
                    return FirstName + ' ' + LastName;
                }
            }

        }
        public class clsEmployeeWithConstructor : clsPersonWithConstructor
        {
            public clsEmployeeWithConstructor(int ID, string FirstName, string LastName, string Title,
                        float Salary, string DepartmentName) : base(ID, FirstName, LastName, Title)

            {
                this.Salary = Salary;
                this.DepartmentName = DepartmentName;

            }

            public float Salary { get; set; }
            public string DepartmentName { get; set; }

            public void IncreaseSalaryBy(float Amount)
            {
                Salary += Amount;
            }

        }

        // SECTION 3: Casting Example
        public class clsPersonBaseForCasting
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void Greet()
            {
                Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
            }
        }
        public class clsEmployeeDerivedForCasting : clsPersonBaseForCasting
        {
            public string Company { get; set; }
            public decimal Salary { get; set; }

            public void Work()
            {
                Console.WriteLine($"I work at {Company} and earn {Salary:C} per year.");
            }
        }

        // SECTION 4: Polymorphism Examples (Overriding and Shadowing)
        public class clsBaseClassWithOverriding
        {
            public virtual void Print()
            {
                Console.WriteLine("Hi, I'm the print method from the base class.");

            }

            //virtual - allows the method to be overridden by the derived class

        }
        public class clsDerivedClassWithOverriding : clsBaseClassWithOverriding
        {
            //Method Overriding
            public override void Print()

            {
                Console.WriteLine("Hi, I'm the print method from the derived class.");
                base.Print();

                //base keyword is used to call the Print method in the base class.

            }

            //override - indicates the method is overriding the method from the base class

        }
        public class clsBaseClassWithShadowing
        {
            public virtual void Method1()
            {
                Console.WriteLine("Method1 in Base class implementation BEFORE Overriding.");
            }

            public virtual void Method2()
            {
                Console.WriteLine("Method2 in Base class implementation BEFORE Shadowing.");
            }
        }
        public class clsDerivedClassWithShadowing : clsBaseClassWithShadowing
        {
            //Method Overriding
            public override void Method1()
            {
                Console.WriteLine("Method1 in Derived class implementation AFTER Overriding.");
            }

            //Method Shadowing
            public new void Method2()
            {
                Console.WriteLine("Method2 in Derived class implementation AFTER Shadowing.");
            }
        }

        // SECTION 5: Inheritance Types Examples
        // Multi-level inheritance
        public class clsPersonBase
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void Introduce()
            {
                Console.WriteLine($"Hi, my name is {Name} and I'm {Age} years old.");
            }
        }
        public class clsEmployeeDerived : clsPersonBase
        {
            public int EmployeeId { get; set; }
            public decimal Salary { get; set; }

            public void Work()
            {
                Console.WriteLine($"Employee with ID {EmployeeId} and salary {Salary:C} is working.");
            }
        }
        public class clsDoctorSpecialized : clsEmployeeDerived
        {
            public string Specialty { get; set; }


            public void Heal()
            {
                Console.WriteLine($"Doctor {Name} with ID {EmployeeId}, salary {Salary:C}, and specialty {Specialty} is healing a patient.");
            }
        }
        // Hierarchical inheritance
        public class clsUserDerived : clsPersonBase
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public int Permission { get; set; }

            public void Info()
            {
                Console.WriteLine($"User: {Username} and Password {Password} .");
            }
        }


        public static void Run()
        {

            Console.WriteLine("___________________________Inheritance__________________________");


            Console.WriteLine("\n**Third Principle/Concept of OOP: Inheritance**");

            clsBasicEmployee Employee1 = new clsBasicEmployee();

            //the following inherited from base class person
            Employee1.ID = 10;
            Employee1.Title = "Ms.";
            Employee1.FirstName = "Nefertari";
            Employee1.LastName = "Vivi";

            //the following are from derived class Employee
            Employee1.DepartmentName = "IT";
            Employee1.Salary = 5000;

            Console.WriteLine("Accessing Object (Employee1):\n");
            Console.WriteLine("ID : {0}", Employee1.ID);
            Console.WriteLine("Title : {0}", Employee1.Title);
            Console.WriteLine("Full Name : {0}", Employee1.FullName);
            Console.WriteLine("Department Name : {0}", Employee1.DepartmentName);
            Console.WriteLine("Salary : {0}", Employee1.Salary);

            Employee1.IncreaseSalaryBy(100);
            Console.WriteLine("Salary after increase : {0}", Employee1.Salary);

            /*********************************************************/

            Console.WriteLine("\n**Inheritance Constructor**");

            clsEmployeeWithConstructor Employee2 
                = new clsEmployeeWithConstructor(10, "Nico", "Robin", "Ms.", 5000, "IT");

            Console.WriteLine("Accessing Object (Employee2):\n");
            Console.WriteLine("ID : {0}", Employee2.ID);
            Console.WriteLine("Title : {0}", Employee2.Title);
            Console.WriteLine("Full Name : {0}", Employee2.FullName);
            Console.WriteLine("Department Name : {0}", Employee2.DepartmentName);
            Console.WriteLine("Salary : {0}", Employee2.Salary);

            Employee2.IncreaseSalaryBy(100);
            Console.WriteLine("Salary after increase : {0}", Employee2.Salary);

            /*********************************************************/

            Console.WriteLine("\n**Upcasting and Downcasting**");

            // Upcasting
            clsEmployeeDerivedForCasting employee = new clsEmployeeDerivedForCasting 
            { Name = "John", Age = 30, Company = "Acme Inc.", Salary = 50000 };
            clsPersonBaseForCasting person = employee;
            person.Greet(); // Output: "Hi, my name is John and I am 30 years old."

            // Downcasting    
            clsPersonBaseForCasting person2 = new clsEmployeeDerivedForCasting 
            { Name = "Jane", Age = 25, Company = "XYZ Corp.", Salary = 60000 }; //another example of upcasting
            clsEmployeeDerivedForCasting employee2 = (clsEmployeeDerivedForCasting)person2;
            employee2.Work(); // Output: "I work at XYZ Corp. and earn $60,000.00 per year."

            // Invalid downcasting - throws InvalidCastException at runtime
            //clsPersonBaseForCasting person3 = new clsPersonBaseForCasting { Name = "Bob", Age = 40 };
            //clsEmployeeDerivedForCasting employee3 = (clsEmployeeDerivedForCasting)person3; // Runtime exception: InvalidCastException

            /*
             * Up Casting is converting derived object to it's base object.
             * Down Casting is Converting Base object to Derived object
             * Upcasting is a safe operation because a derived class is always a specialization of the base class
             * Downcasting can be dangerous because a base class may not have all the members of a derived class. 
            */

            /*********************************************************/

            Console.WriteLine("\n**Method Overriding in C# Inheritance + Base Keyword**");

            clsDerivedClassWithOverriding ObjB = new clsDerivedClassWithOverriding();

            ObjB.Print();

            /*********************************************************/

            Console.WriteLine("\n**Method Hiding in C# (Method Shadowing)**");

            clsBaseClassWithShadowing myBaseObj = new clsBaseClassWithShadowing();
            Console.WriteLine("\nBase Object:\n");
            myBaseObj.Method1(); // Output: "Method1 in Base class implementation BEFORE Overriding."
            myBaseObj.Method2(); // Output: "Method2 in Base class implementation BEFORE Shadowing."


            clsDerivedClassWithShadowing myDerivedObj = new clsDerivedClassWithShadowing();
            Console.WriteLine("\nDerived Object:\n");
            myDerivedObj.Method1(); // Output: "Method1 in Derived class implementation AFTER Overriding."
            myDerivedObj.Method2(); // Output: "Method2 in Derived class implementation AFTER Shadowing."


            clsBaseClassWithShadowing myDerivedObjAsBase = myDerivedObj;
            Console.WriteLine("\nAfter Casting:\n");
            myDerivedObjAsBase.Method1(); // Output: "Method1 in Derived class implementation AFTER Overriding."
            myDerivedObjAsBase.Method2(); // Output: "Method2 in Base class implementation BEFORE Shadowing."


            /*********************************************************/

            //Types Of Inheritance: 
            //Note: it does not support hybrid inheritance that contains multiple inheritance.
            //Multiple Inheritance : C# doesn't support multiple inheritance

            /*********************************************************/

            Console.WriteLine("\n**Multi-Level Inheritance**");

            //In multilevel inheritance, a derived class inherits from a base
            //and then the same derived class acts as a base class for another class.

            clsDoctorSpecialized doctor = new clsDoctorSpecialized();
            doctor.Name = "Law";
            doctor.Age = 26;
            doctor.EmployeeId = 123;
            doctor.Salary = 100000.00M;
            doctor.Specialty = "Cardiology";
            doctor.Introduce();
            doctor.Work(); 
            doctor.Heal(); 

            /*********************************************************/

            Console.WriteLine("\n**Hierarchal Inheritance**");

            //In hierarchical inheritance, multiple derived classes inherit from a single base class.

            clsEmployeeDerived Employee = new clsEmployeeDerived();
            Employee.Name = "Chopper";
            Employee.Age = 17;
            Employee.EmployeeId = 124;
            Employee.Salary = 100;
            Console.WriteLine("\nEmployee:");
            Employee.Introduce(); 
            Employee.Work();

            clsUserDerived User = new clsUserDerived();
            User.Name = "Nami";
            User.Age = 20;
            User.Username = "User1";
            User.Password = "1234";
            Console.WriteLine("\nUser:");
            User.Introduce(); 
            User.Info(); 


            Console.WriteLine("________________________________________________________________\n");


        }


    }
}
