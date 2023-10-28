Zadanie6();

static void Zadanie6()
{
    Console.WriteLine("Nieskonczona petla podawania liczb calkowitych");
    Console.WriteLine("Przerwiesz ja gdy podasz liczbe mniejsza niz 0");
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();
    System.Console.Clear();
    while (true)
    {
        Console.WriteLine("Podaj liczbe calkowita: ");
        if (!Int32.TryParse(Console.ReadLine(), out int input)) Console.WriteLine("Bledne dane");
        else
        {
             if (input < 0) break;
        }
    }
}