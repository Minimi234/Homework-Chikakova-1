// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

int n1;

Console.Write( "Input  number ");
n1 = Convert.ToInt32(Console.ReadLine());

if (n1 == 0)
{
     Console.WriteLine ("Конечное число 0");
}

if (n1 % 2 == 0)
{
     Console.WriteLine (n1  + " четное");
}
else
{
     Console.WriteLine (n1  + " нечетное");
}
