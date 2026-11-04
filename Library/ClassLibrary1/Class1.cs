namespace ClassLibrary1
{
    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}");
        }
    }
}
