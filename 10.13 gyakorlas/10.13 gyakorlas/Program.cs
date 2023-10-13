// See https://aka.ms/new-console-template for more information
/*
Console.Write("Kerek egy szamot:");
int szam =Convert.ToInt32(Console.ReadLine());

string[] szavak=new string[szam];
for(int i=0; i<szavak.Length;i++)
{
    Console.Write("Kerek egy szót:");
    szavak[i] = Console.ReadLine();
}

string max = "";
for (int i = 0; i < szavak.Length; i++) 
{
    if (szavak[i].Length > max.Length) 
    {
        max = szavak[i];
    }
}
Console.WriteLine(max);
//index kereses
int maxIndex = 0;
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i] == max)
    {
        maxIndex = i;
    }
}

//max kereses maskent
max = "";
maxIndex = 0;
for (int i = 0; i < szavak.Length; i++) 
{
    if (szavak[i].Length > max.Length) 
    {
        max = szavak[i];
        maxIndex = i;
    }
}
//max kereses 3
maxIndex= 0;
for (int i = 0; i < szavak.Length; i++) 
{
    if (szavak[i].Length > szavak[maxIndex].Length) 
    {
        maxIndex= i;
    }
}
*/

string[] szavak = new string[] { "alma", "körte",
                "banán", "barack", 
                "kivi", "dinnye" };
string[] rovid = new string[szavak.Length];
string[] hosszu = new string[szavak.Length];


int rovidIndex = 0;
int hosszuIndex = 0;
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length <= 5)
    {
        rovid[rovidIndex] = szavak[i];
        rovidIndex++;
    }
    else 
    {
        hosszu[hosszuIndex++] = szavak[i];
    }
}
for (int i = 0; i < rovid.Length; i++)
{
    Console.WriteLine(rovid[i]);
}
for (int i = 0; i < hosszu.Length; i++)
{
    Console.WriteLine(hosszu[i]);
}