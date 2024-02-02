# 1.Feladat
#a = 0
#while a < 8:
 # a + 1
 ## if a == [1 or 2 or 3 or 4 or 5 or 6 or 7 or 8]:
 #     print(a)
 

#1.Feladat
#lista = []
#for i in range(8):
#    szam=int(input("Kérek egy számot:"))
#    lista.append(szam)
#print(lista)

#4.Feladat
#sum = sum(lisat)
#print(sum)



#szam=""
#int(input("Kérek egy számot:"))
#while szam < 8:
#  int(input("Kérek egy számot:"))

      
#lista1 = [1,2,3,4,5,6,7,8 ]
#for i in range(len(lista1)):
#   print(lista1)


#10.Feladat
#szam=""
#def szam():
#   print()
#szam()

#def szam():
#   print(  +  ):

#szam( )

#5.Feladat





 

#5.Feladat
#szoveg=["Nulla quis mi augue. Nunc vel pretium lectus. Aenean laoreet ornare ornare. Ut vitae elit et sapien fringilla iaculis ac at felis. Aenean scelerisque, diam non pellentesque rhoncus, risus lorem porttitor leo, ac consectetur nisi massa vitae sem. Nulla tempus diam id bibendum lobortis. Vestibulum porta neque id risus cursus, eget sodales nunc fermentum. Nulla facilisi. Suspendisse egestas orci a luctus fringilla. Cras dapibus ipsum nisl, non dapibus ex fermentum vitae."]
#print(szoveg)




#1. feladat: Kérj be 10 számot egy megfelelő adatszerkezetbe!
szamok=[]
for i in range(10):
  szamok.append(int(input(str(i+1)+". szamok")))
#szamok=[1,2,3,4,5,6,7,8,9,10] 
#2. feladat a bekért számokat írasd ki egymás mellé!

for i in szamok:
  print(str(i),end="")
print()
print ("Vége")
  
#Másik megoldás
#print("".join(szamok))

#3.Feladat: A bekért számot írasd ki 2 oszlopba!

for i in range(10):
  print(str(szamok[i])+"\t",end="")
  if i%3==2:
    print()



print()

#4. Feladat: Számold ki a bekért számok átlagát!
atlag=sum(szamok)/len(szamok)
print(atlag)

osszeg=0
for i in szamok:
    osszeg+=i
    #osszeg=osszeg+1
atlag=osszeg/len(szamok)
print(atlag)



#5. Feladat
szoveg="Integer eget pharetra magna. Nulla ex urna, congue ac tincidunt ut, interdum et metus. Phasellus nunc nunc, consectetur eu odio vitae, ullamcorper sagittis nisi. Ut quam tortor, tempus sit amet diam nec, auctor iaculis leo. Donec ut libero velit. Maecenas nisi magna, congue ut tortor quis, maximus maximus arcu. Mauris et commodo nibh. Fusce id est vehicula, consectetur mi et, molestie sapien."


#6. Feladat
#7. Feladat 
betu="qwe"
while betu!="":
  betu=input("Kérek egy betűt:")
  szoveg=szoveg.replace(betu,betu.upper())

  print(szoveg)

#8. Feladat
lista=szoveg.split("")
lista.reverse()
szoveg2="".join(lista)
print(szoveg2)

#print("adw"*5)
#9. Feladat :Az eltárolt szövegből töröld az összes írásjelet!
jelek="'.!?-:;,"

for i in range(len(jelek)):
  szoveg=szoveg.replace(jelek[i],"")
print(szoveg)



