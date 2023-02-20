/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using System.Numerics;

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Повторите ввод");
        }
    }
    return result;
}
int[,] GetArray(int n, int m, int min, int max)
{
    int[,] matrix = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void PrintDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

double[] GetAverageValue(int[,] matrix)
{
    double[] resultArray = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double result = 0.0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result += matrix[j, i];
        }
        resultArray[i] = Math.Round(result / matrix.GetLength(0), 1);
    }


    return resultArray;
}

int sizeN = GetNumber("Введите количество строк массива: ");
int sizeM = GetNumber("Введите количество столбцов массива: ");
int min = GetNumber("Введите начальное значение числового диапазона: ");
int max = GetNumber("Введите начальное значение числового диапазона: ");
int[,] resultArray = GetArray(sizeN, sizeM, min, max);
PrintArray(resultArray);
double[] arrayAverageValue = GetAverageValue(resultArray);
PrintDoubleArray(arrayAverageValue);

