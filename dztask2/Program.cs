﻿// Задача 2: Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а 
// какое меньшее


Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 == number2)
{
    Console.WriteLine("Ваши числа равны.");
}

else if (number1 > number2)
{
    Console.WriteLine("Первое число больше второго.");
}

else
{
    Console.WriteLine("Второе число больше первого.");
}
