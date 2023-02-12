/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) & result > 0)
            break;
        else
        {
            Console.WriteLine("Некорректные данные. Повторите ввод.");
        }    
    }
    return result;
}

int [,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(0,10);
        }
    }
    return matrix;
}  

int[,] PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]}  ");
            }
            Console.WriteLine();
        }
    return matrix;
}

int MinSumRow(int[,] matrix)
{
    int[] sumarray = new int[matrix.GetLength(0)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumI = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumI = sumI + matrix[i, j];
        }
        sumarray[i] = sumI;
    }
    
    Console.WriteLine("Массив из сумм элемнтов в строках массива: ");
    Console.WriteLine(string.Join(", ", sumarray));
   
    int minsumrow = 0;
    for (int i = 0; i < sumarray.Length; i++)
    {
        if (sumarray[i] < sumarray[minsumrow]) minsumrow = i;
    }

    return minsumrow;
}

int rows = GetNumber("Задайте количество строк: ");
int columns = GetNumber("Задайте количество столбцов: ");

int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();

int minsumrow = MinSumRow(matrix);
Console.WriteLine($"Минимальная сумма элементов в {minsumrow + 1} строке массива");