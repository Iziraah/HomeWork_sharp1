﻿//Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("введите число 1 =>");
int num1 = int.Parse(Console.ReadLine());
Console.Write("введите число 2 =>");
int num2 = int.Parse(Console.ReadLine());
if (num1 < num2)
{
    Console.WriteLine("Большее число " + num2);
    Console.WriteLine("Меньшее число " + num1);
}
else
{
    Console.WriteLine("Большее число " + num1);
    Console.WriteLine("Меньшее число " + num2);
}