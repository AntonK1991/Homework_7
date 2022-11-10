// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.


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
                array[i, j] = new Random().Next(0, 100);
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

void FindElement(int[,] array)
{
    Console.Write("Введите номер строки необходимого элемента:");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца необходимого элемента:");
    int col = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    int j = 0;

    if (row > array.GetLength(0) || col > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет!");
    }
    else
    {
        for (i = 0; i < array.GetLength(0); i++)
        {
            if (row - 1 == i)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    if (col - 1 == j)
                    {
                        int result = array[i, j];
                        Console.WriteLine("Значение элемента массива - " + result);
                        break;
                    }
                }
            }
        }
    }
}

int row = 3;
int col = 4;

FindElement(CreateFillPrintArray(row, col));