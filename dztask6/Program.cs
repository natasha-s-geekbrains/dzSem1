﻿//Напишите программу, которая на вход 
// принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);


if (number % 2 == 0)
{
    Console.WriteLine("Ваше число четное.");
}
else
{
    Console.WriteLine("Ваше число нечетное.");
}


