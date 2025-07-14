using System;


namespace CSharpOOP
{
    internal class NestedClass
    {

        public class OuterClass
        {
            private int outerVariable;

            public OuterClass(int outerVariable)
            {
                this.outerVariable = outerVariable;
            }

            public void OuterMethod()
            {
                Console.WriteLine("Outer method called.");
            }
            
            public class InnerClass
            {
                private int innerVariable;

                public InnerClass(int innerVariable)
                {
                    this.innerVariable = innerVariable;
                }

                public void InnerMethod()
                {
                    Console.WriteLine("Inner method called with innerVariable = " + innerVariable);
                }

                public void AccessOuterVariable(OuterClass outer)
                {
                    Console.WriteLine("Accessing outerVariable from inner class: " + outer.outerVariable);
                }
            }
        }


        public static void Run()
        {

            Console.WriteLine("__________________________Nested Class__________________________");

            // create an instance of OuterClass
            OuterClass outer1 = new OuterClass(42);

            // create an instance of InnerClass
            OuterClass.InnerClass inner1 = new OuterClass.InnerClass(100);

            // call methods on the instances
            outer1.OuterMethod();
            inner1.InnerMethod();
            inner1.AccessOuterVariable(outer1);


            Console.WriteLine("________________________________________________________________\n");

        }


    }
}
