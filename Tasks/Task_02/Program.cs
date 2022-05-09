//  Напишите программу, которая принимает на
//  вход три числа и выдаёт максимальное из этих чисел.

Console.Write("введите число 1 =>");
int num1 = int.Parse(Console.ReadLine());
Console.Write("введите число 2 =>");
int num2 = int.Parse(Console.ReadLine());
Console.Write("введите число 3 =>");
int num3 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
  if (num1 > num3)
    {
        Console.WriteLine("Максимальное число " + num1);
    }
   else 
   {
     Console.WriteLine("Максимальное число " + num3);
   }
}
else
{
   if (num2 > num3)
   {
      Console.WriteLine("Максимальное число " + num2); 
   }
   else
   {
       Console.WriteLine("Максимальное число " + num3);
   }
}
