
string[] hosszusag = {"mm","cm","dm","m","km"};
int[] hosszvalto = { 10, 10, 10, 1000, 1 };

string[] terulet = { "mm2", "cm2", "dm2", "m2", "km2" };
int[] teruletValto = { 100, 100, 100, 1000000, 1 };

string[] tomeg = { "g", "dkg", "kg", "q", "t" };
int[] tomegValto = { 10, 100, 10, 100, 10 };

string[] urmertek = { "ml", "cl", "dl", "l", "hl" };
int[] urmertekValto = { 10, 10, 10, 10, 100 };

bool jo = false;

string forrasMertekEgyseg = "";
double szam = 0;

string[] egyseg = { };
int[] valto = { };



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



    try
    {
        szam = Convert.ToDouble(darab[0]);
    }
    catch (Exception)
    {
        Console.WriteLine("Nem jó formátum! Legyen ilyen: 12,2 Km");
        jo = false;
        continue;
    }

    Console.WriteLine(szam);

    if (hosszusag.Contains(darab[1]))
    {
        forrasMertekEgyseg = darab[1];
        egyseg = hosszusag;
        valto = hosszvalto;
    }
    else if (terulet.Contains(darab[1]))
    {
        forrasMertekEgyseg = darab[1];
        egyseg = terulet;
        valto = teruletValto;
    }
    else if (tomeg.Contains(darab[1]))
    {
        forrasMertekEgyseg = darab[1];
        egyseg = tomeg;
        valto = tomegValto;
    }
    else if (urmertek.Contains(darab[1]))
    {
        forrasMertekEgyseg = darab[1];
        egyseg = urmertek;
        valto = urmertekValto;
    }
    else
    {
        Console.WriteLine("Nem jó mértékegyseg!");
        jo = false;
        continue;

    }


    Console.WriteLine("Mire szeretned atvaltani?");
    for (int i = 0; i < egyseg.Length; i++)
    {
        Console.WriteLine(egyseg[i]);
    }
    string valasz = "";
    while (!egyseg.Contains(valasz))
    {
        Console.Write("Válassz:");
        valasz = Console.ReadLine();
    }

    int index1 =Array.IndexOf(egyseg, forrasMertekEgyseg);
    int index2 =Array.IndexOf(egyseg, valasz);
    int szorzo = 1;

    double eredmeny =0;
    if (index1 < index2)
    {
        for (int i = index1; i < index2; i++)
        {
            szorzo = szorzo * valto[i];
        }
        //Console.WriteLine(szorzo);
        eredmeny = szam / szorzo;
    }
    else 
    {
        for (int i = index2; i < index1; i++)
        {
            szorzo = szorzo * valto[i];
        }
        //Console.WriteLine(szorzo);
        eredmeny = szam * szorzo;
    }
    Console.WriteLine("{0} {1} = {2} {3}", szam, forrasMertekEgyseg, eredmeny, valasz);
}
