﻿// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

int[] CreateArray(int length, int min, int max)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
}

// int SumNegativeElements(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum;
// }

// int SumPositiveElements(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum;
// }

const int minus = -1;
const int plus = 1;

int SumSignedElements(int[] array, int sign = plus)     // Решение через задание (const int) знака
{                                                       
    int sum = 0;
    for (int i = 0; i < array.Length; i++)              
    {
        if ((array[i] * sign) > 0)                      //for считает положительные значени, а sign превращает отрицательные в положительные
        {
            sum += array[i];
        }
    }
    return sum;
}

void PrintArray(int[] array) // вывод массива на консоль
{
for (int j = 0; j < array.Length; j++)
{
Console.Write(array[j] + "\t");
}
System.Console.WriteLine();
}

int [] array = CreateArray(12, -9, 9);

// int sumPositive = SumPositiveElements(array);
// int sumNegative = SumNegativeElements(array);

int sumPositive = SumSignedElements(array);
int sumNegative = SumSignedElements(array, minus);
PrintArray(array);
System.Console.WriteLine($"Сумма отрицательных чисел = {sumNegative}, а сумма положительных чисел = {sumPositive} ");