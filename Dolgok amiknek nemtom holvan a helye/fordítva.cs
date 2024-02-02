
List<int> szamok = new List<int>();

Console.Write("1. szam:");
szamok.Add(Convert.ToInt32(Console.ReadLine()));
Console.Write("2. szam:");
szamok.Add(Convert.ToInt32(Console.ReadLine()));
Console.Write("3. szam:");
szamok.Add(Convert.ToInt32(Console.ReadLine()));
Console.Write("4. szam:");
szamok.Add(Convert.ToInt32(Console.ReadLine()));




szamok.Reverse();

Console.WriteLine();

foreach (int szam in szamok) 
{
    Console.WriteLine(szam);
}

szamok.Reverse(0, 3);


