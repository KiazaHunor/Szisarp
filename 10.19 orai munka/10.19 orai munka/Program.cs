int[] tombKeszit(int darab, int legkisebb, int legnagyobb)
{
    int[] tomb = new int[darab];
    Random rand = new Random();

    for (int i = 0; i < tomb.Length; i++)
    {
        tomb[i] = rand.Next(legkisebb, legnagyobb + 1);
    }

    return tomb;
}

int[] szamok = tombKeszit(10000, 1000, 9999);
int a = 0;
int b = 0;


for (int i = 0; i < szamok.Length; i++) 
{
    if (szamok[i] % 2 == 0)
    {
        a += 1;
    }
    else 
    {
        b += 1;
    }
}
Console.WriteLine("Eddig jó "+ a);
Console.WriteLine("Nem ez a feladat " + b);
