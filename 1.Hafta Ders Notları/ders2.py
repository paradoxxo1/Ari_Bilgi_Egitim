ad=input("Adınızı Girin :")
soyad=input("Soyadınız Girin :")
print("Kişinin Adı",ad)
print("Kişinin Soyadı", soyad)
# > buyuk < kucuk <= ke  >= be ==eşit != eşit deği <> eşit değil
# and ve  or veya demek and ifadesi iki veya daha fazla tutarlı or ise herhangi tutması
if ad=="admin" and soyad=="yetkili":
    print("Giriş Başarılı")
else:
    print("Giriş Başarısız")