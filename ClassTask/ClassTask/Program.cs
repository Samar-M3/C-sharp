namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your marks for Physics");
            float physicsMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your marks for Chemistry");
            float chemistryMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your marks for Mathematics");
            float mathematicsMarks = float.Parse(Console.ReadLine());
            float total = physicsMarks + chemistryMarks + mathematicsMarks;
            float percentage = (total / 300) * 100;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Percentage: {percentage}%");
            if (percentage <= 100 && percentage >= 90)
            {
                Console.WriteLine("Grade: A+");

            }
            else if (percentage<= 89 && percentage>= 80)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage<=79 && percentage>= 70)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage<= 69 && percentage>= 60)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percentage<= 59 && percentage >= 50)
            {
                Console.WriteLine("Grade: D");

            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }
    }
}
