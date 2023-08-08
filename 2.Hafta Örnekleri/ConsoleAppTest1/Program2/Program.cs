
//Klavyeden giilen 3 sayı ortalamasını yapan program
Console.WriteLine("1 sayıyı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 sayıyı giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3 sayıyı giriniz: ");
int sayi3 = Convert.ToInt32(Console.ReadLine());

int ortalama = Convert.ToInt32((sayi1+sayi2+sayi3)/3);

if (ortalama <=50)
{
    Console.WriteLine(ortalama);
}
else
{
    Console.WriteLine("Hatalı giriş!!");
}