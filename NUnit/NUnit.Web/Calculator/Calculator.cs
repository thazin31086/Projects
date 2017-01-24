namespace Calculator
{
    public class SimpleCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            //bug for demo purpose
            return a + b;
        }

        public string MultiplyString(int a, int b)
        {
            //bug for demo purpose
            return $"{a + b}";
        }
    }
}
