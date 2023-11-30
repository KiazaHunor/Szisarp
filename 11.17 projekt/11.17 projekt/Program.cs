List<int> dealer = new List<int>();
List<int> player = new List<int>();

Random rand = new Random();

int szamok = rand.Next(104);

for (int i = 0; i < szamok; i++)
{
    if (dealer.Count < 2)
    {
        dealer.Add(rand.Next(1, 12));
    }
    else
    {
        break;
    }
}

for (int i = 0; i < szamok; i++)
{
    if (player.Count < 2)
    {
        player.Add(rand.Next(1, 12));
    }
    else
    {
        break;
    }
}

foreach (int i in dealer)
{
    Console.WriteLine(i);
}

foreach (int i in player)
{
    Console.WriteLine(i);
}

//Összeadása elemeknek pl: 2+2=4

int sum = dealer.AsQueryable().Sum();

Console.WriteLine();
Console.WriteLine("Az dealer első 2 lapjának értéke {0}",sum);

//player változat

int sum2 = player.AsQueryable().Sum();

Console.WriteLine();
Console.WriteLine("Az első 2 lapod értéke {0}",sum2);


