﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.WriteLine("Введите первое  число:");
int number_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе  число:");
int number_B = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= number_B; i++)
{
    result = result * number_A;
}
Console.WriteLine($" Число {number_A} в степени {number_B} =  {result}");


