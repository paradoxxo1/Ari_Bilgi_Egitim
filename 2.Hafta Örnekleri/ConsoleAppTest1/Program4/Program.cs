using System;

Console.WriteLine("How ur Feat ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What's your Weight ");
double height = Convert.ToDouble(Console.ReadLine());


double index = weight / (height * height);

if (index < 18.5)
{
    Console.WriteLine("Not Bad");
}
else if (index >= 18.5 && index < 24.9)
{
    Console.WriteLine("Normal");
}
else if (index >= 24.9 && index < 29.9)
{
    Console.WriteLine("That's More");
}
else if (index >= 29.9 && index < 34.9)
{
    Console.WriteLine("So Much");
}
else
{
    Console.WriteLine("Serious");
}
