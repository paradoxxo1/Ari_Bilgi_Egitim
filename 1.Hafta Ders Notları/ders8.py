# + toplama - çıkarma * çarpma
# / böle % mod alma(sonucu sıfır )** kendisi
toplam=0
tek=0
for i in range(1,101):
    if i%2==0:
       toplam=toplam+i
    else:
        tek=tek+i
 
print(f"Çift:{toplam} Tek{tek}")
