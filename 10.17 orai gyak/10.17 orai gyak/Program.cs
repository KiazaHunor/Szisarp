using System.ComponentModel.Design;

int[] tombKeszit(int darab,int legkisebb, int legnagyobb) 
{
    int[] tomb=new int[darab];
    Random rand= new Random();
    for (int i = 0; i < tomb.Length; i++)
    {
        tomb[i] = rand.Next();
    }
    return tomb;    
}
int[] szamok=tombKeszit(1000, 100, 999);

int a = 0;
int b = 0;
/*
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
Console.WriteLine("Páros:" + a);
Console.WriteLine("Paratlan" + b);
*/
//következő elem vizsgálata
/*
bool vanEgyenloSzomszedos=false;
for (int i = 1; i < szamok.Length; i++)
{
    if (szamok[i] == szamok[i -1])
    {
       vanEgyenloSzomszedos = true;
        //break;
        Console.WriteLine("Egyenlő:{0} és {1},{2} = {3}", i-1, i, szamok[i - 1], szamok[i]);
    }
}
if (vanEgyenloSzomszedos)
{
    Console.WriteLine("Van egyenlő szomszédos eleme!");
}
else 
{
    Console.WriteLine("Van egyenlő szomszédos eleme!");
}
*/
/*
for(int i = 1; i < szamok.Length;i++)
{
    if (szamok[i] > szamok[i] + 1)
    {
        Console.WriteLine(szamok[i] > szamok[1]-1);
    }
    else 
    {
        Console.WriteLine("Nem jó");
    }
}
*/

void szakasz2(int[] szamTomb) 
{
    int kezd = 0;
    int veg = 0;
    int Maxkezd = 0;
    int Maxveg=0;

    for (int i = 1;i < szamTomb.Length;i++) 
    {
        if (szamTomb[i - 1] < szamTomb[i])
        {

        }
        else 
        {
            veg = i - 1;
            if (veg - kezd + 1 > Maxveg - Maxkezd + 1)
            {
                Maxveg = veg;
                Maxkezd = kezd;
            }
            kezd = i;
        }
    }
    Console.WriteLine("A legnagyobb szamsorozat {0}" ,Maxveg - Maxkezd);
    for (int i = Maxkezd; i < Maxveg + 1; i++)
    {
        Console.Write(szamTomb[i]);
    }
    Console.WriteLine();
}
szakasz2(szamok);
