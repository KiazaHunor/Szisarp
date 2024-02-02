f=open("felfedezesek.csv")
elemek=[]

for e in f:
    elemek.append(e.replace("\n","").split(";"))
f.close()


elemek.pop(0)



print("3.feladat:Elemek száma:{}".format(len(elemek)))

okor=[e for e in elemek if e[0]=="Ókor"]


print("4.feladat:Felfedezések száma az ókorban:{}".format(len(okor)))

#print("a")
while True:
    vegyjel=input("5.feladat:Kerek egy vegyjelet:")
    if len(vegyjel)<3 and len(vegyjel)>0:
        jo=True
        for i in range(len(vegyjel)):
            if not(vegyjel[i]>="a" and vegyjel[i]<="z"):
                jo=False

        if jo:
            break

kereset=[e for e in elemek if e[2].lower()==vegyjel]
if kereset==[]:
    print("Nincs ilyen")
print(kereset)
