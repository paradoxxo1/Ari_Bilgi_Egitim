# print("""Mehmet bu 
#       gün hava çok sıcak""")
# print("Yarın Yağmur\n Yağacak\n sağanak")
# #\n bir alt satıra at \t 7karakter boş bırakarak içeri
# #kaydır
# print("Yarın\t çaylar\t bizden ")
# print('Ali\'rıza ders Gelmedi')
mesaj="ahmet mehmet"
print(mesaj[2])
print(mesaj[0:3])
print(mesaj[::2])
print(mesaj.capitalize())#ilk harf büyük
print(mesaj.upper())#tamamı büyük harf
print(mesaj.lower())#tamamı küçük harf
print(mesaj.startswith("ahm"))#başlangıç harfini kelime kontrol ediyor
#doğru varsa True=1 False=0 
print(mesaj.endswith("at"))#son kısmında
mesaj2="Hasan Hüseyin"
birlesim=mesaj+mesaj2
print(birlesim)
varmi="met" in mesaj
print(varmi)
kactane=mesaj.count("m")
print(kactane)
print(mesaj.find("met"))



