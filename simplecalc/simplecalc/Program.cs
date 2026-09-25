namespace simplecalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Console.WriteLine("choose 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division");
            int choice = Convert.ToInt16(Console.ReadLine());
            float num1, num2;
            Console.WriteLine("enter two numbers"); 
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());
           
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"the addition of {num1} and {num2} is {num1 + num2}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"the subtraction of {num1} and {num2} is {num1 - num2}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"the multiplication of {num1} and {num2} is {num1 * num2}");
                            break;
                        }
                    case 4:
                        {
                            if (num2 == 0)
                            {
                                Console.WriteLine("division by zero is not allowed");
                                break;
                            }
                            Console.WriteLine($"the division of {num1} and {num2} is {num1 / num2}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("invalid choice");
                            break;
                        }

                }
            }

        }
        }
}
