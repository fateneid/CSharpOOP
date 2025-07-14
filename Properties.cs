using System;


namespace CSharpOOP
{
    internal class Properties
    {

        class clsSetAndGet
        {
            // Private fields
            private int _ID;
            private string _Name = string.Empty;


            //ID Property Declaration
            public int ID
            {
                //for Reading field
                get
                {
                    return _ID;
                }

                //for writing field
                set
                {
                    _ID = value;
                }
            }

            //Name Property Declaration

            public string Name
            {
                //for Reading field
                get
                {
                    return _Name;
                }

                //for writing field
                set
                {
                    _Name = value;
                }

            }

        }

        class clsReadOnly
        {
            private int _ID;
            private string _Name = string.Empty;


            //ID readonly
            public int ID
            {
                //for Reading field
                get
                {
                    return _ID = 7;
                }
            }

            public string Name
            {
                //for Reading field
                get
                {
                    return _Name;
                }

                //for writing field
                set
                {
                    _Name = value;
                }

            }


        }

        class clsAutoImplemented
        {

            //ID Property 
            public int ID
            {
                get;
                set;
            }

            //Name Property Declaration
            public string Name
            {
                get;
                set;
            }

        }

        static class clsStaticPropertiesAndStaticClass
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
        }


        public static void Run()
        {

            Console.WriteLine("___________________________Properties___________________________");


            Console.WriteLine("\n**Properties Set and Get**");

            clsSetAndGet Employee1 = new clsSetAndGet();
            Employee1.ID = 7;
            Employee1.Name = "Someone";

            Console.WriteLine("Employee Id: {0}", Employee1.ID);
            Console.WriteLine("Employee Name: {0}", Employee1.Name);

            /*********************************************************/

            Console.WriteLine("\n**ReadOnly Properties**");

            clsReadOnly Employee2 = new clsReadOnly();
            //cannot modify the id value because it's readonly
            Employee2.Name = "Someone";

            Console.WriteLine("Employee Id: {0}", Employee2.ID);
            Console.WriteLine("Employee Name: {0}", Employee2.Name);

            /*********************************************************/

            Console.WriteLine("\n**Auto Implemented Properties**");

            clsAutoImplemented Employee3 = new clsAutoImplemented();
            Employee3.ID = 7;
            Employee3.Name = "SomeOne";

            Console.WriteLine("Employee Id: {0}", Employee3.ID);
            Console.WriteLine("Employee Name: {0}", Employee3.Name);

            /*********************************************************/

            Console.WriteLine("\n**Static Properties & Static Class**");

            Console.WriteLine(clsStaticPropertiesAndStaticClass.DayNumber);
            Console.WriteLine(clsStaticPropertiesAndStaticClass.DayName);

            clsStaticPropertiesAndStaticClass.ProjectPath = @"C:\MyProjects\";
            Console.WriteLine(clsStaticPropertiesAndStaticClass.ProjectPath);


            Console.WriteLine("________________________________________________________________\n");

        }


    }
}
  