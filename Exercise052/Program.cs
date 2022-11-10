// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateFillPrintArray(int row, int col)
{
    Console.WriteLine();
    Console.WriteLine("Задан массив случайных чисел: ");
    int[,] RandomFillArray(int[,] array)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                array[i, j] = new Random().Next(-10, 10);
            }
        }
        return array;
    }
    int[,] PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,3}", array[i, j]);
            }
            Console.WriteLine();
        }
        return array;
    }
    int[,] array = new int[row, col];
    RandomFillArray(array);
    PrintArray(array);
    return array;
}

void FindAverageAtCol(int[,] array)
{
    double summ = 0;
    double res = 0;
    int n = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ = summ + array[i, j];
            res = summ / array.GetLength(0);
        }
        summ = 0;
        n++;
        Console.Write($"Среднее арифметическое по столбцу");
        Console.WriteLine($" {n} = {Math.Round(res,2)}");
    }
}

int row = 6;
int col = 8;

FindAverageAtCol(CreateFillPrintArray(row, col));