def oszlopba(munkalista,db):
    for i in range(len(munkalista)):
        print(munkalista[i],end=" ")
        if i%db==2:
            print()
print()
    




lista=[]
for i in range(0):
    lista.append(int(input("Kérek egy számot:")))
lista=[0,1,2,3,4,5,6,7,8,9]
print(lista)

for i in range(len(lista)):
    print(lista[i],end=" ")
    if i%3==2:
        print()


print()
szamBe=int(input("Kérek egy számot:"))
if szamBe in lista:
    print("Vann benne")
else:
    print("Nincs benne")



oszlopba(lista,5)
