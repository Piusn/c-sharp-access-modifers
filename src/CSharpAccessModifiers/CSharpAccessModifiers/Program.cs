using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;

namespace CSharpAccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator=new Calculator();

            calculator.Modulus();  //Its public, and so can be visible from anywhere
        }
    }
}
