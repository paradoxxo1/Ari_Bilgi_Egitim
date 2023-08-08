// See https://aka.ms/new-console-template for more information


Console.WriteLine("Fiyat Giriniz: ");
int fiyat=Convert.ToInt32(Console.ReadLine());
double kdv = Convert.ToDouble((fiyat*18)/100);

Console.WriteLine(kdv);




1'den 100'e kadar olan sayılarının küplerinin toplamını bulan