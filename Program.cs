
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"number {number1} max  number {number2} min");
}
else
{
    Console.WriteLine($"number {number2} max  number {number1} min");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Write the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Write second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Write third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
 {
    max = num2;
 }
if (num3 > max)
 {
    max = num3;
 }

  Console.WriteLine($"number {max} max");
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"number {num} is even ");
}
else
{
    Console.WriteLine($"number {num} is odd  ");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

int i=1;

while(i <= num)
{
    if ( i % 2 == 0 )
    Console.Write(i + " ");
    i++;
}
*/