Console.Write("Kérem adja meg a nevét:");
string nev =Console.ReadLine();

Console.WriteLine("Üdvözlöm " + nev);

Console.WriteLine("A bekérés 'vége' végjelig történik");



string beker = "";
while (beker != "vége")
{
    Console.Write("Írjon mondatokat:");
    beker = Console.ReadLine();
}

