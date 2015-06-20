namespace CalculatorLib
{
    public class CalculatorDerived : Calculator
    {
        public void Inherited()
        {
            Divide(); //Protected, only visible to derived classes
            Multiply(); //protected internal, visible due to protected modifier

            Calculator calculator = new Calculator();

            calculator.Modulus();
            calculator.Multiply();
            calculator.Subtract();
        }
    }
}
