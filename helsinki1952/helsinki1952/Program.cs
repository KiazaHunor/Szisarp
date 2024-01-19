using helsinki1952;

List<adatok> eredmenyek = new List<adatok>();

StreamReader olvas = new StreamReader("helsinki.txt");
while (!olvas.EndOfStream) 
{
    string sor = olvas.ReadLine();
    eredmenyek.Add(new adatok(sor));
}

olvas.Close();

Console.WriteLine("3.Feladat");
Console.WriteLine("Pontszerző helyezések száma: {0}",eredmenyek.Count);

Console.WriteLine("4.feladat:");
int[] ermekSzama= new int[7];

for (int i = 0; i < eredmenyek.Count; i++) 
{
    ermekSzama[eredmenyek[i].helyezes]++;
}
Console.WriteLine("Arany:"+ermekSzama[1]);
Console.WriteLine("Ezüst:"+ermekSzama[2]);
Console.WriteLine("Bronz:"+ermekSzama[3]);

Console.WriteLine("5. feladat:");