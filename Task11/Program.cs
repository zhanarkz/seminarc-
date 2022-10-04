// Задача 11. Напишите программу, которая 
// выводит случайноетрёхзначное число и
// удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Random number from 100 to 999 => {number}");
int firstDigit = number / 100; // 456 / 100 = 4 
int thirdDigit = number % 10; // 456 % 10 = 6
int twoNumber = firstDigit * 10 + thirdDigit;
Console.WriteLine($"две цифры {twoNumber}");