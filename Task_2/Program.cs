// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int n1, n2, n3;

Console.Write( "Input First number ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write( "Input Second number ");
n2 = Convert.ToInt32(Console.ReadLine());

Console.Write( "Input third number ");
n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (max < n2)
{
     Console.WriteLine (n2  + " - max");
}
if ( max < n3 )
{
    Console.WriteLine (n3  + " - max");
}