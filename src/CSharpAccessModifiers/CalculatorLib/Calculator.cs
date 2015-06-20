namespace CalculatorLib
{
    public class Calculator
    {
        private void Add()
        {
        }

        internal void Subtract()
        {
            Add();
            Divide();
            Multiply();
            Modulus();
            Subtract();
        }

        protected void Divide()
        {
        }

        protected internal void Multiply()
        {
        }

        public void Modulus()
        {
        }
    }
}
