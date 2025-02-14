//using System;

//class Tr
//{
//    public void Test()
//    {
//        Console.WriteLine("zzz")
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {

//    }

//}

using System;

public class Rectangle
{
    private double width
    private double height

    public Rectangle()
    {
        width = 1.0;
        height = 1.0;
        Console.WriteLine("Конструктор по умолчанию.");
    }

    public Rectangle(double w, double h)
    {
        width = w;
        height = h;
        Console.WriteLine("Конструктор с параметрами.");
    }

    public Rectangle(Rectangle copy)
    {
        width = copy.width;
        height = copу.height;
        Console.WriteLine("Конструктор копирования.");
    }

    static Rectangle()
    {
        Console.WriteLine("Статический конструктор.");
    }

    ~Rectangle()
    {
        Console.WriteLine("Деструктор.");
    }

    public double CalcS()
    {
        return width + height;
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public static void Main(string[] args)
    {
        Rectangle r1 = new Rectangle();
        Console.WriteLine($"Площадь r1: {r1.CalcS()}");

        Rectangle r2 = new Rectangle(5,3);
        Console.WriteLine($"Площадь r1: {r2.CalcS()}");

        Rectangle r3 = new Rectangle(r2);
        Console.WriteLine($"Площадь r1: {r3.CalcS()}");

        r2.Width = 7;
        Console.WriteLine($"Новая площадь r2: {r2.CalcS()}")


        Console.ReadKey();
    }
}
