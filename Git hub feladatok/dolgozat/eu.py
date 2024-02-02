eu=[]
f=open("EUcsatlakozas.txt")
for e in f:
    eu.append(e.replace("\n","").split(";"))
f.close()


#3

evek=[]
for e in eu:
    evek.append(e[1])

tagok=0
for e in evek:
    if int(e[0:4]) < 2018:
        tagok += 1
    
print("3.feladat: EU tagállamok száma: {}".format(tagok))
#4
csatlakozott=0
for e in evek:
    if int(e[0:4]) == 2007:
        csatlakozott += 1

print("4.Feladat: 2007-ben {} ország csatlakozott.".format(csatlakozott))

#5
orszag=""
for e in eu:
    if e[0] == "Magyarország":
        orszag = e[1]
        
        
print("5.feladat:Magyarország csatlakozásának dátuma: {}".format(orszag))
    
#6

for e in evek:
    if e[5:7] == "05" :
        van = True
if van == True:
    print("6.Feladat: Volt májusban csatlakozás!")
else:
    print("6.Feladat: Nem volt májusban csatlakozás!")

#7

orszag=""

#for e in eu:
    #if e[12:21] == "2013.07.01":
        #orszag = eu(e[0])

lista=[]
for e in evek:
    if str(e[0:4]) > str(1):
        lista.append(str(e))
for e in eu:
    if e[1] == max(lista):
        orszag=e[0]

        
print("7.feladat:Legutoljára csatlakozott ország: {}".format(orszag))

#8
lista=[]
for e in evek:
    if str(e[0:4]) > str(1):
        lista.append(e[0:4])
    
a=0
for e in lista:
    if e == "1995":
       a += 1
b=0
for e in lista:
    if e == "1958":
        b += 1
c=0
for e in lista:
    if e == "2007":
        c += 1
d=0
for e in lista:
    if e == "2004":
        d += 1

f=0
for e in lista:
    if e == "1973":
        f += 1
g=0
for e in lista:
    if e == "1981":
        g += 1
j=0
for e in lista:
    if e == "2013":
        j += 1
k=0
for e in lista:
    if e == "1986":
        k += 1

print("""8. feladat: Statisztika:
      1995 - {} ország
      1958 - {} ország
      2007 - {} ország
      2004 - {} ország
      1973 - {} ország
      1981 - {} ország
      2013 - {} ország
      1986 - {} ország""".format(a,b,c,d,f,g,j,k))





            
