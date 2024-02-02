class radio:
    def __init__(self,ora,perc,adasdb,nev):
        self.ora=ora
        self.perc=perc
        self.adasdb=adasdb
        self.nev=nev

f=open("cb.txt")
adat=[]
for e in f:
    #temp=
    adat.append(e.replace("\n","").split(";"))

#print(adat)

f.close()

print("3.feladat:")
print("Bejegyzések {}".format(len(adat)))

print("4.feladat:")

adasdb=[]
for i in adat:
    if len(adasdb)=="4":
        print("4 adást indított")
        break
else:
    print("Kevesebb mint 4 adást indított")


    
print("5.Feladat")
k = input("Kérem egy sofőr nevét:")
nev=[]
for e in adat:
    nev.append(e[3])
    if nev==k:
        print("k")
else:
    print("kérek egy új nevet")
            
            
input("szeretné folytatni? (igen,nem):")

print("6.feladat")
#def AtszamolPercre():





        
