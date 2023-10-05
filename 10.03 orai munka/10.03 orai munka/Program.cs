
string[] hosszusag = {"mm","cm","dm","m","km"};
bool jo = false;

while (!jo)
{
    jo = true;

    Console.Write("Mit váltsak át?:");
    string be = Console.ReadLine();

    string[] darab = be.Split(' ');
    if (darab.Length != 2)
    {
        jo = false;
        continue;
    }

    double szam = 0;

    try
    {
         szam = Convert.ToDouble(darab[0]);
    }
    catch (Exception)
    {
        Console.WriteLine("Nem jó formátum! Legyen ilyen: 12,2 Kg");
        jo = false;
        continue;
    }

    Console.WriteLine(szam);

    if (hosszusag.Contains(darab[1]))
    {
    
    }
    else 
    {
        Console.WriteLine("Nem jó mértékegyseg!");
        jo = false;
        continue;
    
    }
}

Console.WriteLine("Mire szeretned atvaltani?");
for (int i = 0; i < hosszusag.Length; i++) 
{
    Console.WriteLine(hosszusag[i]);
}
Console.Write("Válassz:");
string valasz = Console.ReadLine();
