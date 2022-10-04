// task 9. Напишите программу, которая 
// выводитслучайное число из отрезка [10, 99] и
//  показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Random number from 10 to 99 => {number}");
// int firstDigit = number / 10; // 78 / 10=7.8 
// int secondDigit = number % 10; // 78 % 10 = 8
// if (firstDigit == secondDigit) Console.WriteLine($"digits are equal");
// else if (firstDigit > secondDigit) Console.WriteLine($"the biggest digit is {firstDigit}");
// else Console.WriteLine($"the biggest digit is {secondDigit}");
int maxDigit = MaxDigit(number);
int MaxDigit(int num) //методы с большой буквы, в методе не нужно елсе, не нужно называть как локальная переменная
{
    int firstDigit = num / 10; // 78 / 10=7.8 
    int secondDigit = num % 10; // 78 % 10 = 8
    
    // int result = default
    // if (firstDigit > secondDigit) result = firstDigit;
    // else result = secondDigit;

    return firstDigit > secondDigit ? firstDigit : secondDigit;;
}
Console.WriteLine($"the biggest digit is {maxDigit}");
// int res = Math.Max (firstDigit, secondDigit);
// Console.WriteLine($"the biggest number = {res}");