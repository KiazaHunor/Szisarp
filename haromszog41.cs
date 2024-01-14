Console.WriteLine("A program neve :haromszog4");
Console.WriteLine("Ez a program egy háromszöget vizsgál!");



Console.Write("1.oldal:");
double a =Convert.ToDouble(Console.ReadLine());
Console.Write("2.oldal:");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("3.oldal:");
double c = Convert.ToDouble(Console.ReadLine());




// Console.WriteLine(oldalak[1]);

if (a + b >c && a + c > b && b+c > a)
{
    Console.WriteLine("Működik!");
}

else
{
    Console.WriteLine("nem háromszög!");
}

double s = (a + b + c) / 2;
double terulet = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
Console.WriteLine("A háromszög területe: " + terulet + "cm2");