f=open("lift.txt")
hasznalt=[]

for e in f:
    hasznalt.append(e.replace("\n","").split(" "))

#print(hasznalt)
f.close()
#3
print("3.Feladat: Ennyiszer használták a liftet:{}".format(len(hasznalt)))

#4
ido=[]
for e in hasznalt:
    ido.append(e[0])

print("4.feladat: Ez az idő között volt használva:{}-{}".format(ido[0],ido[-1]))

#5

nagy=[]
for e in hasznalt:
    nagy.append(e[2])

    
print("5.feladat: Legnagyobb célszint:{}".format(max(nagy)))

#6
print("6.feladat:")
kartya=input("kartyaszam:")
cel=input("celszam:")


cel=int(cel)

try:
    kartya=int(kartya)
except:
    kartya = 5
      
try:
    cel=int(cel)
except:
    cel = 5
#print(kartya)
    
