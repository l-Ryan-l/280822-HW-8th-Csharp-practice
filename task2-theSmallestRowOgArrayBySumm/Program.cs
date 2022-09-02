/* 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка 
*/

int[,] FillArray (int rows, int columns, int minValue, int maxValue)
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

int FindSummOfRowElements(int[,]array)
{
    int minSum = Int32.MaxValue;
    int rowNumber = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i,j];
        }
        if (summ <= minSum)
            {
            minSum = summ;
            rowNumber = i;
            }
    }
    return rowNumber;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
           for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = FillArray(4, 4, 0, 5);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
int rowNumber = FindSummOfRowElements(array);
Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {rowNumber}");
 
