namespace greateset_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter the first number:");
            float num1=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            float num2=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            float num3=float.Parse(Console.ReadLine());
            if(num1> num2 && num1 > num3)
            {
                Console.WriteLine($"The greatest number is: {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"The greatest number is: {num2}");
            }
            else
            {
                Console.WriteLine($"The greatest number is: {num3}");
            }

        }
    }
}
