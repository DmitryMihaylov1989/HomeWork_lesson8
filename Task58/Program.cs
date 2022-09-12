// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int size = 4;
int[,] matrix1 = new int[size, size];
int[,] matrix2 = new int[size, size];
int[,] matrix3 = new int[size, size];
MatrixNum(matrix1);
MatrixNum(matrix2);

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrix3[i, j] = matrix3[i, j] + (matrix1[i, k] * matrix2[k, j]);
        }
    }
}


void MatrixNum(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0,10); 
        }
    }
}

void PrintArray(int[,] matrix)
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


Console.WriteLine("Матрица - 1");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица - 2");
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц");
PrintArray(matrix3);
