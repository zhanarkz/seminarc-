// Задача 41: Пользователь 
// вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// сколько сначала ввел и потом посчитать сколько цифр больше нуля, поискать в нете как преообразовать в массив

Console.WriteLine("введите числа(через пробел): ");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);// считывает через пробел и преобразует в число

int HowManyNumbers(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0) count++;
    }
    return count;
}

int countedNumber = HowManyNumbers(numbers);
Console.WriteLine($"В введеных Вами числах {countedNumber} - чисел больше 0");