import random
#Ez a fv. beker egy szót,és annak jelentését.
#Visszaad:a két bekérés listában
def szoBeker():
    szo=input("Kérek egy szót: ")
    if szo=="":
        jelentes=""
    else:
        jelentes=input(szo+ "Jelentése: ")
    return [szo,jelentes]


szavak=[]
def sokBeker():
    szo=szoBeker()
    while szo[0]!="":
        szavak.append(szo)
        szo=szoBeker()
    return szavak
    


def filebaIr(lista):
    f=open("szotar.txt","a")

    for e in lista:
        #print(e)
        f.write(" ".join(e))
        f.write("\n")
    f.close()



kerdesek=[]
def beolvas():
    f=open("szotar.txt","r")
    for sor in f:
        #bike bicikli
        kerdesek.append(sor.replace("\n","").split(" "))
    f.close()
    
def kerdez():
    #Jó válasz
    valasztott=random.choice(kerdesek)
    
    #print("valasztott",valasztott)
    
    rossz=[]
    for i in range(3):
        temp=random.choice(kerdesek)
        #print("temp",temp)
        #Ez teljesen rossz!
        while not (temp not in rossz and temp!=valasztott):
            temp=random.choice(kerdesek)
            
        rossz.append(temp)
        #print("rossz",rossz)

    print("-"*60)
    print("Mit jelent:"+valasztott[0]+"?")

    rossz.append(valasztott)
    
   
    #válasz bekérés
    abc="abcdefghijklmnopqrstuvxyz"
    random.shuffle(rossz)

    i=0
    for e in rossz:
        print(abc[i]+": "+e[1])
        i+=1

        
    valasz=input("Válassz: ")

    hol=4
    while hol>=4:
        try:
            if valasz!="":
                    hol=abc.index(valasz)
            
        except:
             valasz=input("Válassz újra:")
        else:
            if hol>=4:
                valasz=input("Válassz újra:")
            


    #if valasztott[0]==rossz[hol][0]:
        #print("Helyes ")
    #else:
        #print("rossz válasz")


    return valasztott[0]==rossz[hol][0]












def menu():
    beker=""

    while beker!="0":
    
        print("€"*40)
        print("Szótár program\n")
        print("1: Szavak bevitele")
        print("2: Feleltetés")
        print("0: Kilépés")
        beker=input("Válassz")


        if beker=="1":
            #adatbekérés
            szavak=sokBeker()
            filebaIr(szavak)

        elif beker=="2":
            #feleltetés
            beolvas()
            lil_A=[]
            for i in range(10):
                lil_A.append(kerdez())


            print("Az eredmény:{:.0%}".format(lil_A.count(True)/len(lil_A)))
                
            
    
    

menu()      
        
    








#adatbekérés
#szavak=sokBeker()
#filebaIr(szavak)
