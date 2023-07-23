import random
print("Taş Makas Oyununa Hoşgeldiniz")
secim=input("Taş Makas Kağıt tan birini yazınız").capitalize()
listem=["Taş","Kağıt","Makas"]
rast=random.randint(0,2)
bilgisayar=listem[rast]
if secim=="Taş" and bilgisayar=="Taş":
    print("Berabere")
elif secim=="Kağıt" and bilgisayar=="Kağıt":
    print("Berabere")
elif secim=="Makas" and bilgisayar=="Makas":
    print("Berabere")
elif secim=="Makas" and bilgisayar=="Taş":
    print("Bilgisayar Kazanır")
elif secim=="Kağıt" and bilgisayar=="Taş":
    print("Kullanıcı Kazanır")
elif secim=="Makas" and bilgisayar=="Kağıt":
    print("Kullanıcı Kazanır")
else:
    print("Hatalı Seçim")