string betuk = "qwertzuiopőúóüöasdfghjkléáűmnbvcxyí-";

string beSzo = "qwes";
string gyujto = "";
while(beSzo!="")
{
    bool joSzo = true;

    Console.Write("kerek egy szót:");
    beSzo = Console.ReadLine();

    for (int i = 0; i < beSzo.Length; i++)
    {
        if (betuk.IndexOf(beSzo[i]) == -1)
        {
            joSzo = false;
            Console.WriteLine("Ez nem jó szó!");
            break;
        }
    }
    if (joSzo) 
    {
        gyujto += beSzo+" ";
    }
}
Console.WriteLine(gyujto);
string[] darabok=gyujto.Trim().Split(',');

StreamWriter ir= new StreamWriter("szavak.txt");
for (int i = 0; i < darabok.Length; i++) 
{
    Console.WriteLine(darabok[i]);
}
ir.Close();

File.WriteAllLines("szavak2.txt",darabok);