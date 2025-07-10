using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    internal class Calculator
    {

        class clsCalculator
        {

            private float _Result = 0;
            private float _LastNumber = 0;
            private string _LastOperation = "";

            public void Add(float Number)
            {

                _LastNumber = Number;
                _LastOperation = "Adding";

                _Result += Number;

            }

            public void Subtract(float Number)
            {

                _LastNumber = Number;
                _LastOperation = "Subtracting";

                _Result -= Number;

            }

            public void Multiply(float Number)
            {

                _LastNumber = Number;
                _LastOperation = "Multiplying";

                _Result *= Number;
            }

            public void Divide(float Number)
            {

                _LastNumber = Number;
                _LastOperation = "Dividing";

                if (Number == 0)
                {
                    Number = 1;
                }

                _Result /= Number;

            }

            public void Clear()
            {

                _Result = 0;
                _LastNumber = 0;
                _LastOperation = "Clear";

            }

            public void PrintResult()
            {

                Console.WriteLine( "Result After {0} {1} is: {2}", _LastOperation, _LastNumber, _Result);

            }

            public float GetFinalResult()
            {
                return _Result;
            }

        }


        public static void Run()
        {

            Console.WriteLine("___________________________Calculator___________________________");


            clsCalculator Calculator1 = new clsCalculator();

            Calculator1.Clear();

            Calculator1.Add(10);
            Calculator1.PrintResult();

            Calculator1.Add(100);
            Calculator1.PrintResult();

            Calculator1.Subtract(20);
            Calculator1.PrintResult();

            Calculator1.Divide(0);
            Calculator1.PrintResult();

            Calculator1.Divide(2);
            Calculator1.PrintResult();

            Calculator1.Multiply(3);
            Calculator1.PrintResult();

            Calculator1.Clear();
            Calculator1.PrintResult();


            Console.WriteLine("________________________________________________________________\n");


        }


    }
}
