Zadanie7();

static void Zadanie7()
{
    while (true)
    {
        Console.WriteLine("Podaj ilosc wprowadzanych liczb: ");
        if (!Int32.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Element nie jest liczba calkowita");
            Wait();
        }
        else
        {
            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Wpisz wartosc elementu ID = {i}:");
                if (!Int32.TryParse(Console.ReadLine(), out tab[i])) Console.WriteLine("Niepoprawne dane wejsciowe, system zamieni je na '0' ");
            }
            BubbleSort(tab);
            Wait();
        }
    }
    
}

static void BubbleSort(int[] tab)
{
    Console.WriteLine("Tablica przed sortowaniem: ");
    for (int i = 0; i < tab.Length; i++)
    {
        Console.WriteLine(tab[i]);
    }

    int tmp = 0;
    Console.WriteLine("Tablica po sortowaniu: ");
    for (int i = 0; i < tab.Length; i++)
    {
        for (int j = 0; j < tab.Length - 1; j++)
        {
            if (tab[j] > tab[j + 1])
            {
                tmp = tab[j + 1];
                tab[j + 1] = tab[j];
                tab[j] = tmp;
            }
        }
    }

    for (int i = 0; i < tab.Length; i++)
    {
        Console.WriteLine(tab[i]);
    }
}

static void Wait()
{
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();
    System.Console.Clear();
}