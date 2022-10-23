// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// найти сначала х, потом поставляем код, вычисление с помощью метода
// вводиться целые числа, выводиться double

Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);

void IntersectionPoint(double B1, double K1, double B2, double K2)
{
    var x = -(B1 - B2) / (K1 - K2);
    var y = K1 * x + B1;
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    Console.WriteLine($"точка пересечения двух прямых {x}; {y}");
}

