/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

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

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
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


void SpiralMatrix(int[,] matrix)
{
    int i = 0;
    int j = 0;
    int number = 2;
    int maxNumber = matrix.GetLength(0)*matrix.GetLength(1);
    matrix[i,j] = 1;
    //Console.WriteLine($"количесво элементов = {maxNumber}");
      
    while (number <= maxNumber)
    {   bool canmove;
        Console.WriteLine($"[i, j] = [{i},{j}]");
        Console.WriteLine($"number = {number}");
        if (j + 1  < matrix.GetLength(1)) 
        { Console.WriteLine("идем направо");
            if (matrix[i, j + 1] == 0) 
            {   canmove = true;
                while (canmove) 
                {   canmove = false;
                    if (matrix[i, j+1] == 0)
                    {   Console.WriteLine($"[i, j] = [{i},{j}]");
                        j = j + 1;
                        matrix[i,j] = number;
                        Console.WriteLine($"matrix[i,j] = {number}"); 
                        Console.WriteLine($"number = {number}");  
                        number++;                       
                    }   
                    if (j + 1  < matrix.GetLength(1))
                    {
                        if (matrix[i,j+1]==0)
                        {
                            canmove = true;
                        }
                    }
                }
            }
        }

        if (i + 1 < matrix.GetLength(0))
        {Console.WriteLine("идем вниз");
            if (matrix[i + 1, j] == 0) 
            { 
                canmove = true;
                while (canmove)
                {
                    canmove = false; 
                    if (matrix[i + 1, j] == 0)             
                    {                        
                        i = i + 1;
                        matrix[i, j] = number;                
                        Console.WriteLine($"[i, j] = [{i},{j}]"); 
                        Console.WriteLine($"matrix[i,j] = {number}"); 
                        Console.WriteLine($"number = {number}");  
                        number++;                       
                    }
                    if (i + 1  < matrix.GetLength(0))
                    {
                        if (matrix[i+1,j]==0)
                        {
                            canmove = true;
                        }
                    }
                }
            }
        }

        if (j - 1 >= 0)
        {Console.WriteLine("идем налево");
            if (matrix[i, j - 1] == 0)
            {   canmove = true;
                while (canmove)
                {    canmove = false;
                    if (matrix[i, j-1] == 0)    
                    {                                 
                        j = j - 1;
                        matrix[i,j] = number;                    
                        Console.WriteLine($"[i, j] = [{i},{j}]");        
                        Console.WriteLine($"matrix[i,j] = {number}"); 
                        Console.WriteLine($"number = {number}");  
                        number++;
                    }
                    if (j - 1  >= 0)
                    {
                        if (matrix[i, j - 1]==0)
                        {
                            canmove = true;
                        }
                    }
                }       
            }
        }

        if (i - 1 >= 0)
        {Console.WriteLine("идем вверх");
            if (matrix[i - 1, j] == 0)
            {   canmove = true;
                while (canmove)
                {    canmove = false;
                    if (matrix[i-1, j] == 0)    
                    {
                        i = i - 1;
                        matrix[i, j] = number;                   
                        Console.WriteLine($"[i, j] = [{i},{j}]");                             
                        Console.WriteLine($"matrix[i,j] = {number}"); 
                        Console.WriteLine($"number = {number}");  
                        number++;
                    }
                    if (i - 1  >= 0)
                    {
                        if (matrix[i-1,j]==0)
                        {
                            canmove = true;
                        }
                    }
                }
            }
        }
    }
}   
 
int rows = GetNumber("Задайте количество строк: ");
int columns = GetNumber("Задайте количество столбцов: ");

int[,] matrix = InitMatrix(rows,columns);
PrintMatrix(matrix);
Console.WriteLine();

SpiralMatrix(matrix);
PrintMatrix(matrix);


