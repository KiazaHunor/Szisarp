List <string> egy = new List<string>();
List<string> ketto = new List<string>();

StreamReader olvas = new StreamReader("kiserlet.txt");

while (!olvas.EndOfStream) 
{
    egy.Add(olvas.ReadLine());
}


for (int i = 0; i < egy.Count; i++) 
{
    Console.WriteLine(egy[i]);
}

olvas.Close();


File.ReadAllLines("kiserlet.txt");

