using _12._12;

class auto
{
    public int kerekSzam = 4;
    public void dudal()
    {
        Console.WriteLine("tututtutututut");
    }
    private string _tulaj;

    public string tulajdonos
    {
        get
        {
            return _tulaj;
        }
        set
        {
            if (value == "Bence")
            {
                Console.WriteLine("NEM");
            }
            else 
            {
                _tulaj = value;
            }
            
        }
    }
}
class Program
{
    static void Main()
    {
        auto kocsi = new auto();
        Console.WriteLine(kocsi.kerekSzam);

        kocsi.dudal();
        kocsi.tulajdonos = "Gabi";
        Console.WriteLine(kocsi.tulajdonos);

        kocsi.tulajdonos = "Bence";
        Console.WriteLine(kocsi.tulajdonos);

        Laci laci = new Laci();
        laci.sug();
    }
}
