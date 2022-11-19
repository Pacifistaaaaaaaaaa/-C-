// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Max = {number1} Min = {number2}");
}
else
{
    Console.WriteLine($"Max = {number2} Min = {number1}");
}


Console.WriteLine("Введите первое число");
int number12 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number22 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number32 = Convert.ToInt32(Console.ReadLine());
if (number12 > number22)
if (number12 > number32)
{
    Console.WriteLine($"Максимальное {number12}");
}
if (number22 > number12)
if (number22 > number32)
{
    Console.WriteLine($"Максимальное {number22}");
}
else
{
    Console.WriteLine($"Максимальное {number32}");
}

