namespace generic_type_test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] num = { 2, 2, 3, 5, 10, 15, 100, 1, 18, 20 };
            FindMax generator = new FindMax();
            int MaxNumber = generator.Max(num);
            Console.WriteLine($"Max number: {MaxNumber}");
        }
    }


   
}