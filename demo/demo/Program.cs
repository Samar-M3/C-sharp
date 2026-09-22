namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
        Sphere sphere1 = new Sphere(5.0);
            double areaOfShpere = sphere1.Area();
            Console.WriteLine($"Area of Sphere: {areaOfShpere}");

            Circle circle1 = new Circle(3.0);
            double areaofcircle=circle1.Area();
            double abstractAreaOfCircle = circle1.AbstractArea();
            Console.WriteLine($"Area of Circle: {areaofcircle}");
            Console.WriteLine($"Abstract Area of Circle: {abstractAreaOfCircle}");


            //Dimension dimension1=new Dimension(4.0, 5.0);

        }
    }
}
