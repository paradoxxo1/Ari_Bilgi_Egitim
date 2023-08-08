

//Fonksiyon kullanımı örnekleri

//void yazdir()
//{
//    Console.WriteLine("Hello Bitch");
//}

//void selamla(string ad)
//{
//    Console.WriteLine($"Welcome {ad}");
//}




//int hesapla(int sayi, int sayi2)
//    {
//        return sayi + sayi2;
//    }

//yazdir();
//selamla("Mahmut");
//int toplam = hesapla(10, 30);
//Console.WriteLine(toplam);


//dizilerle döngüler


//int[] sayi = new int[] { 10, 20, 30, 40, 50 };
//Console.WriteLine(sayi[1]);

//for (int i = 0; i < sayi.Length; i++)
//{
//    Console.WriteLine(sayi[i]);
//}
//Console.WriteLine(sayi.Length);

//foreach (int i in sayi)
//{ Console.WriteLine(i); }


//string[] ad = new string[5];
//ad[0] = "A";
//ad[1] = "B";
//ad[2] = "C";
//ad[3] = "D";
//ad[4] = "E";
//foreach (string s in ad)
//{
//    Console.WriteLine(s);
//}

//int[,] a = new int[3, 4]
//{
//    {0,1,2,3},{4,5,6,7 },{8,9,10,11 }};

//Console.WriteLine(a[0, 3]);
//Console.WriteLine(a[1, 0]);



//string ad = "Mahmut";
//string ad2 = "Mehmet";
//Console.WriteLine(ad.ToUpper());
//Console.WriteLine(ad.ToLower());

//if (string.Compare(ad,ad2)==0)
//{
//    Console.WriteLine("İki Değer Eşit");
//}
//else
//{
//    Console.WriteLine("İki değer eşit değil");
//}

using System.Globalization;

Console.WriteLine("hava sıcak");
string ad = "yarın çok sıcak";
if(ad.Contains("sıcak" ))
    {
    Console.WriteLine("Aynı kelime var");
}
else
{
    Console.WriteLine("Aynı kelime yok");
}
string[] diziler = new string[] { "kemal", "cemal", "beste" ,"nigar","mahmut"};
string alan = ad.Substring(0, 10);
Console.WriteLine(alan);
string birlesim = String.Join("-", diziler);
Console.WriteLine(birlesim);