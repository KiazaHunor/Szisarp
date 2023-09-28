// See https://aka.ms/new-console-template for more information
//Kerjunk be 3 szamot írja ki a legnagyobbat

Console.Write("Kerek egy szamot:");
int szam = Convert.ToInt32(Console.ReadLine());

Console.Write("Kerek egy szamot:");
int szam1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Kerek egy szamot:");
int szam2 = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < szam1 && i < szam && i < szam2; i++)
{
    if (szam > szam1 && szam > szam2)
    { Console.WriteLine(szam); }

     if (szam1 > szam && szam1 > szam2)
    { Console.WriteLine(szam1); }

     if (szam2 > szam && szam2 > szam1)
    { Console.WriteLine(szam2); }
    else
        break;
}

// kerj be egy szamot és egy betut, a betut anyiszor irassuk ki amekkkora a szam

Console.Write("Kerek egy betut:");
string betu = Console.ReadLine();

Console.Write("Kerek egy szamot:");
int szamok = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < szamok; i++)
    { }

// kerj be 2 szamot ha a 2 szam negyzeteinek osszeget  írassa ki

//ket szam kozti szamok negyzeteinek osszege

Console.Write("Adjon meg egy szamot:");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Adjon meg egy szamot:");
int num1 = Convert.ToInt32(Console.ReadLine());
for (int i = num;  i < num1; i++) 
{
    
    {
        
    }
}

//Negyzetgyök vonas
int x = 10;
Console.Write((x * x) + (3 * x) / 9 - (5 * (x * x) - 6 * (9 - x) * 2));
Console.Write(12 + 6 * (1 / (x * x - 1 * 1) - 12));


