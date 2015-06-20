namespace CalculatorLib
{
    public class CalculatorClient
    {
        public void TestCalculator()
        {
            Calculator calculator = new Calculator();

            calculator.Subtract(); //Since its internal, visible anywhere in the same assembly
            calculator.Modulus();//Since its public, visible anywhere
            calculator.Multiply(); //protected internal, visible due to internal modifier 
        }
    }
}
