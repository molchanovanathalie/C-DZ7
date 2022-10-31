// дать двумерный массив следующим правилом: Aₘₙ = m+n
void FillArray(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = m + n;
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            Console.Write($"{matrix[m, n]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()?? "0");
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);