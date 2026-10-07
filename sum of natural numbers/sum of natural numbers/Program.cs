namespace sum_of_natural_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("enter a number you want a sum of");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of natural numbers up to {0} is {1}", n, sum);

            }
        }
    }

