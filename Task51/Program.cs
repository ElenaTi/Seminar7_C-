/* Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12  */

int[,] fillArray(int rowsCount, int columnCount)
{
    int[,] result_array = new int[rowsCount,columnCount];
    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            result_array[i,j] = i + j;
        }
    }
    return result_array;
}

void printArray(int[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayForPrint[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] evenElementsArray(int[,] arrayFinal)
{
    for (int i = 0; i < arrayFinal.GetLength(0); i=i+2)
    {
        for (int j = 0; j < arrayFinal.GetLength(1); j=j+2)
        {
            arrayFinal[i,j] = arrayFinal[i,j] * arrayFinal[i,j];
        }
    }
    return arrayFinal;
}

int[,] array = fillArray(3,4);
printArray(array);
Console.WriteLine();
int[,] finalArray = evenElementsArray(array);
printArray(finalArray);
