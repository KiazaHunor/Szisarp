import random
import math

f=[]
for i in range(4):
    print(f)

minimumErtek=int(input("Add meg hol kezdődjön:"))
maximumErtek=int(input("Add meg hol végződjön:"))
darab=int(input("Add meg hány számot szeretne:"))

lista=[]
for i in range(darab):
    lista.append(random.randint(minimumErtek,maximumErtek))
print(lista  )
    
print("Nice try dumbass")

legnagyobb=max(lista)
egyseg=80//legnagyobb
for e in lista:
    print("*"*math.floor(e*egyseg))


#3 jegyű szám bekérés
    
szam="12"
while len(szam)!=3:
    szam=input("Kérek egy 3 jegyű számot:")
szam=int(szam)
if szam%12==0:
    print("oszt6ó")

    
print(szam)


szoveg="lestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat."
print(len(szoveg.split(" ")))
betu=""
szoveg2=szoveg.replace(betu.upper())
print(szoveg2)
