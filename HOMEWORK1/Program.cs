﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введи первое число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введи второе число");
int b = int.Parse(Console.ReadLine());

if (a>b)
{
    Console.WriteLine("Первое число больше"); 
}
else
{
    Console.WriteLine("Второе число больше"); 
}
if (a<b)
{
   Console.WriteLine("Первое число меньше"); 
}
else
{
    Console.WriteLine("Второе число меньше");  
}