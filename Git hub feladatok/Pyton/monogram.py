# Import the required libraries
from tkinter import *
import math

class forgato:
    canvas=0
    vonalak=[]
    szog=0
    szogsebesseg=0.05
    szinek=[]
    elmozgato=[]
    
    def __init__(self,canvas,vonalak,elmozgato):
        self.canvas=canvas
        self.vonalak=vonalak
        self.elmozgato=elmozgato
        
        for i,betu in enumerate(self.vonalak):
            betu+=betu[:2]
            betu=self.nagyit(betu,1)
            self.vonalak[i]=self.eltol(betu,200,200)


        self.kozepszamol()


        

    def rajzol(self):
        canvas.delete("all")
        self.szog+=self.szogsebesseg

        
        for i,betu in enumerate(self.vonalak):
            #origóba tol
            betu=self.eltol(betu,-self.kozep[0],-self.kozep[1])
            #elforgat
            betu=self.forgat(betu,self.szog)
            #helyére visszatol
            betu=self.eltol(betu,self.kozep[0],self.kozep[1])
    
            self.canvas.create_line(betu, fill=self.szinek[i], width=5)
            
    def eltol(self,pontok, x, y):
        vissza = []
        for e, pont in enumerate(pontok):
            if e % 2 == 0:
                vissza.append(pont + x)
            else:
                vissza.append(pont + y)
        return vissza

    def nagyit(self,pontok, meret = 1):
        vissza = []
        for e in pontok:
                vissza.append(e * meret)
        return vissza

    def forgat(self,pontok, szog):
        vissza = []
        for i, pont in enumerate(pontok):
            if i % 2 == 0:
                szogRadian=math.radians(szog)
                x = pontok[i]*math.cos(szogRadian) - pontok[i+1]*math.sin(szogRadian)
                y=pontok[i]*math.sin(szogRadian)+pontok[i+1]*math.cos(szogRadian)

                vissza.append(x)
                vissza.append(y)
        return vissza

    def kozepszamol(self):
        self.kozep=[0,0]
        db=0
        for betu in self.vonalak:
            xK=betu[::2]
            yK=betu[1::2]
            self.kozep[0]+=sum(xK)
            self.kozep[1]+=sum(yK)
            db+=len(xK)
            
        self.kozep[0]/=db
        self.kozep[1]/=db


# Új

    def elmozgat(self,vonalak,pontok):
        M = [10,10,30,10,90,60,150,10,170,10,170,170,150,170,150,30,90,80,30,30,30,170,10,170,10,10]
        A1 = [180,170,200,170,220,130,300,130,320,170,340,170,270,10,250,10,180,170]
        A2 = [230,110,290,110,260,30,230,110]
        T = [350,10,510,10,510,30,440,30,440,170,420,170,420,30,350,30,350,10]
        Y = [520,10,540,10,610,70,680,10,700,10,620,82,620,170,600,170,600,82,520,10]
        I = [710,10,730,10,730,170,710,170,710,10]

        elmozog=[]
        M.append(elmozog)
        A1.append(elmozog)
        A2.append(elmozog)
        T.append(elmozog)
        Y.append(elmozog)
        I.append(elmozog)

        for i in elmozgato:
            if elmozgato[i]:
                pass

        self.kozep=[0,0]
        db=0
        for i in elmozgato:
            xK=i[::2]
            yK=i[1::2]
            self.kozep[0]+=sum(xK)
            self.kozep[1]+=sum(yK)
            db+=len(xK)
            
        self.elmozgato[0]/=db
        self.elmozgato[1]/=db

            



        
        #self.vonalak
        
        #for e, pont in enumerate(vonalak):
            #if e % 6 == 0:
                #vissza.append(pont + x)
            #else:
                #vissza.append(pont + y)
        #return vissza
        









        
# Create an instance of tkinter frame or window
win=Tk()
win.egerStart=[0,0]
win.egerPos=[0,0]

# Set the size of the tkinter window
win.geometry("900x600")

# Create a canvas widget
canvas=Canvas(win, width=600, height=600)
canvas.configure(bg="lightgray")
canvas.pack(fill = BOTH, expand = 1)

# Add a line in canvas widget

M = [10,10,30,10,90,60,150,10,170,10,170,170,150,170,150,30,90,80,30,30,30,170,10,170,10,10]
A1 = [180,170,200,170,220,130,300,130,320,170,340,170,270,10,250,10,180,170]
A2 = [230,110,290,110,260,30,230,110]
T = [350,10,510,10,510,30,440,30,440,170,420,170,420,30,350,30,350,10]
Y = [520,10,540,10,610,70,680,10,700,10,620,82,620,170,600,170,600,82,520,10]
I = [710,10,730,10,730,170,710,170,710,10]

MATYI = [#M
        [10,10,30,10,90,60,150,10,170,10,170,170,150,170,150,30,90,80,30,30,30,170,10,170,10,10],
        #A
        [180,170,200,170,220,130,300,130,320,170,340,170,270,10,250,10,180,170],
        [230,110,290,110,260,30,230,110],
        #T
        [350,10,510,10,510,30,440,30,440,170,420,170,420,30,350,30,350,10],
        #Y
        [520,10,540,10,610,70,680,10,700,10,620,82,620,170,600,170,600,82,520,10],
        #I
        [710,10,730,10,730,170,710,170,710,10]]




elso=forgato(canvas,MATYI)
elso.szinek=["blue","green","red","yellow","green","blue"]







szog=0
while True:
    elso.rajzol()
    win.update_idletasks()
    win.update()
    

    #win.mainloop()

