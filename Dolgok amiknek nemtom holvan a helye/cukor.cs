
int[] tomb = new int[100];
int i = 0;

        while (true)
        {
            Console.Write("Adja meg a rakomány tömegét:");
            string beker = Console.ReadLine();
            if (!int.TryParse(beker, out int szam))
            {
                break;
            }

            tomb[i] = szam;
            i++;
        }



