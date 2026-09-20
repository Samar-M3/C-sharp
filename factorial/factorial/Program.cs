namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("enter a non negative number to calculate its factorial");
            int number = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i=1; i <= number; i++)
            {
                fact = fact * i;
            }
                Console.WriteLine($"Factorial is {fact}");
        }
    }
}

