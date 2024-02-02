
class muvelet:
    x=1
    y=1
    def __init__(self,x,y):
        self.x=x
        self.y=y

    def osszeadas(self):
        return self.x+self.y

    def kivonas(self):
        return self.x-self.y

    def szorzas(self):
        return self.x*self.y
    def osztas(self):
        return self.x//self.y
    

if __name__=='__main__':
    #teszteles
    q=muvelet(1,2)
    print(q.osszeadas())#3

    q=muvelet(-10,10)
    print(q.kivonas())#-20

    q=muvelet(4,6)
    print(q.szorzas())

    q=muvelet(8,2)
    print(q.osztas())

    

    
        #self.x-=x
        #self.y-=y
        
