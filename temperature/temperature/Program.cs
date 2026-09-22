namespace temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a temperature in celsius");
            double celsius = double.Parse(Console.ReadLine());
            double Fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"The temperature in Fahrenheit is: {Fahrenheit}");
        }
    }
}
