namespace GenericSample
{
    public class CalcEven : ICalc
    {
        public int Increase(int value)
        {
            return value + 2;
        }
        public int Decrease(int value)
        {
            return value-2;
        }

    }
}
