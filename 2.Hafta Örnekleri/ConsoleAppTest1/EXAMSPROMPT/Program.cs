
//EXAMS QUİZ
//Bir dersten 2 sınav yapılacaktır, 2 sınavınm ortalaması 50'den küçükse
//    öğrenci 3.sınava girecektir. Öğrenci 3. sınava girerse, 
//    tekrar 3 sınavın ortalaması hesaplanacaktır.  
//    Ortalama 50'den küçük ise "Başarısız oldunuz", 
//    büyük ise    "Tebrikler, geçtiniz" yazan programı yazınız. 



Console.WriteLine("1.Sınav Notunu Giriniz: ");
double sinav1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("2.Sınav Notunu Giriniz: ");
double sinav2 = Convert.ToDouble(Console.ReadLine());


double ortalama = (sinav1+sinav2)/2;

if (ortalama <50)
{
    Console.Write("!!   *-*-*-*-*-*-*-3.Sınava Girmek Zorundasınız-*-*-*-*-*-*-* !! \n");
    Console.WriteLine("3.Sınav Notunu Giriniz: ");
    double sinav3 = Convert.ToDouble(Console.ReadLine());
    double  ortalama2 = (sinav1 + sinav2+sinav3) / 3; ;
    if (ortalama2 > 50) 
    {
        Console.WriteLine("Tebrikler Geçtiniz");
    }
    else
    {
        Console.WriteLine("Başarısız Oldunuz");
    }
}
else if (ortalama >=50 && ortalama<=100)
{
    Console.WriteLine("Tebrikler Geçtiniz");
}
else
{
    Console.WriteLine("Geçersiz Değer Giridniz");
}