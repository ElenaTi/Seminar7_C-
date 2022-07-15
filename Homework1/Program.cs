/* Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9  */

double[,] FillArray (int rows, int columns)
{
    double[,] newarray = new double[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newarray[i,j] = new Random().Next(-100,100)/100.0;
        }
    }
    return newarray;
}

void PrintArray(double[,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{i}\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write(array[i,j]);
            if (j < array.GetLength(1) - 1)
            {
                Console.Write("\t");
            }
        }
         Console.WriteLine();
    }
   
}

double[,] array2D = FillArray(3,4);
PrintArray(array2D);