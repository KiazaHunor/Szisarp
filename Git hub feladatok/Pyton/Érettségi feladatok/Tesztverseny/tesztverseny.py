f=open("valaszok.txt")


adatok=f.read().split("\n")[:-1]
#1.megoldás
#adatok.remove("")
#2.megoldás
#adatok=adatok[:-1]



f.close()

print(adatok)

helyes=adatok[0]
adatok.remove(helyes)


valaszok=[]
for e in adatok:
    valaszok.append(e.split(" "))

#print(valaszok)

print("2.feladat: A vetélkedőn "+str(len(valaszok))+" versenyző indult.")

versenyzo=input("3.feladat: A versenyző azonosítója = ")


versenyzoValasza=""
for e in valaszok:
    if e[0]==versenyzo:
        print(e[1]+"\t(a versenyző válasza)")
        versenyzoValasza=e[1]
        
print("{}\t(a versenyző válasza)".format([e[1] for e in valaszok if e[0]==versenyzo] [0]))



print("4.feladat")
print(helyes+"\t(a helyes megoldás)")
print(versenyzoValasza)

for sorszam,betu in enumerate(versenyzoValasza):
    if betu==helyes[sorszam]:
        print("+",end="")
    else:
        print(" ",end="")
print("\t(a versenyző helyes válaszai)")      

