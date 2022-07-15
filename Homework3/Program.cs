/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] Fill2DArray(int rows,int columns)
{
    int[,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(0,100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"{i+1}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{i+1}\t");
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

double[] AverageOfColumns(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            
                sum = sum + array[i,j];   
        }
        average[j] = sum / 2;
    }
    return average;
}

void PrintAverage(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length-1)
        {
            Console.Write("; ");
        }
    }
    Console.Write("]");
}

int[,] arrayOfIntNumber = Fill2DArray(3,4);
PrintArray(arrayOfIntNumber);
double[] mean = AverageOfColumns(arrayOfIntNumber);
Console.WriteLine($"Среднее арифметическое каждого столбца: ");
PrintAverage(mean);


