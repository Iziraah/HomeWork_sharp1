
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю
// цифру этого числа.

Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine());
int a = n % 10;

Console.WriteLine(a);