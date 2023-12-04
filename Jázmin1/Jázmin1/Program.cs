﻿using System.ComponentModel.Design;
bool kezdo = true;
int balance = 1000;
//MEGJEGYZÉS: HA CIKLUS FELTÉTELBEN ADSZ MEG EGY VÁLTOZÓT AKKOR AZT TUDOD HASZNÁLNI A CIKLUSBAN, ANNAK MEGVÁLTOZTATÁSA NÉLKÜL.
while (kezdo & balance != 0)
{






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



    //Összeadása elemeknek pl: 2+2=4

    int summ = dealer.AsQueryable().Sum();
    /*
    Console.WriteLine();
    Console.WriteLine(summ);
    */
    //player változat
    int summ2 = player.AsQueryable().Sum();
    /*
    Console.WriteLine();
    Console.WriteLine(summ2);
    */
    int valtozoBalance = 0;
    while (true)
    {
        Console.WriteLine("Mennyi pénzt szeretni feltenni, jelenlegi balance: {0} $", balance);

        valtozoBalance = Convert.ToInt32(Console.ReadLine());
        if (valtozoBalance > balance)
        {
            Console.WriteLine("!!Nincs Ennyi pénzed Csoro!!");
        }
        else if (valtozoBalance < balance & valtozoBalance > 0)
        {
            break;
        }
        else if (valtozoBalance == balance)
        {
            Console.WriteLine("Merész!");
            break;
        }

    }


    Console.WriteLine("----------------");
    Console.WriteLine("A játékos lapjainak összege: {0}", summ2);
    Console.WriteLine("A dealer lapjai: {0}, ?", dealer[0]);

    //jaték
    Console.WriteLine("Mit szeretne tenni? (stand, hit)");
    string dontes = Console.ReadLine();

    while (dontes != "")
    {
        if (dontes == "igen")
        {
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
        }

        if (dontes == "stand")
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Az ön lapjai: {0}", summ2);
            while (summ < 16)
            {
                int randomszam = rand.Next(1, 12);
                summ += randomszam;
            }
            Console.WriteLine("Dealer lapjai: {0}", summ);
            Console.WriteLine("--------------------------");



            if (summ > 21)
            {
                Console.WriteLine("Ön nyert");

                balance += valtozoBalance;
                Console.WriteLine("Balance = {0}$", balance);
                break;
            }
            if (summ == 21)
            {
                Console.WriteLine("Enemy BlackJack, Vesztettél");
                balance -= valtozoBalance;
                Console.WriteLine("Balance = {0}$", balance);
                break;
            }
            else if (summ > summ2)
            {
                Console.WriteLine("Vesztettél");
                balance -= valtozoBalance;
                Console.WriteLine("Balance = {0}$", balance);
                break;
            }

            else if (summ2 == summ)
            {
                Console.WriteLine("Draw.");
                Console.WriteLine("Balance = {0}$", balance);
                break;
            }
            else if (summ2 > summ)
            {
                Console.WriteLine("Ön nyert.");
                balance += valtozoBalance;
                Console.WriteLine("Balance = {0}$", balance);
                break;
            }
        }



        if (dontes == "hit")
        {
            player.Add(rand.Next(1, 12));
            summ2 = player.AsQueryable().Sum();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Az ön lapjai összege: {0}", summ2);
            Console.WriteLine("A Dealer lapjai : {0} ?", dealer[0]);
            Console.WriteLine("--------------------------");


        }




        if (summ2 == 21)
        {
            Console.WriteLine("BLACKJACK, Nyertél");
            balance += valtozoBalance;
            Console.WriteLine("Balance = {0}$", balance);
            break;
        }

        if (summ2 > 21)
        {
            Console.WriteLine("BUST");
            break;
        }

        Console.WriteLine("Mit szeretne tenni? (stand, hit)");
        dontes = Console.ReadLine();
    }

    Console.WriteLine("Szeretne mégegy kört? (igen, nem)");
    dontes = Console.ReadLine();

    if (dontes == "igen")
    {
        dealer.Clear();
        player.Clear();
        kezdo = true;
        Console.WriteLine("--------------------------");

    }
    else
    {
        Console.WriteLine("Rendben. Viszlát!");
        kezdo = false;
    }
}