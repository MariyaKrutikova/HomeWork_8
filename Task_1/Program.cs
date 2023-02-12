/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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

void SortedMatrix(int[,] matrix)
{    
    //int[,] sortedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int jj = 0; jj < matrix.GetLength(1) - 1; jj++)
        {    
            int maxposition = jj;
            for (int j = maxposition; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > matrix[i,jj]) 
                {
                    maxposition = j;
                     int memory = matrix[i,jj];
                matrix[i,jj] = matrix[i, maxposition];
                matrix[i, maxposition] = memory;  
                } 
                     
            }
        }
    } 
   }


int rows = GetNumber("Задайте количество строк: ");
int columns = GetNumber("Задайте количество столбцов: ");

int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();

SortedMatrix(matrix);
PrintMatrix(matrix);
