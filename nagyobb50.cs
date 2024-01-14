//1.megoldás (nem működik!)

Console.Write("Adjon meg egy számot 10-100 között:");
int szam = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < szam; i++) 
{
    if (szam > 50)
    {
        Console.WriteLine("Oks!");
    }
    else if (szam < 50) 
    {
        Console.WriteLine("Próbálja meg újra:");
    }
}


//2.megoldás (Netes segítséggel!)
int number;

do
{
    Console.Write("Kérlek, add meg egy számot 10-100 között:");
} 
while (!int.TryParse(Console.ReadLine(), out number) || number < 50);
