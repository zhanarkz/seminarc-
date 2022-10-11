// Задача 19
// Напишите программу, которая 
// принимает на вход пятизначное число и п
// роверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.WriteLine ("Введите пятизначное число:  ");
int N = Convert.ToInt32(Console.ReadLine());
bool checkPallindrome (int num)
{
    int firstDigit = num / 10000; 
    int secondDigit = num % 10000 / 1000; 
    int forthDigit = num % 100 / 10;
    int lastDigit = num % 10;
    return lastDigit == firstDigit && secondDigit == forthDigit;
}

if (checkPallindrome(N)) Console.Write("да");
else if (N > 99999 || N < 10000) Console.Write("не пятизначное число");
else Console.Write("нет");