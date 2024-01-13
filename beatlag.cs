
Console.WriteLine("Adjon meg számokat 0 végjelig!");

int szam;
do
 {
     Console.Write("Kérem, adjon meg egy számot: ");
     szam = int.Parse(Console.ReadLine());
     
 } 
while (szam != 0);

//Nem működik!

Console.WriteLine("A bekért számok átlaga:"+  );

