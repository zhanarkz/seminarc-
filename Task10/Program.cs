﻿// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Напишите трехзначное число");
int threeDigit = Convert.ToInt32 (Console.ReadLine());

int secondNumber = (threeDigit % 100) / 10;
Console.WriteLine($"вторая цифра {secondNumber}");