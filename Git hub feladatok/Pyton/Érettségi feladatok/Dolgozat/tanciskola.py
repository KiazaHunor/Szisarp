class tanc:
    def __init__(self,tanc,lany,fiu):
        self.tanc=tanc
        self.lany=lany
        self.fiu=fiu

    def __str__(self):
        return "Tánc: {}, lány: {}, fiu: {}".format(self.tanc,self.lany,self.fiu)

    def isVilma(self):
        return self.lany=="Vilma"
    
        

f=open("tancrend.txt")
#print(f)

sorok=[]
#2.Megoldas
tancok2=[]
temp=[]
for e in f:
    sorok.append(e.strip())
    if len(temp)<3:
        temp.append(e)
    else:
        tancok2.append(tanc(temp[0],temp[1],temp[2]))
f.close()

print(sorok)
print(sorok[:3])

#1.Megoldas
tancok=[]
for i in range(len(sorok)//3):
    tancnev=sorok[i*3]
    lany=sorok[i*3+1]
    fiu=sorok[i*3+2]
    tancok.append(tanc(tancnev,lany,fiu))
#print(tancok)

print("2. feladat")
print("Első tánc {}, utolsó tanc {} ".format(tancok[0].tanc,tancok[-1].tanc))

db=0
for egyTanc in tancok:
    if egyTanc.tanc == "samba":
        db+=1

print("Ennyi samba volt {}".format(db))

print("Vilma ezekben szerepelt: {}")

for egyTanc in tancok:
    if egyTanc.isVilma():
        print(egyTanc.tanc)
    


tancNev=input("Kerek egy tancnevet:")
for elem in tancok:
    
    if elem.lany=="Vilma" and elem.tanc==tancNev:
        print("A {} bemutatojan Vilma párja {} volt.".format(tancNev,elem.fiu))
        break
else:
        print("Vilma nem táncolt {}-t.".format(tancNev))
   
fiu=[]
lany=[]
for egyTanc in tancok:
    if egyTanc.fiu not in fiu:
       fiu.append(egyTanc.fiu)
    if egyTanc.lany not in lany:
        lany.append(egyTanc.lany)
print(", ".join(fiu))
print(", ".join(lany))

f=open("szereplok.txt","w")
f.write("Lanyok: "+", ".join(lany)+"\n")
f.write("Fiuk: "+", ".join(fiu)+"\n")
f.close()

statFiu={}
statLany={}

for egy in fiu:
    statFiu[egy]=0

for egy in lany:
    statLany[egy]=0
    
for egyTanc in tancok:
    statFiu[egyTanc.fiu]+=1
    statLany[egyTanc.lany]+=1
print(statFiu)
print(statLany)
