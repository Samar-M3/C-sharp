namespace Divisible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number to check if it is divisible by 2, 3, or 5:");
            //int num=int.Parse(Console.ReadLine());
            //if (num % 5 == 0 )
            //{
            //    Console.WriteLine($"the number {num} is divisible by 5 ");
            //}
            //else if(num % 3 == 0){
            //    Console.WriteLine($"the number {num} is divisible by 3 ");
            //}
            //else
            //{
            //    Console.WriteLine("the number is not divisible");
            //}

            Console.WriteLine("Enter something:");
            string input = Console.ReadLine();

            while (input != null)
            {
                Console.WriteLine($"You entered: {input}");
                Console.WriteLine("enter Y to continue and N to exit");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "Y")
                {
                    Console.WriteLine("Enter something:");
                    input = Console.ReadLine();
                }
                else if (choice == "N")
                {
                    break;
                }

            }
        }
    }
}
