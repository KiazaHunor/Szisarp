Console.Write("Kérem, adjon meg egy karaktersorozatot: ");

string beker = Console.ReadLine();

char[] charArray = beker.ToCharArray();

Array.Reverse(charArray);

Console.WriteLine("A bekért karaktersorozat fordítva: " + new string(charArray));
