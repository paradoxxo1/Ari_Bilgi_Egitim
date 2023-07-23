# para 
# Normal için 1 Öğrenci 2 seçiniz
# Kontür sayısını girin 
#
para=float(input("Paranızı girin:"))
tipi=int(input("Normal 1 (10TL) Öğrenci 2 (5TL) Girin:"))
kontur=int(input("Kontür Giriniz:"))
if tipi==1:
    ucret=kontur*10
elif tipi==2:
    ucret=kontur*5
else:
    print("Geçersiz Seçim")

kalan=para-ucret
if kalan<0:
    print("Yetersiz Bakiye")
else:
    print("Kalan Bakiye",kalan)



    
