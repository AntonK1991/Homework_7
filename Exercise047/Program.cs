// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double[,] CreateFillPrintArray(int row, int col)
{
    Console.WriteLine();
    Console.WriteLine("Задан массив случайных чисел: ");
    double[,] RandomFillArray(double[,] array)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                array[i, j] = new Random().NextDouble();
            }
        }
        return array;
    }
    double[,] PrintArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,7}", (Math.Round(array[i, j], 2)));
            }
            Console.WriteLine();
        }
        return array;
    }
    double[,] array = new double[row, col];
    RandomFillArray(array);
    PrintArray(array);
    return array;
}

int n = 4;
int m = 3;
CreateFillPrintArray(m, n);
