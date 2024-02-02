import modul
import random

f=open("szavak.txt")
lista=[]
for e in f:
    lista.append(e.replace("\"","").strip())
f.close()

lista=lista[0].split(", ")
                 

szavak=[]

for e in lista:
    szavak.append(modul.szo(e))
#print(szavak)

rejtett=random.choice(szavak)
print(rejtett.szo)


tippek=[]
while True:
    be=input("Kérek egy szót (6 betűs):")
    tippek.append(be)
    if be=="stop":
        break
    
    vissza=rejtett.minta(be)

    print("Az eredmény: {}".format(vissza))
    if vissza==be:
        break
    
if tippek[-1]=="stop":
    pass
else:
    print("{} tippelésseé sikerült kitalálni".format(len(tippek)))
