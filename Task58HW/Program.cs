// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],4}, ");
            else Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int [,] ResultMatrix(int[,] arr1, int[,] arr2)
{
    var matrix3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    matrix3[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
    }    
    return matrix3;
    
}

int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 4);
PrintMatrix(matrix1);
Console.WriteLine("");
int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 4);
PrintMatrix(matrix2);
Console.WriteLine("");
int[,] resultMatrix = ResultMatrix(matrix1, matrix2);
PrintMatrix(resultMatrix);