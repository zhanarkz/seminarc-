// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число множитель: ");
int multiply = Convert.ToInt32(Console.ReadLine());

Degree(number, multiply);

void Degree(int a, int b)
{
    int result = default;
    for (int i = 1; i <= b; i++)
    {
       result = result * a;       
    }
Console.Write($"{a} в {b}-cтепени  = {result}");
 
}


