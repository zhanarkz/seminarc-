// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
// лучше разделить мин и мах в два метода, для разницы не нужно метода

double[] CreateArrayRndDouble(int size, int min, int max)
{
var array = new double[size];
var rnd = new Random();

for (int i = 0; i < size; i++)
{
double rndNum = rnd.NextDouble() * (max - min) + min;// параметры не принимает, поэтому множитель
array[i] = Math.Round(rndNum, 2);// округляем значение
}
return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double MinValue(double[] array)
{
   var min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
}
return min;
}

double MaxValue(double[] array)
{
   var max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
}
return max;
}

double[] arr = CreateArrayRndDouble(5, 0, 9);
PrintArray(arr);

double minValue = MinValue(arr);
double maxValue = MaxValue(arr);
double result = maxValue - minValue;


Console.WriteLine ($"разница между {maxValue} и {minValue} = {result}");