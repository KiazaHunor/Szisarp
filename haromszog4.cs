Console.WriteLine("A program neve :haromszog4");
Console.WriteLine("Ez a program egy háromszöget vizsgál!");

List<int> oldalak = new List<int>();

Console.Write("1.oldal:");
oldalak.Add(Convert.ToInt32(Console.ReadLine()));
Console.Write("2.oldal:");
oldalak.Add(Convert.ToInt32(Console.ReadLine()));
Console.Write("3.oldal:");
oldalak.Add(Convert.ToInt32(Console.ReadLine()));




// Console.WriteLine(oldalak[1]);

if (oldalak[0] + oldalak[1] > oldalak[2] && oldalak[0] + oldalak[2] > oldalak[1] && oldalak[1] + oldalak[2] > oldalak[0])
{
    Console.WriteLine("Működik!");
}

else
{ 
    Console.WriteLine("nem háromszög!");
}

Console.Write("Kérem az 1. oldal magasságát:");
int m = Convert.ToInt32(Console.ReadLine());

int terulet = oldalak[0] * m / 2;
Console.WriteLine("A háromszög területe:" + terulet);

