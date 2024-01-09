using _01._09_gyakorlas;
using System.Timers;

ember e1 = new ember("Szakacs", "Árpád");

Console.WriteLine(e1.teljesNev);

ember e2 = new ember("Nagy", "Árpi");

Console.WriteLine (e2.teljesNev);


udvariasember ue1 = new udvariasember("Horvath", "Hugó");
Console.WriteLine(ue1.teljesNev);

ue1.koszon();
ue1.koszonNevvel();
ue1.koszon(ue1);
ue1.koszonNevvel(e2);

diak d1 = new diak ("Talas", "Miklós", 12);
diak d2 = new diak("Verbulecc", "Bálint", 19);
diak d3 = new diak("Mibajodvan", "Alehandro", 26);

d1.koszon(ue1);
d1.koszonNevvel(d2);

// 3 fele random koszones!