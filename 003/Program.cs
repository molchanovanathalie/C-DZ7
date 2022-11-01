// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillArray(int[,] matrix, int m, int n)
{
    for (m = 0; m < matrix.GetLength(0); m++)
    {
        for (n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = new Random().Next(1, 10);
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
void Replace(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m += 2)
    {
        for (int n = 0; n < matrix.GetLength(1); n += 2)
        {
            matrix[m, n] = matrix[m, n] * matrix[m, n];
        }
    }
}
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];

FillArray(matrix, m, n);
PrintArray(matrix);
Console.WriteLine();
Replace(matrix);
PrintArray(matrix);