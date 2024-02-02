#1. Feladat Kérj be 7 számot egy megfelelő adatszerkezetbe!

szamok=[]
for i in range(7):
    szamok.append(int(input("Kérek egy számot:")))
    
#2. Feladat A bekért számokat írasd ki egymás mellé visszafelé!

    
for i in szamok:
    print(str(i)+"\t",end=" ")
print()
#3. Feladat  A bekért számokat írasd ki 5 oszlopba!
for i in range(7):
    print(str(szamok[i])+"\t",end=" ")
    if i%5==0:
        print()

        
print()
#4. Feladat  Számold ki a bekért számok összegét!
osszeg=sum(szamok)
print(osszeg)
#5.Feladat  A mellékelt szöveget tárold el a programodban:
szoveg="Nulla quis mi augue. Nunc vel pretium lectus. Aenean laoreet ornare ornare. Ut vitae elit et sapien fringilla iaculis ac at felis. Aenean scelerisque, diam non pellentesque rhoncus, risus lorem porttitor leo, ac consectetur nisi massa vitae sem. Nulla tempus diam id bibendum lobortis. Vestibulum porta neque id risus cursus, eget sodales nunc fermentum. Nulla facilisi. Suspendisse egestas orci a luctus fringilla. Cras dapibus ipsum nisl, non dapibus ex fermentum vitae."
#6.Feladat  Kérj be egy betűt, és írd ki, hogy hol található meg először az előbbi szövegben!
betu=" "
while betu!="fin":
    betu=input("Kérek egy betüt:")
    print(szoveg.count(betu))


#7.Feladat Ismételd az előzőt "fin" (ez egy szó) végjelig!
beker="Végjelig"
while beker!="":
    beker=input("Írj be valamit")
print("Fin")


#8.Feladat Az eltárolt szöveget írasd ki mondatonként fordított sorrendben 
szoveg="Nulla quis mi augue. Nunc vel pretium lectus. Aenean laoreet ornare ornare. Ut vitae elit et sapien fringilla iaculis ac at felis. Aenean scelerisque, diam non pellentesque rhoncus, risus lorem porttitor leo, ac consectetur nisi massa vitae sem. Nulla tempus diam id bibendum lobortis. Vestibulum porta neque id risus cursus, eget sodales nunc fermentum. Nulla facilisi. Suspendisse egestas orci a luctus fringilla. Cras dapibus ipsum nisl, non dapibus ex fermentum vitae."[::-1]
print(szoveg)

#9.Feladat

szoveg.remove("a","e"," ")
print(str(len(szoveg)))

#10.Feladat



