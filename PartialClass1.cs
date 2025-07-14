using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    internal partial class MyClass
    {
        public int Age { get; set; }

        public void Method1()
        {
            Console.WriteLine("Method 1 in PartialClass1.cs file is called.");
        }

        partial void PrintAge();

        public void Birthday()
        {
            Age++;
            PrintAge();
        }


    }
}
