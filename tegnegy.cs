for (int i = 0; i < 2; i++)
{ 
Console.WriteLine("Téglalap!");

Console.Write("Kérem az A oldalt értéket:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Kérem az B oldalt értéket:");
int b = Convert.ToInt32(Console.ReadLine());

int kerulet = a* 2 + b* 2;
int terulet = a * b;

Console.WriteLine("A téglalap kerülete:" + kerulet+"cm");
Console.WriteLine("A téglalap terulete:" + terulet+"cm2");
}