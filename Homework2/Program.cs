/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] Fill2DArray(int rows, int columns)
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

void Print2DArray(int[,] arrayForPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayForPrint.GetLength(1); i++)
    {
        Console.Write($"{i+1}\t");
    }
    Console.WriteLine();
    Console.WriteLine();
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
         Console.Write($"{i+1}\t");        
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {            
            Console.Write(arrayForPrint[i,j]);
            if (j < arrayForPrint.GetLength(1) - 1)
            {
                Console.Write("\t");
            }
        }
        Console.WriteLine();
    }
}

int[] ArrayOfPositions(int[,] array)
{
    int length = array.GetLength(0) * array.GetLength(1);
    int[] arrayOfPosition = new int[length];
    int index = 0;   
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {               
                arrayOfPosition[index] = array[i,j];
                index ++;
             }
         }
    return arrayOfPosition;
}


int[,] ArrayForTask = Fill2DArray(3,4);
Print2DArray(ArrayForTask);
int[] arrayOfPositions2D = ArrayOfPositions(ArrayForTask);
Console.WriteLine("введите номер позиции интересующего Вас элемента: ");
int element = Convert.ToInt32(Console.ReadLine());
if (element >= 0 && element < arrayOfPositions2D.Length)
{
    Console.WriteLine($"Элемент с {element} позицией  = {arrayOfPositions2D[element]}");
}
else
{
    Console.WriteLine("Элемента с такой позицией не существует в данном массиве.");
} 