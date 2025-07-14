using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    internal partial class MyClass
    {

        public void Method2()
        {
            Console.WriteLine("Method 2 in PartialClass2.cs file is called.");
        }

        partial void PrintAge()
        {
            Console.WriteLine("Current age: {0}", Age);
        }


    }
}
