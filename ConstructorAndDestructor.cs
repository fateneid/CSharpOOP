using System;


namespace CSharpOOP
{
    internal class ConstructorAndDestructor
    {

        class clsParameterlessConstructor
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public clsParameterlessConstructor()
            {
                Id = -1;
                Name = "Empty";
                Age = 0;
            }

        }

        class clsParameterizedConstructor
        {

            public string carBrand;
            public int carPrice;

            public clsParameterizedConstructor(string theBrand, int thePrice)
            {
                carBrand = theBrand;
                carPrice = thePrice;
            }

        }

        class clsDefaultConstructor
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            /* 
             C# automatically creates a default constructor. 
             The default constructor initializes any uninitialized variable with the default value. 
             Hence, we get 0 as the value of the numbers and empty string for strings.
             In the default constructor, all the numeric fields are initialized to 0, 
             whereas string and object are initialized as null. 
            */

        }

        //cannot create objects of both clsPrivateConstructor and clsStaticClass classes.

        class clsPrivateConstructor
        {
            public static int DayNumber
            {
                get
                {
                    return DateTime.Today.Day;
                }
            }

            public static string DayName
            {
                get
                {
                    return DateTime.Today.DayOfWeek.ToString();
                }
            }

            public static string ProjectPath
            {
                get;
                set;
            }

            //this is a private constructor to prevent creating object from this class
            private clsPrivateConstructor()
            {

            }

            /*
             If a constructor is private, we cannot create objects of the class. 
             Hence, all fields and methods of the class should be declared static, 
             so that they can be accessed using the class name.
            */

        }

        static class clsStaticClass
        {
            public static int DayNumber
            {
                get
                {
                    return DateTime.Today.Day;
                }
            }

            public static string DayName
            {
                get
                {
                    return DateTime.Today.DayOfWeek.ToString();
                }
            }

            public static string ProjectPath
            {
                get;
                set;
            }

            /*
             A static class is basically the same as a non-static class, 
             but there is one difference: a static class cannot be instantiated.
             In other words, cannot use the new operator to create a variable of the class type.
            */

        }

        class clsMultipleConstructors
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public clsMultipleConstructors()
            {
                this.Id = -1;
                this.Name = "Empty";
                this.Age = 0;
            }

            public clsMultipleConstructors(int Id, string Name, short Age)
            {
                this.Id = Id;
                this.Name = Name;
                this.Age = Age;
            }

            //In C#, we can have multiple constructors in the class using overloading

        }

        static class clsStaticConstructor
        {
            public static int DayNumber
            {
                get
                {
                    return DateTime.Today.Day;
                }
            }

            public static string DayName
            {
                get
                {
                    return DateTime.Today.DayOfWeek.ToString();
                }
            }

            public static string ProjectPath
            {
                get;
                set;
            }
            //this is a static constructor will be called once during the program
            static clsStaticConstructor()
            {
                ProjectPath = @"C:\MyProjects\";
            }

            /*      
              - The static constructor is called only once during the execution of the program. 
                That's why when we call the constructor again, only the regular constructor is called.
              - We can have only one static constructor in a class. It cannot have any parameters or access modifiers.
            */

        }

        class clsDestructor
        {

            // Constructor
            public clsDestructor()
            {
                Console.WriteLine("Constructor called.");
            }

            // Destructor
            ~clsDestructor()
            {
                Console.WriteLine("Destructor called.");
            }

            /*
            Features of C# Destructors:
            - can only have one destructor in a class.
            - A destructor cannot have access modifiers, parameters, or return types.
            - A destructor is called implicitly by the Garbage collector of the.NET Framework.
            - cannot overload or inherit destructors.
            - cannot define destructors in structs. 
            */

        }


        public static void Run()
        {

            Console.WriteLine("___________________Constructor and Destructor___________________");


            Console.WriteLine("\n**Parameterless Constructor**");

            clsParameterlessConstructor Person1 = new clsParameterlessConstructor();

            Console.WriteLine("ID: {0}", Person1.Id);
            Console.WriteLine("Name: {0}", Person1.Name);
            Console.WriteLine("Age: {0}", Person1.Age);

            /*********************************************************/

            Console.WriteLine("\n**Parameterized Constructor**");

            clsParameterizedConstructor car1 = new clsParameterizedConstructor("Bugatti", 50000);

            Console.WriteLine("Brand: " + car1.carBrand);
            Console.WriteLine("Price: " + car1.carPrice);

            /*********************************************************/

            Console.WriteLine("\n**Default Constructor**");

            clsDefaultConstructor Person2 = new clsDefaultConstructor();
            Console.WriteLine("ID: {0}", Person2.Id);
            Console.WriteLine("Name: {0}", Person2.Name);
            Console.WriteLine("Age: {0}", Person2.Age);

            /*********************************************************/

            Console.WriteLine("\n**Private Constructor**");

            //cannot create an object here because class has private constructor
            //clsPrivateConstructor Obj1 = new clsPrivateConstructor();

            Console.WriteLine(clsPrivateConstructor.DayNumber);
            Console.WriteLine(clsPrivateConstructor.DayName);

            clsPrivateConstructor.ProjectPath = @"C:\MyProjects\";
            Console.WriteLine(clsPrivateConstructor.ProjectPath);

            /*********************************************************/

            Console.WriteLine("\n**Static Class**");

            //cannot create an object here because class is static
            //clsStaticClass Obj2 = new clsStaticClass();

            Console.WriteLine(clsStaticClass.DayNumber);
            Console.WriteLine(clsStaticClass.DayName);

            clsStaticClass.ProjectPath = @"C:\MyProjects\";
            Console.WriteLine(clsStaticClass.ProjectPath);

            /*********************************************************/

            Console.WriteLine("\n**Multiple Constructors using overloading**");

            Console.WriteLine("\nCalling Parameterless Constructor");
            clsMultipleConstructors Person3 = new clsMultipleConstructors();
            Console.WriteLine("ID: {0}", Person1.Id);
            Console.WriteLine("Name: {0}", Person1.Name);
            Console.WriteLine("Age: {0}", Person1.Age);

            Console.WriteLine("\nCalling Parametarized Constructor");
            clsMultipleConstructors Person4 = new clsMultipleConstructors(7, "Someone", 14);
            Console.WriteLine("ID: {0}", Person2.Id);
            Console.WriteLine("Name: {0}", Person2.Name);
            Console.WriteLine("Age: {0}", Person2.Age);

            /*********************************************************/

            Console.WriteLine("\n**Static Constructor**");

            //cannot create an object here because class is static
            //clsStaticConstructor Obj3 = new clsStaticConstructor();

            Console.WriteLine(clsStaticConstructor.DayNumber);
            Console.WriteLine(clsStaticConstructor.DayName);
            Console.WriteLine(clsStaticConstructor.ProjectPath);

            /*********************************************************/

            Console.WriteLine("\n**Destructor**");

            clsDestructor Obj4 = new clsDestructor();


            Console.WriteLine("________________________________________________________________\n");


        }



    }

}
