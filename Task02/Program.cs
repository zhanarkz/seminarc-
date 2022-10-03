// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Write numberOne");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write numberTwo");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if(numberOne > numberTwo)
{
    Console.WriteLine($"{numberOne} больше, чем {numberTwo}");
}
else Console.WriteLine($"{numberTwo} больше, чем {numberOne}");