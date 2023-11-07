static string szo(int darab)
{ 
    Random rand=new Random();
    string betuk = "qwertzuiopőúűáélkjhgfdsaíyxcvbnm";
    string mgh = "euioőúűáéaí";
    string msh = "qwrtzplkjhgfdsyxcvbnm";
    
    string szo = "";
    for (int i = 0; i < darab; i++) 
    {
        int index=rand.Next(betuk.Length);
        szo += betuk[index];
    }
    
    string szo1 = "";
    for (int i = 0; i < darab; i++) 
    {
        int index = rand.Next(mgh.Length);
        szo1 += mgh[index];
    }
    
    string szo2 = "";
    for (int i = 0; i < darab; i++) 
    {
        int index = rand.Next(msh.Length);
        szo2 += msh[index];
    }
    return szo;
}

string[] sokszo=new string[10000];
Random rand = new Random();
for (int i = 0; i < sokszo.Length; i++) 
{
    sokszo[i] = szo(rand.Next(2,11));
}

sokszo[sokszo.Length - 1] = "aa";
sokszo[0] = "baabababab";
File.WriteAllLines("szavak.txt", sokszo);

for (int i = 0;i < sokszo.Length; i++) 
{
    Console.WriteLine(sokszo[i]);
}

string[] szavak = File.ReadAllLines("szavak.txt");

string tobbszoros = "";
for(int i = 0; i < szavak.Length; i++) 
{
    for (int k = i+1;k < szavak.Length; k++) 
    {
        if (szavak[i] == szavak[k])
        {
            tobbszoros += ";"+szavak[k];
            break;
        }
    }
    if (tobbszoros != "") {
        tobbszoros = tobbszoros.Substring(1);
        Console.WriteLine("Többször előforduló szavak:" + tobbszoros);
    }
}


for (int i = 0; i < szavak.Length; i++) 
{
    if (szavak[i].Length == 4) 
    {
        szavak[i] = szavak[i].Substring(0,1).ToUpper() + szavak[i].Substring(1);
        Console.WriteLine(szavak[i]);
    }
}


for (int i = 0; i < szavak.Length; i++) 
{
    if (szavak[i].Length == 4) 
    {
        for(int k = 0;k< szavak.Length; k++) 
        {
            if (szavak[k].Length == 6) 
            {
                if (szavak[k].IndexOf(szavak[i].ToLower()) > -1) 
                {
                    Console.WriteLine("{0} benne van ebben: {1}", szavak[i], szavak[k]);
                }
            }
        }
    }
}


for (int i = 0;i < szavak.Length; i++) 
{
    if (szavak[i].Length == 5)
    {
        szavak[i] = szavak[i].Replace("a", "@").Replace("l", "1").Replace("o", "0");
        Console.WriteLine(szavak[i]);
    }
}

string[] valogat = new string[11];

for (int i = 0;i<szavak.Length;i++)
{
    valogat[szavak[i].Length] += szavak[i] + ";";
}

for(int i = 4; i<szavak.Length; i++) 
{ 
    string[] darabolt = valogat[i].Substring(0, valogat[i].Length).Split(';');

    Array.Sort(darabolt);
    File.WriteAllLines(i + "betus.txt", darabolt);
}