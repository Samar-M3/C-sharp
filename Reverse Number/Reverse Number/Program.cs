namespace Reverse_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number= int.Parse(Console.ReadLine());
            int reverse= 0;
            while(number!= 0)
            {
                int Lastdigit= number % 10;
                reverse= reverse * 10 + Lastdigit;
                number /= 10;
            }

            
            Console.WriteLine("The reverse of the number is: " + reverse);
        }
    }
}
