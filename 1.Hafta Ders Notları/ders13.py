sayilar=[1,2,3,4,5,6]
print(max(sayilar))
print(min(sayilar))
print(sum(sayilar))
print(1 in sayilar)
meyveler=["Elma","Kivi","Karpuz","Kavun"]
meyveler.reverse()
for i in meyveler:
    print(i)
for i in range(len(meyveler)):
    print(meyveler[i])
#dizileri string çevirme
#split bölmek araya ifade göre dizi çevir
cevir=",".join(meyveler)
print(cevir)
arabalar="Bmw,Honda,Citiroen,Mazda"
listem=arabalar.split(",")
print(listem)