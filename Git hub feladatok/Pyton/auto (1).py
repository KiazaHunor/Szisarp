class auto:
    szin,marka,tipus,ajtoszam=["","","",0]
    def __init__(self,szin,marka,tipus,ajtoszam):
        self.szin=szin
        self.marka=szin
        self.tipus=tipus
        self.ajtoszam=ajtoszam

    def indul(self):
        print("BRR")

    def duda(self):
        print("tü tü")

    def iranyjel(self):
        print("Tuk-Tuk")


   
        
k1=auto("piros","lada","1300",3)
        
k1.indul()
k1.duda()
k1.iranyjel()

print("--------------------------------------")
class bmw:
    szin,tipus,ajtoszam=["","",0]
    def __init__(self,szin,tipus,ajtoszam):
        self.szin=szin
        self.tipus=tipus
        self.ajtoszam=ajtoszam

    def indul(self):
        print("beum-brum")

    def duda(self):
        print("Max")

    def iranyjel(self):
        print("Nemis volt")
    
k2=bmw("fekete","E99",3)
k2.indul()
k2.duda()
k2.iranyjel()

print("--------------------------------------")

class dinnyes:
    szin,tipus,ajtoszam=["","",0]
    def __init__(self,szin,tipus,ajtoszam):
        self.szin=szin
        self.tipus=tipus
        self.ajtoszam=ajtoszam

    def indul(self):
        print("duppla kupp")

    def duda(self):
        print("none")

    def iranyjel(self):
        print("Néha van")
    
k3=dinnyes("szürke","Merga",5)
k3.indul()
k3.duda()
k3.iranyjel()

print("--------------------------------------")

class dinnyes:
    szin,tipus,ajtoszam=["","",0]
    def __init__(self,szin,tipus,ajtoszam):
        self.szin=szin
        self.tipus=tipus
        self.ajtoszam=ajtoszam

    def indul(self):
        print("Fullos")

    def duda(self):
        print("XD")

    def iranyjel(self):
        print("Mint egy swift")
    
k4=dinnyes("Babakék","Q1",2)
k4.indul()
k4.duda()
k4.iranyjel()
