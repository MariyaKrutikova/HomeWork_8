/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

/*int GetNumber(string message)
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
}*/

int[,,] InitMatrix(int x, int y, int z)
{
    int[,,] matrix = new int[x, y, z];
    Random rnd = new Random();
    for (int i = 0; i < x; i++)
    {
        for ( int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                int number = 0;
                bool a = true;//не хочу записывать
                while (a)
                    {
                    number = rnd.Next(10,99);
                    a = false;
                    for (int n = 0; n < x; n++)
                        for (int m = 0; m < y; m++)
                            for (int p = 0; p < z; p++)
                                    {if (matrix[n,m,p] == number)
                                    {
                                        a = true;
                                    } 
                                    //Console.WriteLine($"подбор,{n},{m},{p},{number},{a}"); 
                                    }
                    }
                   // Console.WriteLine($"подобрано,{i},{j},{k},{number},{a}");  
               matrix[i,j,k] = number;                   
            }
               
        }        
    }
    return matrix;
}  

int[,,] PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(2); j++)
                {
                    Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    return matrix;
}


// int x = GetNumber("Задайте количество строк: ");
// int y = GetNumber("Задайте количество столбцов: ");
// int z = GetNumber("Задайте количество слоев: ");

int[,,] matrix = InitMatrix(2, 2, 2);
PrintMatrix(matrix);
Console.WriteLine();

