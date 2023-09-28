namespace _09._21_ORAI_MUNKA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KERJUNK BE ADDIG AMEDDIG 1.2 VEL NEM OSZTHATOT KAPUNK ÍRASSUK KI ANNAK A SZAMNAK AZ OSZTOIT
            double szam = 1;
            while (szam % 1.2 >= 0.001) 
            {
                Console.Write("Adjon meg egy szamot:");
                szam = Convert.ToDouble(Console.ReadLine());
            }


            /*while (szam % 1.2 != 0) 
            {
                Console.WriteLine(szam);
            }
            */
            szam = Convert.ToInt32(szam);
            for (int i = 2; i < szam; i ++)
            {
                if (szam % i == 0) 
                { 
                    Console.Write(i);
                }
                

            } 

                
            


        }
    } 
}