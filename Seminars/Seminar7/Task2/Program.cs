﻿// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
// Выведите полученный массив на экран.

int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { Console.Write($"{matrix[i, j]} \t"); }
        Console.WriteLine();
    }
}

int[,] matrix = FillArray(3, 4);
PrintArray (matrix);