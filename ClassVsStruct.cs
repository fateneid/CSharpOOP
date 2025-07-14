using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    internal class ClassVsStruct
    {

        //A class is a reference type whereas a struct is a value type. 

        // class
        class clsEmployee
        {
            public string name;

        }

        // struct
        struct stEmployee
        {
            public string name;

        }


        public static void Run()
        {


            Console.WriteLine("________________________Class vs Struct_________________________");

            Console.WriteLine("\n**Class**");

            clsEmployee cEmp1 = new clsEmployee();
            cEmp1.name = "Nami";

            // assign cEmp1 to cEmp2
            clsEmployee cEmp2 = cEmp1;
            cEmp2.name = "Robin";
            Console.WriteLine("Employee1 name: " + cEmp1.name);

            /*
             
             * In the above example, we have assigned the value of emp1 to emp2.
               The emp2 object refers to the same object as emp1. 
               So, an update in emp2 updates the value of emp1 automatically.

               This is why a class is a reference type.

             */

            /*********************************************************/

            Console.WriteLine("\n**Struct**");

            stEmployee sEmp1 = new stEmployee();
            sEmp1.name = "Nami";

            // assign sEmp1 to sEmp2
            stEmployee sEmp2 = sEmp1;
            sEmp2.name = "Robin";
            Console.WriteLine("Employee1 name: " + sEmp1.name);

            /*
             
             * Contrary to classes, when we assign one struct variable to another,
               the value of the struct gets copied to the assigned variable.
               So updating one struct variable doesn't affect the other.

             * When we assign the value of emp1 to emp2, a new value emp2 is created.
               Here, the value of emp1 is copied to emp2. So, change in emp2 does not affect emp1.

               This is why struct is a value type.

             */


            Console.WriteLine("________________________________________________________________\n");


        }



    }
}
