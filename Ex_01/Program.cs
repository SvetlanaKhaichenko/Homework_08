// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] SortedArray(int[,] array)
{
    for (int k = 0; k < 2; k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {

                if (array[i, j] < array[i, j + 1])
                {
                    int value = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = value;
                }


            }

        }
    }
    return array;
}

void PrintArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }
}

//int[,] GivenAr = { { 7, 4, 2, 1 }, { 9, 5, 3, 2 }, { 8, 4, 4, 2 } };
int[,] GivenAr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintArray(SortedArray(GivenAr));