﻿// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"
Console.Clear();
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine()!);
int i = - number;
while(i <= number)
{
    Console.Write(i + " ");
    i = i + 1;
}