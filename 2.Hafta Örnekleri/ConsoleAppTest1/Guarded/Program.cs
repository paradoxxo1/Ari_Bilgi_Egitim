// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("Bir Araç Türü Seçin:\n" +
               "1-Taksi İçin Fiyat 5TL\n" +
               "2-Minübüs İçin Fiyat 6TL\n" +
               "3-Ticari İçin Fiyat 6,5TL");
int secim = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Saati Seçiniz");
double saat=Convert.ToDouble(Console.ReadLine());
double fiyat = 0;
if (secim==1)
{
    fiyat = saat <= 1 ? saat * 5 : 5 + (saat - 1) * 5 * 1.2;

}
else if (secim == 2)
{

    fiyat = saat <= 1 ? saat * 6 : 6 + (saat - 1) * 6 * 1.215;
}
else if (secim == 3)
{

    fiyat = saat <= 1 ? saat * 6.5 : 6.5 + (saat - 1) * 6.5 * 1.25;
}

Console.WriteLine(saat + " Saat Durdunuz " + $"Ödenecek Tutar {fiyat} "  );

