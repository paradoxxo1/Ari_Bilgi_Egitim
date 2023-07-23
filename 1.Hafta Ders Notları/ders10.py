liste=['ahmet','Mehmet','Hasan','Hüseyin']
print(liste[1])
sayilar=[1,2,3,4,5]
print(sayilar[4])
print(len(sayilar))
print(len(liste))
for i in range(len(sayilar)):
    print(sayilar[i])

#foreach
for i in liste:
    print(i)

for x in sayilar:
    print(x)
#enumarate
for i, item in enumerate(liste):
    print(f"Liste Numarası {i} Liste Değeri{item}")

s="Muhammet"
print(s[3])

birlestir=sayilar+liste
print(birlestir)
coklu=[1,2,3,[4,5,6]]
print(coklu[3][0])
cboyutlu=[[1,2,3],[4,5,6],[7,8,9]]
print(cboyutlu[2][1])
