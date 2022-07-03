// Урок 1. Знакомство с языком программирования С#
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int n1, n2;

Console.Write( "Input First number ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write( "Input Second number ");
n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
     Console.WriteLine ( n1 +  " - max");
}
else
{
    Console.WriteLine ( n2 + " - max");
}