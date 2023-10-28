Zadanie2();

static double DoubleInput()
{
    Console.WriteLine("Podaj wartosc: ");
    if(Double.TryParse(Console.ReadLine(), out double value)) return value;
    else
    {
        Console.WriteLine("Niepoprawne dane, system przypisze '1' zamiast nich");
        Wait();
        return 1;
    }
    
}

static void Zadanie2()
{
    bool loopContinue = true;
    while (loopContinue)
    {
        Menu();
        if(Int32.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1: Suma(); break;
                case 2: Roznica(); break;
                case 3: Iloczyn(); break;
                case 4: Iloraz(); break;
                case 5: Potegowanie(); break;
                case 6: Pierwiastek(); break;
                case 7: Trygonometria(); break;
                case 8: loopContinue = false; break;
                default: Console.WriteLine("Wybor poza zakresem");  loopContinue = true; break;
            }
        }
        else 
        {
            if (loopContinue) Console.WriteLine("Bledne dane, sprobuj jeszcze raz");
        }
        
        Wait();
        System.Console.Clear();
    } 

}

static void Wait()
{
    Console.WriteLine("Press enter to continue");
    Console.ReadKey();
}

static void Menu()
{

    Console.WriteLine("==========kalkulator========");
    Console.WriteLine("==========1. Suma========");
    Console.WriteLine("==========2. Roznica========");
    Console.WriteLine("==========3. Iloczyn========");
    Console.WriteLine("==========4. Iloraz========");
    Console.WriteLine("==========5. Potegowanie========");
    Console.WriteLine("==========6. Pierwiastek========");
    Console.WriteLine("==========7. Funkcje trygonometryczne========");
    Console.WriteLine("==========8. Wyjscie========");
    Console.WriteLine("Twoj wybor");
}


static void Suma()
{
    double a = DoubleInput(), b = DoubleInput();
    double result = a + b;
    Console.WriteLine($"Suma: {result}");
}

static void Roznica()
{
    double a = DoubleInput(), b = DoubleInput();
    double result = a - b;
    Console.WriteLine($"Suma: {result}");
}

static void Iloczyn()
{
    double a = DoubleInput(), b = DoubleInput();
    double result = a * b;
    Console.WriteLine($"Suma: {result}");
}

static void Iloraz()
{
    double a = DoubleInput(), b = DoubleInput();
    double result;
    if (b != 0)
    {
        result = a / b;
        Console.WriteLine($"Suma: {result}");
    }
    else
    {
        Console.WriteLine("Nie dziel przez '0' ");
    }
    
}

static void Potegowanie()
{
    double a = DoubleInput(), b = DoubleInput();
    double result = Math.Pow(a, b);
    Console.WriteLine($"Suma: {result}");
}

static void Pierwiastek()
{
    double a = DoubleInput();
    double result = Math.Sqrt(a);
    Console.WriteLine($"Suma: {result}");
}

static void Trygonometria()
{
    double a = DoubleInput();
    double radiany = (a * Math.PI) / 180;
    Console.WriteLine($"sin({radiany} = {Math.Sin(radiany)}");
    Console.WriteLine($"cos({radiany} = {Math.Cos(radiany)}");
    Console.WriteLine($"tg({radiany} = {Math.Tan(radiany)}");
    Console.WriteLine($"ctg({radiany} = {Math.Cosh(radiany)}");
}