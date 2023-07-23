kisi={1:"Ahmet",2:"Mehmet",3:"Kasım","Meyve":"Muz"}

print(kisi["Meyve"])
kisi.update({2:"Adnan",1:"Yasin"})
print(kisi)
kisi["Çilek"]="Meyvem"
print(kisi)
del kisi["Çilek"]
print(kisi)
for i in kisi:
    print(i)
#anahtar değerleri gelir
for i in kisi:
    print(kisi[i])
#aldığı değer gelir
for i,k in kisi.items():
    print(i,k)
#burada hem anahtarı hemde değeri 