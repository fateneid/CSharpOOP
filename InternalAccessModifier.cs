using System;


namespace CSharpOOP
{
    internal class InternalAccessModifier
    {

        //If we use internal within a single assembly, it works just like the public access modifier.

        /*
         
         * When we declare a type or type member as internal, 
           it can be accessed only within the same assembly (Same DLL).

         * An assembly is a collection of types (classes, interfaces, etc) and resources (data). 
           They are built to work together and form a logical unit of functionality.

         * That's why when we run an assembly all classes and interfaces inside the assembly run together.

         * Note: Internal in C# is equivalent to friend in C++.

         */

        class Student
        {
            internal string name = "Nami";
        }

        public static void Run()
        {


            Console.WriteLine("____________________Internal Access Modifier____________________");


            Student theStudent = new Student();

            // accessing name field and printing it
            Console.WriteLine("Name: " + theStudent.name);


            Console.WriteLine("________________________________________________________________\n");


        }


    }
}
