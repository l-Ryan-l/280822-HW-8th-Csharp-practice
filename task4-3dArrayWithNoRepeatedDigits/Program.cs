/* 
Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) 
*/


int[,,] FillArray(int rows, int columns, int depth, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns, depth];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (array[i, j, k] == 0)
                {
                    int number = rnd.Next(minValue, maxValue + 1);

                    if (IsNumberInArray(array, number) == false)
                    {
                        array[i, j, k] = number;
                    }
                }
            }
        }
    }
    return array;
}

bool IsNumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) return true;
            }
        }
    }
    return false;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}" + "(" + $"{i},{j},{k}" + ") ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array = FillArray(2, 2, 2, 0, 100);
Console.WriteLine("Прошу поприветствовать уникальный массив: ");
PrintArray(array);

