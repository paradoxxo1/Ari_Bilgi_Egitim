Uygulamamız üzerinde 3 adet form bulunmaktadır.

Withdraw işlemi ile sql bağlantısı olan ve müşteri ID bilgisine karşılık gelen kişinin bakiye bilgisi yeterli ise para çekme işlemi yapmamızı sağlıyor. Form kısmında invisible olan date-time bilgisini alarak sql tarafında yapılan işlemleri de İslemGecmisi tablomuza aktarıyor. Bakiyenin yetersiz olma durumunda ise bu işlemde bakiye bilgisi ekrana yazdırılarak çekebileceği miktarı kullanıcıya bildiriyor.

Deposit işleminde sql bağlantısı olan ve müşteri ID bilgisine karşılık gelen kişinin bakiye bilgisi alınarak girilen miktarın bakiyeye eklenip Müşteri.dbo da güncellenmesini sağlıyor. Form kısmında invisible olan date-time bilgisini alarak sql tarafında yapılan işlemleri de İslemGecmisi tablomuza aktarıyor. 

History kısmında ise bulunan 3 ayrı butonda textbox1 e girilen Müsteri_ID değerine karşılık gelen kullanıcının işlemGecmisi tablosundan bilgilerini Datagrid ekranında yazdırmasını sağlıyor. Fakat butonlarda sadece para çekme işlemlerini ya da para yatırma işlemlerini ayrıca görmesi adına da özellikler barındırıyor. 

Müşteri.dbo da bulunan tarih ise müşterinin sisteme kayıt tarihi olup IslemGecmisi.dbo daki tarihler ile ilişkisi yoktur. IslemGecmisi.dbo da normal loglama işlemi yapılmaktadır.


Sql sorgularında tablo verileri aşağıdaki gibidir.

IslemGecmisi.dbo

CREATE TABLE IslemGecmisi (
    Musteri_ID NVARCHAR(50) PRIMARY KEY,
    Islem_ID INT IDENTITY(1,1),
    IslemTarihi DATETIME,
    IslemTipi NVARCHAR(50),
    IslemMiktari INT
);


Müşteri.dbo

CREATE TABLE Musteri (
    Musteri_ID INT PRIMARY KEY,
    Adi NVARCHAR(100),
    Soyadi NVARCHAR(100),
    Yasi INT,
    Cinsiyeti NVARCHAR(10),
    Bakiye INT,
    Tarih DATE
);


