// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите 1ое число:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2ое число:");
int N = Convert.ToInt32(Console.ReadLine());

int res = SumNaturalNumbers(M, N);
Console.WriteLine(res);

int SumNaturalNumbers(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;
    else if (n == 0) return (m * (m + 1)) / 2;
    else if (m == n) return m;
    else if (m < n) return n + SumNaturalNumbers(m, n - 1);
    else return n + SumNaturalNumbers(m, n + 1);
}