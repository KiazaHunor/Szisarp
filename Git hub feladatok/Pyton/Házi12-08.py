import random
import math

l=[]


for i in range(10):
   l.append(random.randint(1000,9999)*6)



l6=[]
for e in l:
   if e%12==0:
      pass
   elif e%6==0:
      l6.append(e)
   else:
      pass
print(l6)

167
1666
#Hattal osztható de 12vel nem
print(random.randrange(167,1667,2)*6)
#a felső sort osztom 2vel utána szorzom 2 +1
print((random.randint(83,832)*2+1)*6)



szavak=["Alma","Körte","Barack","Banón","Dinnye","Szőlő"]
#
#random.seed(1)
print(szavak[random.randint(0,len(szavak)-1)])
print(random.choice(szavak))

#[["alma",14],["körte",18],[]...]
print("?"*50)
nagylista=[]
for e in szavak:
   kislista=[]
   kislista.append(e)
   kislista.append(random.randint(12,312))
   print(kislista)
   nagylista.append(kislista)

print(nagylista)   

for e in nagylista:
   print(e[0].ljust(4),str(e[1])"Kg")














 #  if int(szam1)//y:
 #     print(int(szam1)/y)






#adat=input()
#szam=int(adat)
#print(szam)
#while szam%6:
 #  if szam %6:
#   quit()
#eredmeny=szam
#print(eredmeny)
