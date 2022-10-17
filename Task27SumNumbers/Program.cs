// Задача 27: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

SumNumbers(number);

void SumNumbers(int num)
{
int sum = 0;
while (num > 0)
{
int numb = num % 10;
num = num / 10;
sum = sum + numb;
}
Console.WriteLine($"сумма всех цифр в числе равна: {sum}");
}