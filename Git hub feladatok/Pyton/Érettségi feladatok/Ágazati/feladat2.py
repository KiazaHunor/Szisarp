import haromszopg

def ujabb(darab=3):
    haromszogek=[]
    for i in range(darab):
        haromszogek.append(haromszopg.haromszopg())

    for e in haromszogek:
        print("\ta={}, b={}, c={}".format(e[0],e[1],e[2]))
    return haromszogek
                                                                


def haromszogE(haromszogek):
    for e in haromszogek:
        if sum(e)-max(e)>max(e):
            print("Lehet háromszög")
        else:
            print("Nem lehet harömszög")



h=ujabb(3)
haromszogE(h)
#lista=haromszopg.haromszopg()
#print(lista)
