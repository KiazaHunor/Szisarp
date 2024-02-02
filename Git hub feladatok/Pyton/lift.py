f=open("lift.txt")

menet=[]
for e in f:
    menet.append(e.replace("\n","").split(" "))
    print(menet)
    


f.close()
