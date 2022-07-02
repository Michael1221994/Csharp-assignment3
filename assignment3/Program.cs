// See https://aka.ms/new-console-template for more information
interface Ishape
{
    double calculatearea();
    double calculateperimeter();
}
public class rectangle : Ishape
{
    public double width, height;
    public Double calculatearea()
    {
        double area = 0;
        area=width*height;
        return area;
    }
    public Double calculateperimeter()
    {
        double perimeter = 0;
        perimeter = (2 * width) + (2 * height);
        return perimeter;
    }
}
public class circle : Ishape
{
    public double r ;
    static  double pi=3.14;
    public double calculatearea()
    {
        double area = 0;
        area = pi * r * r;
        return area;
    }
    public double calculateperimeter()
    {
        return 2*pi * r;
    }

}
class mainclass
{
    static void Main(String[] args)
    {
        circle circle= new circle();
        circle.r = 23;
        Console.WriteLine(circle.calculatearea());
        Console.WriteLine(circle.calculateperimeter());
        rectangle rectangle= new rectangle();
        rectangle.height = 22;
        rectangle.width = 45;
        Console.WriteLine(rectangle.calculatearea());
        Console.WriteLine(rectangle.calculateperimeter());
    }
}
