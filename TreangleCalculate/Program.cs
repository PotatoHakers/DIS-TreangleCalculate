using TriangleLogic;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину стороны A: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Введите длину стороны B: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.Write("Введите длину стороны C: ");
        double sideC = double.Parse(Console.ReadLine());

        Triangle triangle = new Triangle(sideA, sideB, sideC);
        double area = triangle.CalculateArea();

        if (sideA > 0 && sideB > 0 && sideC > 0)
        {
            Console.WriteLine($"Площадь треугольника: {area}");
            //triangle.Finish();
            return;
        }
        else Console.WriteLine("Все стороны треугольника должны быть положительными");

        triangle.Finish();
        return;
    }
}