#function  void  function function def
def isim(ad,soyad):
    print(f"Kişin Adı {ad} Soyadı {soyad}")
    
def selamla():
    print("Merhabalar")

# selamla()
# isim("Toprak","Erdoğan")

def kdv_hesap(fiyat,oran):
    sonuc=(fiyat*oran)/100
    print(sonuc)
    
def indirim (fiyat,oran):
    sonuc=(fiyat*oran)/100
    sonuc2=fiyat-sonuc
    print(sonuc2)
    
def bilet(a,b):
    return a*b

sonuc3=bilet(10,5)
print(sonuc3)
#indirim fiyat oran  fiyat*oran çarp çıkan sonuctan 
#fiyat-sonuc  kalan sonucu ekrana yazdır
kdv_hesap(1200,20)
kdv_hesap(1500,12)
yeni=input()


