using System;

/* Дан двумерный массив.
732
496
185
Отсортировать данные в нем по возрастанию.
123
456
789
*/
class Program
{
    static void Main(string[] args)
    {
       int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int[] flattenedArray = FlattenArray(array);
        Array.Sort(flattenedArray);

        int[,] sortedArray = ConvertTo2DArray(flattenedArray, array.GetLength(0), array.GetLength(1));

        Console.WriteLine("Отсортированный массив:");
        PrintArray(sortedArray);

        Console.ReadLine();
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static int[] FlattenArray(int[,] array)
    {
        int[] flattenedArray = new int[array.GetLength(0) * array.GetLength(1)];
        int index = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                flattenedArray[index++] = array[i, j];
            }
        }

        return flattenedArray;
    }

    static int[,] ConvertTo2DArray(int[] array, int rows, int columns)
    {
        int[,] twoDArray = new int[rows, columns];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                twoDArray[i, j] = array[index++];
            }
        }

        return twoDArray;
    }
}