// Напишите программу, которая на вход
// 1.принимает число
// 2. выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine ("enter a number:  ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Square of the {number} = {square}");
// int - 2 147 483 648 до 2 147 483 647

