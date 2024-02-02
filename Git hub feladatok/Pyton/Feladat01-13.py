#100.000 születési dátum középiskolás diákoknak.
import random
f=open("datum.txt","w")

ev=[]
hó=[]
nap=[]
datum=ev+hó+nap
for i in range(100): 
    ev=random.randint(2003,2008)
    hó=random.randint(1,12)
    nap=random.randint(1,31)
    if hó == 2:
        nap == 28
    if hó ==1 or 3 or 5 or 7 or 8 or 10 or 12:
        nap == 31
    if hó ==4 or 6 or 9 or 11:
        nap == 30
    szöveg=str(ev)+"." + str(hó)+"." + str(nap) + "\n"
    #print(szöveg)
    


    f.write(szöveg)
f.close()


     

        #(1, 28 or 30 or 31)
 #[31,28,31,30,31,30,31,31,30,31,30,31]



def fuggveny():
    ev=[]
hó=[]
nap=[]

for i in range(1): 
    ev=random.randint(2003,2008)
    hó=random.randint(1,12)
    nap=random.randint(1,31)
    if hó == 2:
        nap == 28
    if hó ==1 or 3 or 5 or 7 or 8 or 10 or 12:
        nap == 31
    if hó ==4 or 6 or 9 or 11:
        nap == 30
    szöveg=str(ev)+"." + str(hó)+"." + str(nap) + "\n"
    return szöveg=str(ev)+"." + str(hó)+"." + str(nap) + "\n"  


def fuggveny1():
    for i in range(10):
f=open("datum.txt","w")
        f.write(szöveg)
f.close()
    
    
    
