// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int RowsSum(int[,] givmas)
{
    int[] sum = new int[givmas.GetLength(0)];
    for (int i = 0; i < givmas.GetLength(0); i++)
    {
        for (int j = 0; j < givmas.GetLength(1); j++)
        {
            sum[i] = sum[i] + givmas[i, j];
        }
    }
    int min = sum[0];
    for (int l = 0; l < sum.Length - 1; l++)
    {
        if (min > sum[l + 1]) min = sum[l + 1];
    }
    int rows = 0;
    for (int c = 0; c < sum.Length; c++)
    {
        if (min == sum[c]) rows = c+1;

    }
    return rows;
}

int[,] givenMas = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {RowsSum(givenMas)} строка.");
//PrintArray(RowsSum(givenMas));