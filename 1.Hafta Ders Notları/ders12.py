a="Ramazan"
b="Şaban"
print("Bu yıl nisan ayında {} gelmiştir birsonraki ay{}".format(a,b))
print(f"Önceki Ay{a} sonraki ay{b}")
meyveler=["Elma","Armut","Kivi","Karpuz","Kavun"]
print(meyveler)
print(meyveler[2])
print(len(meyveler))#liste içindeki eleman sayısı veriyordu
print(meyveler[1:3])
print(meyveler[::2])
meyveler[1]="Çilek"
print(meyveler)
#append sonuna ekleme
#insert araya değer girme
#remove silme
#pop silme
#reverse
# print(meyveler.append("Muz"))
# print(meyveler)
# print(meyveler.remove("Kivi"))
# print(meyveler.pop(1))
# print(meyveler)
print(meyveler.reverse())
print(meyveler)
print(meyveler.sort(reverse=True))
print(meyveler)

