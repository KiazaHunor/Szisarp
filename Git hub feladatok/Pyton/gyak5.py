def szamszo ():
    l=[]
    l.append(int(input("kerek egy szamot: ")))
    l.append(input("szo: "))
    return l



lista=[]
for i in range(10):
    lista.append(int(input("kerem a szamot")))
print(lista)
for i in range(len(lista)):
    print(lista[i],end="\t")
    if i % 2 ==1:
        print()

b=0
b = sum( lista ) / len( lista )
print(b)

betu=None
l= "Integer eget pharetra magna. Nulla ex urna, congue ac tincidunt ut, interdum et metus. Phasellus nunc nunc, consectetur eu odio vitae, ullamcorper sagittis nisi. Ut quam tortor, tempus sit amet diam nec, auctor iaculis leo. Donec ut libero velit. Maecenas nisi magna, congue ut tortor quis, maximus maximus arcu. Mauris et commodo nibh. Fusce id est vehicula, consectetur mi et, molestie sapien."
while betu != "":
    betu = input("betu: ")
    l=l.replace(betu , betu.upper())
    print(l)

szavak= l.split()
szavak.reverse()

print(" ".join(szavak))

jelek=[".",":","?","!",","]
for i in jelek:
    l=l.replace(i,"")
print(l)
t=[]
for i in range(2):
    t.append(szamszo())
print(t)

for e in t:
    print(e[0]* (e[1]+" "))
