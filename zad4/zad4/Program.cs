Zadanie4();

static void Zadanie4()
{
    float[] tab_rzeczywiste = new float[10];
    do
    {
        Menu();
        float.TryParse(Console.ReadLine(), out float choice);
        if (choice == 1)
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine($"Podaj element tablicy o indeksie {i}: ");
                if (float.TryParse(Console.ReadLine(), out tab_rzeczywiste[i])) continue;
                else Console.WriteLine("Niepoprawne dane, system przypisze wartosc '0' ");
            }
        }
        else if (choice == 2) ObliczSume(tab_rzeczywiste);
        else if (choice == 3) ObliczIloczyn(tab_rzeczywiste);
        else if (choice == 4) WyznaczSrednia(tab_rzeczywiste);
        else if (choice == 5) WyznaczMin(tab_rzeczywiste);
        else if (choice == 6) WyznaczMax(tab_rzeczywiste);
        else if (choice == 7) break;
        else
        {
            Console.WriteLine("Niepoprawne dane, sprobuj jeszcze raz");
        }
        Wait();
        System.Console.Clear();
    } while (true);
}

static void Menu()
{
    Console.WriteLine("**** 1. Wprowadzanie danych do tablicy ******");
    Console.WriteLine("**** 2. Oblicz sume elementow tablicy *******");
    Console.WriteLine("**** 3. Oblicz iloczyn elementow tablicy ****");
    Console.WriteLine("**** 4. Wyznacz wartosc srednia *************");
    Console.WriteLine("**** 5. Wyznacz wartosc minimalna ***********");
    Console.WriteLine("**** 6. Wyznacz wartosc maksymalna **********");
    Console.WriteLine("**** 7. Wyjscie ****");
    Console.WriteLine("Twoj wybor: ");
}


static void ObliczSume(float[] tab)
{
    Console.WriteLine(tab.Sum());
}

static void ObliczIloczyn(float[] tab)
{
    float iloczyn = 1;
    for (int i = 9; i >= 0; i--)
    {
        iloczyn *= tab[i];
    }
    Console.WriteLine(iloczyn);
}

static void WyznaczSrednia(float[] tab)
{
    Console.WriteLine(tab.Average());
}

static void WyznaczMin(float[] tab)
{
    Console.WriteLine(tab.Min());
}

static void WyznaczMax(float[] tab)
{
    Console.WriteLine(tab.Max());
}

static void Wait()
{
    Console.WriteLine("Press enter to continue");
    System.Console.ReadLine();
}