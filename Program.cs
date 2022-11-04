namespace GenericSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var calcEven = new CalcUser<CalcEven>();
            var calcOdd = new CalcUser<CalcOdd>();

            int value = 100;
            int count = 5;

            Console.WriteLine($"calcEven.MultyInc({value}, {count}) = {calcEven.MultyInc(value, count)}");
            Console.WriteLine($"calcEven.MultyDec({value}, {count}) = {calcEven.MultyDec(value, count)}");

            Console.WriteLine($"calcOdd.MultyInc({value}, {count}) = {calcOdd.MultyInc(value, count)}");
            Console.WriteLine($"calcOdd.MultyDec({value}, {count}) = {calcOdd.MultyDec(value, count)}");

            Console.ReadKey();
        }
    }
}