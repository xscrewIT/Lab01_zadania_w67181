using System.Xml.Serialization;

Zadanie3();

static void Zadanie3()
{
    int[] tab_rzeczywiste = new int[10];
    do
    {
        Menu();
        Int32.TryParse(Console.ReadLine(), out int choice);
        if (choice == 1)
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine($"Podaj element tablicy o indeksie {i}: ");
                if (Int32.TryParse(Console.ReadLine(), out tab_rzeczywiste[i])) continue;
                else Console.WriteLine("Niepoprawne dane, system przypisze wartosc '0' ");
            }
        }
        else if (choice == 2) WyswietlOd1(tab_rzeczywiste);
        else if (choice == 3) WyswietlOd10(tab_rzeczywiste);
        else if (choice == 4) WyswietlNieparzysteID(tab_rzeczywiste);
        else if (choice == 5) WyswietlParzysteID(tab_rzeczywiste);
        else if (choice == 6) break;
        else
        {
            Console.WriteLine("Niepoprawne dane, sprobuj jeszcze raz");
        }
        Wait();
        System.Console.Clear();
    }while (true);
}

static void Menu()
{
    Console.WriteLine("**** 1. Wprowadzanie danych do tablicy ******************************");
    Console.WriteLine("**** 2. Wyswietlanie tablicy od pierwszego do ostatniego indeksu ****");
    Console.WriteLine("**** 3. Wyswietlanie tablicy od ostatniego do pierwszego indeksu ****");
    Console.WriteLine("**** 4. Wyswietlanie elementow o nieparzystych indeksach ************");
    Console.WriteLine("**** 5. Wyswietlanie elementow o parzystych indeksach ***************");
    Console.WriteLine("**** 6. Wyjscie ****");
    Console.WriteLine("Twoj wybor: ");
}


static void WyswietlOd1(int[] tab)
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Indeks {i}: {tab[i]}");
    }
}

static void WyswietlOd10(int[] tab)
{
    for (int i = 9; i >= 0; i--)
    {
        Console.WriteLine($"Indeks {i}: {tab[i]}");
    }
}

static void WyswietlNieparzysteID(int[] tab)
{
    for (int i = 0; i < 10; i++)
    {
        if(i % 2 == 1) Console.WriteLine($"Indeks {i}: {tab[i]}");
    }
}

static void WyswietlParzysteID(int[] tab)
{
    for (int i = 0; i < 10; i++)
    {
        if (i % 2 == 0) Console.WriteLine($"Indeks {i}: {tab[i]}");
    }
}

static void Wait()
{
    Console.WriteLine("Press enter to continue");
    System.Console.ReadLine();
}