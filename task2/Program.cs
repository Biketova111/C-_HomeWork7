/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
 возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */


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

void GetElement(int[,] matrix, int rows, int colums)
{
    if (rows < matrix.GetLength(0) && colums < matrix.GetLength(0))
    {
        Console.WriteLine($"Элемент матрицы ({rows}, {colums}) равен {matrix[rows, colums]} ");
    }
    else
    {
        Console.WriteLine ("Такого элемента нет");
    }
}


int sizeN = GetNumber("Введите количество строк массива: ");
int sizeM = GetNumber("Введите количество столбцов массива: ");
int min = GetNumber("Введите начальное значение числового диапазона: ");
int max = GetNumber("Введите начальное значение числового диапазона: ");
int[,] resultArray = GetArray(sizeN, sizeM, min, max);
PrintArray(resultArray);
int rows = GetNumber("Введите строку в которой находится искомый элемент: ");
int  colums = GetNumber("Введите столбец в которой находится искомый элемент: ");
GetElement(resultArray, rows, colums);