// Задача 23
// Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeTable(number);

void CubeTable(int num)
{
    int index = 1;
    while (index <= num)
    {
        int cube = index*index*index;
        Console.WriteLine($"|{index,4}|{cube, 4}|");
        index++;
    }
}
