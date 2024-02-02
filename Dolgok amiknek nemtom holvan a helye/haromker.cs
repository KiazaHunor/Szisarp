
Console.Write("Adja meg a háromszög első oldalát:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg a háromszög második oldalát:");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg a háromszög harmadik oldalát:");
int c = Convert.ToInt32(Console.ReadLine());

int kerulet = a+b+c;
Console.WriteLine("A háromszög kerülete: "+ kerulet);