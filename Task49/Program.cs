/* Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4  
Сумма элементов главной диагонали: 1+9+2 = 12  */*/

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
int summOfDiagonal(int[,] anyArray)
{
    int summ = 0;
    for (int i = 0;  i < anyArray.GetLength(0); i++)
    {
        summ = anyArray[i,i] + summ;
    }    
    return summ;
}

int[] getDiagonal(int[,] array)
{
    int length = 0;
    if(array.GetLength(0) > array.GetLength(1))
    {
        length = array.GetLength(1);
    }
    else
    {
        length = array.GetLength(0);
    }
    int[] diagonalArray = new int[length];
    for (int i = 0; i < diagonalArray.Length; i++)
    {
        diagonalArray[i] = array[i,i];
    }
    return diagonalArray;
}

int[,] array = fillArray(3,4);
printArray(array);
Console.WriteLine();
int summOfDiagonale = summOfDiagonal(array);
int[] finalDiagonalArray = getDiagonal(array);

Console.Write("Сумма элементов главной диагонали: ");
for (int i = 0; i < finalDiagonalArray.Length; i++)
{
    Console.Write($"{finalDiagonalArray[i]}");
    if(i < finalDiagonalArray.Length - 1)
    {
        Console.Write($" + ");
    }
}
Console.Write($" = {summOfDiagonale}");

