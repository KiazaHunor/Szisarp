List<string> szavak=new List<string>();

szavak.Add("Benc-e");
szavak.Add("Ver Bulecz?");
szavak.Add("VörösBor");
Console.WriteLine(szavak);

for (int i = 0; i < szavak.Count; i++) 
{
    Console.WriteLine(szavak[i]);
}
foreach (string s in szavak) 
{
    Console.WriteLine(szavak.Contains("Bence"));

    Console.WriteLine(szavak.IndexOf("Bence"));

    Console.WriteLine(szavak.IndexOf("VörösBor"));
}

Dictionary<string,int> p=new Dictionary<string, int>();
p.Add("Laci", 3);
p.Add("Bence", 0);
Console.WriteLine(p.Count);

p["Tomi"] = 4;
Console.WriteLine(p.Count);
p["Tomi"] = -4;

try 
{
    p.Add("Bence", 10);
}
catch(Exception )
{
    p["Bence"]--;
}

p.Remove("Bence");

foreach (KeyValuePair<string,int> e in p) 
{
    Console.WriteLine(e.Key);
}
