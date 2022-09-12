// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int line = 5;
int col = 10;
int[,] num = new int[line, col];
Random rnd = new Random();
MatrixNumbers(num);
PrintMatrix(num);
int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < num.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < num.GetLength(1); j++)
    {
        sum = sum + num[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine($"в этом массиве, строка {indexLine} с наименьшей суммой елементов ");

void MatrixNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0,10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
