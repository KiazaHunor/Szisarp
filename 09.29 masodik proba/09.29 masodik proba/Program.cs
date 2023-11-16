// See https://aka.ms/new-console-template for more information
Console.WriteLine("szoveg {0} szoveg {1}", 12, 3.4);

Console.WriteLine("szoveg {0:0.00%} szoveg {1,10}", 12, 3.4);
/*
int a = 12;
double b = 3.4;
Console.WriteLine($"szoveg {a / 2} szoveg {b}");

Console.WriteLine("{0,10}", 1);
Console.WriteLine("{0,10}", 10);
Console.WriteLine("{0,10}", 100);
Console.WriteLine("{0,10}", 1000);
*/
/*
Console.Write("Kerek egy befogot(a):");
int szam = Convert.ToInt32(Console.ReadLine());
Console.Write("Kerek egy befogot(a):");
int szam1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ez az atfogo:"+ szam * szam + szam1*szam1);
*/
int a = 3;
int b = 4;
double c = Math.Sqrt(a * a + b * b);
Console.WriteLine(c);

Console.WriteLine("{0,5} {1,5} {2,5}","a","b","c");
Console.WriteLine("------------------------");

for (int i = 1; i < 50; i++)
{
    for (int k = i; k < 50; k++) 
    {
        c = Math.Sqrt(i * i + k * k);
        if (c%1==0)
        {
            Console.WriteLine("{0,5} {1,5} {2,5}", i, k, c);
        }
    }
}
for (int i = 0; i < 10; i++) 
{
    Console.WriteLine("{0:0.00}",Math.Sqrt(i));
}
