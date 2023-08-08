// See https://aka.ms/new-console-template for more information

double boy, kilo;

Console.WriteLine("Boy Gir: ");
boy = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Kilo Gir ");
kilo = Convert.ToDouble(Console.ReadLine());

boy = boy / 100;
double olcum = kilo / (boy * boy);

if (olcum >= 25 && olcum < 30)
{
    Console.WriteLine("fazla");
}
else if (olcum >= 30 && olcum < 40)
{
    Console.WriteLine("obez");
}
else if (olcum > 40)
{
    Console.WriteLine("morbit");
}
else if (olcum > 0 && olcum < 25)
{
    Console.WriteLine("Normal");
}
else
{
    Console.WriteLine("gecersiz");
}