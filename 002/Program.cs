// дать двумерный массив следующим правилом: Aₘₙ = m+n

void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = m + n;
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
int m = 8;
int n = 8;
int[,] array = new int[m, n];


PrintArray(array);