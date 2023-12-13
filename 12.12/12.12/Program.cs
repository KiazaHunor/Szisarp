namespace oop
{ 
    class auto
    {
        public int kerekSZam = 4;

         public void dudal()
        {
            Console.WriteLine("adwawdawawdawdaw!!");
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
        Console.WriteLine(kocsi.keretSzam);

        kocsi.dudal();
    }
}
