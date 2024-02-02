class feladat:
    def __init__(self,nev,szuletes):
        self.nev=nev
        self.szuletes=int(szuletes)

    def hanyeves(self):
        return

f=open("gyak 06.12.txt")
evek=[]
for i in f:
    temp=i.strip().split(",")
    evek.append(feladat(*temp))
    
f.close()       
beker=input("Kerek egy szamot:")
for i in evek:
    
    

def eletkor(self):
    nev=[]
    nev.append(evek[1])
    szuletes=[]
    szuletes.append(evek[2])
    beker=input("Adjon meg egy evszamot:")
    
    if beker<szuletes:
        print("Túl kicsi szám adjon meg nagyobbat")
        beker=input("Adjon meg egy evszamot:")
    elif beker>szuletes:
        print("{} {}")
