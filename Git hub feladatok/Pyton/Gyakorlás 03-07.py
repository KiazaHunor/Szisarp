def oszlopVissza(hanyadik):
    oszlop=[]
    for e in tabla:
        oszlop.append(e[hanyadik-1])
    return oszlop

def t(hanyadik):
    oszlop=[e[hanyadik-1::hanyadik]for e in tabla]
    return oszlop
























    

#oszlop=[e[1::2] for e in tabla]:
        
    
gyumolcsok=["alma","banán","barack","dio","dragonfruit","licsi"]

print("Ennyi gyümölcs van: {}".format(len(gyumolcsok)))

print(gyumolcsok[2])

#gyumolcsok[3]+="s"
#gyumolcsok[3]="barack"

print(gyumolcsok.index("barack"))
#gyumolcsok[gyumolcsok.index("barack")]+="k"
index=gyumolcsok.index("barack")
gyumolcsok[index]+="k"

print(gyumolcsok[2])


print("rövid gyümölcsök")


#for i in range(len(gyumolcsok)):
#    if len(gyumolcsok[i])<5:
#        print(gyumolcsok[i])
    
rovid=[]
for i in range((len(gyumolcsok))):
               if len(gyumolcsok[i])<5:
                   rovid.append(gyumolcsok[i])
print(rovid)


rovid=[]
for e in gyumolcsok:
    if len(e)<5:
        rovid.append(e)
print(rovid)


rovid=[e for e in gyumolcsok if len(e)<5]
print(rovid)




#while e in gyumolcsok:
#    if len(e)<5:
#        rovid.append(e)
#print(rovid)

rovid=[]
i=0
while i<len(gyumolcsok):
    if len(gyumolcsok[i])<5:
        rovid.append(gyumolcsok[i])
    i+=1
print(rovid)




rovid=[]
i=0
while True:
    print(i)
    if len(gyumolcsok[i])<5:
        rovid.append(gyumolcsok[i])
        
    if len(gyumolcsok)-1==i:
        break
    i+=1
    
print(gyumolcsok[:3])
print(gyumolcsok[-2:])
print(gyumolcsok[:-2])
print(gyumolcsok[len(gyumolcsok)-2:])

print(gyumolcsok[1:-1])

paratlan=gyumolcsok[1::2]
paros=gyumolcsok[::2]
print(paratlan)
print(paros)


masolat=gyumolcsok
print(masolat)
masolat.reverse()
print(masolat)


print(", ".join(masolat))
print(", ".join(masolat[::-1]))




tabla=[]
for i in range(20):
    sor=[]
    for k in range(10):
        sor.append((i+1)*(k+1))
    tabla.append(sor)
print(tabla)    


oszlop=[]
for e in tabla:
    oszlop.append(e[0])
#print(oszlop)
#print(oszlopVissza(5))
#print(oszlopVissza(10))


oszlop=[e[:3] for e in tabla]
oszlop=[e[4:7] for e in tabla]



oszlop=[e[1::2] for e in tabla]
oszlop=[e[3::4] for e in tabla]
print(oszlop)
#függvény ami megadja hogy hánnyal osztható oszlopokat adja vissza
#bekérés bekér egy számot és az "annyival" oszhato számokat íratja ki

#print(t(int(input("Kérek egy számot:"))))
        
oszlop=[[e[2],e[6],e[0]] for e in tabla]

print(oszlop)

