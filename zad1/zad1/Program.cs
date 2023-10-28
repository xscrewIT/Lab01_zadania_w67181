using System.ComponentModel.Design;

Zadanie1();

static double DoubleInput()
{
    Console.WriteLine("Podaj wartosc: ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

static void Zadanie1()
{
    double a = DoubleInput();
    double b = DoubleInput();
    double c = DoubleInput();

    double x1, x2, delta = Math.Pow(b, 2) - (4 * a * c);

    if (a == 0)
    {
        Console.WriteLine("To nie jest rownanie kwadratowe");
    }
    else if (delta < 0)
    {
        Console.WriteLine("Brak rozwiazania w zbiorze liczb rzeczywistych");
    }
    else if (delta == 0)
    {
        x1 = -b / (2 * a);
        Console.WriteLine($"x1 {x1}");
    }
    else
    {
        x1 = -b - Math.Sqrt(delta) / (2 * a);
        x2 = -b + Math.Sqrt(delta) / (2 * a);
        Console.WriteLine($"x1 {x1}, x2 {x2}");
    }

}