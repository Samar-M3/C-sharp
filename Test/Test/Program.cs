using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Write("Hellooooooo"); // separate line
        Console.WriteLine("Hellooooooo"); // same line


        int firstNumber = 10;
        int secondNumber = 20;

        int result = firstNumber + secondNumber;
        Console.WriteLine($"the sum of {firstNumber} and {secondNumber} is {result}");

        float Fnum = 4.3f;
        float Fnum1 = 5.6f;
        float Fresult = Fnum + Fnum1;
        Console.WriteLine($"the sum of the float numner {Fnum} and {Fnum1} is {Fresult}");

        decimal price1 = 10m;
        decimal price2 = 12m;
        decimal result1 = price1 - price2;
            Console.WriteLine($"{price2} and {price1} is subtracted and the result is {result1}");

        string firstName = "Samar";
        string lastName = "Maharjan";
        string fullname= firstName+ " " + lastName;
        Console.WriteLine($"My name is {firstName} {lastName} {fullname}");

        //char firstLetter = 'S';
        //char lastLetter = 'M';

        //char name = firstLetter  lastLetter;
        //Console.WriteLine($"{name}");
        //Console.WriteLine($"My first letter is {firstLetter} and my last letter is {lastLetter}");

        Console.WriteLine("Enter your name:");
        string fullname1 = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your phone number:");
        string phone = Console.ReadLine();
        Console.WriteLine("Enter your address:");
        string address = Console.ReadLine();
        Console.WriteLine("Enter your email:");
        string email = Console.ReadLine();
        Console.WriteLine($"Welcome {fullname1}");
        Console.WriteLine($"Your age is {age}");
        Console.WriteLine($"Your phone number is {phone}");
        Console.WriteLine($"Your address is {address}");
        Console.WriteLine($"Your email is {email}");

        Console.ReadKey();
    }
}


/*  
 data types
numeric types:int,float,double,decimal
string types: string, char
boolean types:bool 
collection types:array,list,dictionary
generic types:List<T>,Dictionary<TKey,TValue>
 */
