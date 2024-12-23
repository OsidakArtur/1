using System;

struct Triangle
{
    public double a, b, c;
    public double angle;

    public Triangle(double a, double b, double c, double angle = 90)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.angle = angle;
    }

    public double Perimeter()
    {
        return a + b + c;
    }

    public double Area()
    {
        return 0.5 * a * b * Math.Sin(Math.PI * angle / 180);
    }

    public double Height()
    {
        return 2 * Area() / a;
    }

    public string TriangleType()
    {
        if (a == b && b == c)
            return "Рівносторонній";
        if (a == b || b == c || a == c)
            return "Рівнобедрений";
        if (Math.Abs(Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) < 1e-6 ||
            Math.Abs(Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) < 1e-6 ||
            Math.Abs(Math.Pow(c, 2) + Math.Pow(a, 2) - Math.Pow(b, 2)) < 1e-6)
            return "Прямокутний";
        return "Произвольний";  // Fixed typo here
    }

    public void SetSides(double a, double b, double c, double angle = 90)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.angle = angle;
    }

    public void Print()
    {
        Console.WriteLine($"Сторона a: {a}, Сторона b: {b}, Сторона c: {c}, Кут: {angle}°");
        Console.WriteLine($"Периметр: {Perimeter()}");
        Console.WriteLine($"Площа: {Area()}");
        Console.WriteLine($"Висота на сторону a: {Height()}");
        Console.WriteLine($"Тип трикутника: {TriangleType()}");
    }
}

class Program
{
    static void Main()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        triangle.Print();

        triangle.SetSides(6, 6, 6);
        Console.WriteLine("\nПісля зміни значень:");
        triangle.Print();
    }
}
