print("1 Feladat")
f=open("jarmu.txt")



    
print("2 Feladat")
munkaido=[]
for e in f:
    munkaido.append(e.split(" "))



for e in munkaido:
    if e[0]==str(10):
        print("5.Órát dolgoztak")

print("3 Feladat")

for e in munkaido:
    if e[0]==str(10):
        print(e+"Óra:"+e[3])

        
print("4 Feladat")
B=["Autóbusz"]
K=["Kamion"]
M=["Motor"]
        
for e in munkaido:
    if e[3]==(B)+e[3]:
        print(B)
        
    elif e[3]==K:
        print(K)

    elif e[3]==M:
        print(M)

print("5 Feladat")
        
        
