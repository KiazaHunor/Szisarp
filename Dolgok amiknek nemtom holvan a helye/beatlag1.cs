


int sum = 0;
int hossz = 0;
int szam;


        do
        {
            Console.Write("Kérem, adjon meg számokat nulla végjelig: ");
            szam = int.Parse(Console.ReadLine());

            if (szam != 0)
            {
                sum += szam;
                hossz++;
            }
        } 
        while (szam != 0);

double átlag = (double)sum / hossz;
Console.WriteLine($"A megadott számok átlaga: {átlag}");

