/* 
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 
*/


int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return array;
}

int[,] CreateResultMask(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 1;
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] matrixOne, int[,] matrixTwo, int[,] matrixResult)
{
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                sum += matrixOne[i, k] * matrixTwo[k, j];
            }
            matrixResult[i, j] = sum;
        }
    }
}

int[,] matrixOne = CreateMatrix(2, 2, 0, 10);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrixOne);
Console.WriteLine();

int[,] matrixTwo = CreateMatrix(2, 2, 0, 10);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(matrixTwo);
Console.WriteLine();

int[,] resultMatrix = CreateResultMask(2, 2);
Console.WriteLine("Результирующая матрица: ");
MultiplyMatrix(matrixOne, matrixTwo, resultMatrix);
PrintMatrix(resultMatrix);

