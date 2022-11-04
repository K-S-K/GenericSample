namespace GenericSample
{
    public class CalcUser<T> where T : ICalc, new()
    {
        private readonly T _calc;

        public int MultyInc(int value, int count)
        {
            while (count-- > 0) value = _calc.Increase(value);

            return value;
        }

        public int MultyDec(int value, int count)
        {
            while (count-- > 0) value = _calc.Decrease(value);

            return value;
        }

        public CalcUser()
        {
            _calc = new T ();
        }
    }
}
