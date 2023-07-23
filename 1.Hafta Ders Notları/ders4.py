notu=float(input("Sınav Notunuz Girin"))
#0 > and  <= 20 kaldı
#>20 and <=45  geçer
#>45 and <=65 orta
#>65 and <=85 iyi
#>85 and <=100 çokiyi
#geçersiz not 
# if notu>=50: ctrl+k+c açıklamaypar ctrl+k+u açıklamayı kaldırır
#     print("Geçti")
# else:
#     print("Kaldı")
if notu>0 and notu<=20:
    print("Kaldı")
elif notu>20 and notu<=40:
    print("geçer")
elif notu>40 and notu<=65:
    print("orta")
elif notu>65 and notu<=85:
    print("iyi")
elif notu>85 and notu<=100:
    print("Çokiyi")
else:
    print("Geçersiz not")

