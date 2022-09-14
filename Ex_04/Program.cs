// ** Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] MultiplicationMatrix(int[,] a, int[,] b)
{
    int[,] result = new int[a.GetLength(0), b.GetLength(1)];
    if (a.GetLength(0) == b.GetLength(1))
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                for (int k = 0; k < result.GetLength(1); k++)
                {
                    result[i, j] = result[i, j] + a[i, k] * b[k, j];
                }

            }
        }
    }
    else
    {
        System.Console.WriteLine("Матрицы нельзя перемножить!");
    }
    return result;
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


int[,] x = { { 2, 4 }, { 3, 2 } };
int[,] y = { { 3, 4 }, { 3, 3 } };
PrintArray(MultiplicationMatrix(x, y));