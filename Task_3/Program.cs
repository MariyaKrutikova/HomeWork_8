/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

int[,] MatrixMultiplication(int[,] firstmatrix, int[,] secondmatrix)
{
        int[,] multiplicationMatrix = new int[firstmatrix.GetLength(0), secondmatrix.GetLength(1)];
        for (int i = 0; i < firstmatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondmatrix.GetLength(1); j++)
            {
                multiplicationMatrix[i, j] = 0;
                for (int n = 0; n < firstmatrix.GetLength(1); n++)
                {                    
                   multiplicationMatrix[i, j] = multiplicationMatrix[i, j] + firstmatrix[i, n] *secondmatrix[n, j];
                }
            }
        }
    
    return multiplicationMatrix;
}

int firstrow = GetNumber("Введите количество строк первой матрицы:");
int firstcolumn = GetNumber("Введите количество строк первой матрицы:");

int[,] firstmatrix = InitMatrix(firstrow, firstcolumn);
PrintMatrix(firstmatrix);
Console.WriteLine();

int secondrow = GetNumber("Введите количество строк второй матрицы:");
int secondcolumn = GetNumber("Введите количество строк второй матрицы:");

int[,] secondmatrix = InitMatrix(secondrow, secondcolumn);
PrintMatrix(secondmatrix);
Console.WriteLine();

if (firstmatrix.GetLength(1) == secondmatrix.GetLength(0))
{
    int[,] resultmatrix = MatrixMultiplication(firstmatrix, secondmatrix);
    PrintMatrix(resultmatrix);
}   
else
    Console.WriteLine("Матрицы невозможно перемножить");


