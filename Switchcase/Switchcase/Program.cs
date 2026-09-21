namespace Switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("choose 1 for multiply 2 for add 3 for subtract 4 for divide");
            string Confirmation= Console.ReadLine();
            switch (Confirmation)
            {
                case "1":
                    Console.WriteLine("you choose multiply");
                    int multiply = num1 * num2;
                    Console.WriteLine("Result: " + multiply);
                    break;
                case "2":
                    Console.WriteLine("you choose add");
                    int add = num1 + num2;
                    Console.WriteLine("Result: " + add);
                    break;
                case "3":
                    Console.WriteLine("you choose subtract");
                    int subtract = num1 - num2;
                    Console.WriteLine("Result: " + subtract);
                    break;
                case "4":
                    Console.WriteLine("you choose divide");
                    int divide = num1 / num2;
                    Console.WriteLine("Result: " + divide);
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
    }
}
