
int iq1;
int iq2;
int iq3;


Console.WriteLine("Kérem az első ember IQ-ját:");
iq1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kérem a második ember IQ-ját:");
iq2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kérem a harmadik ember IQ-ját:");
iq3 = Convert.ToInt32(Console.ReadLine());

        if (iq1 > 130)
        {
            Console.WriteLine("Az első embernek nagyobb az IQ-ja, mint 130.");
        }
        if (iq2 > 130)
        {
            Console.WriteLine("A második embernek nagyobb az IQ-ja, mint 130.");
        }
        if (iq3 > 130)
        {
            Console.WriteLine("A harmadik embernek nagyobb az IQ-ja, mint 130.");
        }