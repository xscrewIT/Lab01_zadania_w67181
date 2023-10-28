Zadanie5();

static void Zadanie5()
{
    Console.WriteLine("Wyswietlam liczby od 20 do 0, z pominieciem 2, 6, 9, 15, 19");
    for (int i = 20; i >= 0; i--)
    {
        if((i == 2) || (i == 6) || (i == 9) || (i == 15) || (i == 19)) continue;
        else Console.WriteLine(i);
    }
}