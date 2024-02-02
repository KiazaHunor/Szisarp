nev= input("Kérek egy nevet:")

print("A " + nev + " nevet írtad be.")

print("A {belsoNev} nevet írtad be.".format(belsoNev=nev))

if len(nev)<5:
    print("Jó rövid név.")
elif len(nev)>=10:
    print("Veri big név.")


