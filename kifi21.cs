//1.
Console.WriteLine("Gyártó: Horváth Hunor");
Console.WriteLine(((5 + 2) * 3) - ((2 + 4) * 4) / 0.5);

//2.
Console.WriteLine("Gyártó: Horváth Hunor");
int a = 5;
int b = 2;
int c = 3;
int d = 4;
Console.WriteLine(((a + b) * c) - ((b + d) * d) / 0.5);
//3.
static double szam()
{
    Console.WriteLine("Gyártó: Horváth Hunor");
    return ((5 + 2) * 3) - ((2 + 4) * 4) / 0.5;
}
Console.WriteLine(szam());
//4.
double sok(double t, double k, double l, double m, double v)
{
    Console.WriteLine("Gyártó: Horváth Hunor");
    return ((t + k) * l) - ((k + m) * m) / v;
}
Console.WriteLine(sok(5, 2, 3, 4, 0.5));

//5.
List<double> sokadik = new List<double> {5,2,3,4,0.5 };
Console.WriteLine("Gyártó: Horváth Hunor");
Console.WriteLine((sokadik[0] + sokadik[1]) * sokadik[2] - ((sokadik[1] + sokadik[3]) * sokadik[3]) / sokadik[4]);