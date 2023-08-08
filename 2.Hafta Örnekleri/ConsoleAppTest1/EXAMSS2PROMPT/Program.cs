
int sonuc = 0;
int sayi = 1;
for (int i = 1; i <= 101; i++)
{
    sonuc = sonuc + (sayi * sayi * sayi);
    
    sayi++;
}
Console.WriteLine(sonuc);
