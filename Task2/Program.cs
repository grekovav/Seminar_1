﻿// 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
if(number1 > number2)
{
    Console.WriteLine($"Число {number1} большее.");
    Console.WriteLine($"Число {number2} меньшее.");
}
else
{
    Console.WriteLine($"Число {number1} меньшее.");
    Console.WriteLine($"Число {number2} большее.");
}
