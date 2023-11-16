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
/*
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
*/

// 1000 ELEMŰ TÖMB 3 jegyu szamokkal.

//1000 3 jegyű random szám
int[] szamok = new int[1000];
Random rand = new Random();
for (int i = 0; i < szamok.Length; i++)
{
    szamok[i] = rand.Next(100, 1000);
}
foreach (int s in szamok)
{
    Console.WriteLine(s);
}
/*
0. sor: 2-vel osztható
1. sor: 3-mal osztható
2. sor: 4-gyel osztható
3. sor: 5-tel osztható
4. sor: 6-tal osztható
*/
int[,] oszthato = new int[5, 1000];
int sor0 = 0;
int sor1 = 0;
int sor2 = 0;
int sor3 = 0;
int sor4 = 0;
for (int i = 0; i < oszthato.GetLength(1); i++)
{
    if (szamok[i] % 2 == 0)
    {
        oszthato[0, sor0++] = szamok[i];
    }
}
for (int i = 0; i < oszthato.GetLength(1); i++)
{
    if (szamok[i] % 3 == 0)
    {
        oszthato[1, sor1++] = szamok[i];
    }
}
for (int i = 0; i < oszthato.GetLength(1); i++)
{
    if (szamok[i] % 4 == 0)
    {
        oszthato[2, sor2++] = szamok[i];
    }
}
for (int i = 0; i < oszthato.GetLength(1); i++)
{
    if (szamok[i] % 5 == 0)
    {
        oszthato[3, sor3++] = szamok[i];
    }
}
for (int i = 0; i < oszthato.GetLength(1); i++)
{
    if (szamok[i] % 6 == 0)
    {
        oszthato[4, sor4++] = szamok[i];
    }
}
foreach (int s in oszthato)
{
    Console.WriteLine(s);
}

int kettoveloszthato = 0;
for (int i = 0; i < oszthato.GetLength(1); i++)
{
    if (oszthato[0, i] != 0)
    {
        kettoveloszthato++;
    }
}
Console.WriteLine(kettoveloszthato);