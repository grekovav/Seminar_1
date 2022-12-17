// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Clear();
Console.Write("Введите первое число: ");
int sqr = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number = int.Parse(Console.ReadLine()!);
if(sqr == number * number)
{
    Console.WriteLine($"Число {sqr} является квадратом числа {number}");
}
else
{
    Console.WriteLine($"Число {sqr} не является квадратом числа {number}");
}
