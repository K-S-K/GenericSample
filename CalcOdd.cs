namespace GenericSample
{
    public class CalcOdd : ICalc
    {
        public int Increase(int value)
        {
            return value + 3;
        }

        public int Decrease(int value)
        {
            return value - 3;
        }
    }
}
