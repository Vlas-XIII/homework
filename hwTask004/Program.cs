﻿// Домашка Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= number)
{
    if (count % 2 == 0)
    {
       int evenNumber = count;
       Console.WriteLine(evenNumber);
    }
count++;
}