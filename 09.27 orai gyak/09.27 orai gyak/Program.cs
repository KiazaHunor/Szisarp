// See https://aka.ms/new-console-template for more information
//1. feladat 
Console.Write("Kerek egy szamot:");
int szam =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(szam);
//2. feladat
Console.Write("Kerek egy szamot: ");
int szam1=Convert.ToInt32(Console.ReadLine());
Console.Write("Kerek egy szamot: ");
int szam2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(szam1 - szam2);
//3. feladat
Console.Write("Kerek egy  tizedes szamot: ");
double szam3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Kerek egy szamot: ");
double szam4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(szam3 * szam4);
// 4. Feladat
Console.Write("Kerek egy szamot: ");
int szam5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kerek egy szamot: ");
int szam6 = Convert.ToInt32(Console.ReadLine());
    if (szam5 <= szam6)
    {
        Console.WriteLine(szam6);
    }
    if (szam6 <= szam5)
    {
        Console.WriteLine(szam5);
    }
//5. Feladat
Console.Write("Kerek egy szamot: ");
int szam7 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kerek egy szamot: ");
double szam8 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(szam7 / szam8);
//6. Feladat
Console.Write("Kerek egy szamot: ");
int szam9 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kerek egy szamot: ");
double szam10 = Convert.ToInt32(Console.ReadLine());
for (int i = szam9; i < szam10; i++) 
{
    Console.WriteLine(i);
}
//7. Feladat
Console.Write("Kerek egy szamot: ");
int szam11 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kerek egy szamot: ");
double szam12 = Convert.ToInt32(Console.ReadLine());
for (int i = szam11; i <= szam12; i++)
{
    Console.WriteLine(i);
}
//8.Feladat
int num = 0;
Console.Write("Kerek egy szamot: ");
int szam13 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kerek egy szamot: ");
double szam14 = Convert.ToInt32(Console.ReadLine());
for (int i = szam13; i <= szam14; i++)
{
    Console.Write(i * i);
    num += 1;
    if (num % 2 == 0)
    {
        Console.WriteLine();
    }
}
//9.Feladat
Console.Write("Kerek egy szamot: ");
int szam15 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kerek egy szamot: ");
int szam16 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kerek egy szamot: ");
int szam17 = Convert.ToInt32(Console.ReadLine());
if (szam15 <= szam16 && szam17 <= szam16)
{
    Console.WriteLine(szam16);
}
if (szam16 <= szam15 && szam17 <= szam15)
{
    Console.WriteLine(szam15);
}
if (szam15 <= szam17 && szam16 <= szam17)
{
    Console.WriteLine(szam17);
}