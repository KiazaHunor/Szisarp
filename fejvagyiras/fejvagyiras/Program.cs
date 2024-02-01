using fejvagyiras;


StreamReader olvas = new StreamReader("kiserlet.txt");
while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    if (dobasok[dobasok.Count-1].dobas == sor) 
    { 
    }
}
olvas.Close();