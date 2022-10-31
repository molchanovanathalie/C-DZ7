// В двумерном массиве показать позиции числа, 
//заданного пользователем или указать, что такого элемента нет

void FillArray(int[,] matrix, int m, int n)
{
    for(int i = 0; i< matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for(int i = 0; j < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]}");
        Console.WriteLine();
    }

}
int Count(int [,] matrix, int m, int n, int num)
{
int count = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for(int j = 0; j < matrix.GetLength(1); j++)

        if(matrix[i,j] == num)
        count = count+1;
    }
    return(count);
}
void PositionNum(int [,] matrix, int num)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if(matrix[i,j] == num)
                Console.WriteLine($"Число {num} содержится в строке {i+1} и столбце {j+1}");
    }
}

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.Readline());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.Readline());
Console.WriteLine("Введите искомок число: ");
int num = int.Parse(Console.Readline());

int[,] matrix = new int[m,n];

FillArray(matrix, m, n);
PrintArray(matrix);
PositionNum(matrix,num);

int x = Count(matrix, m, n, num);
    if(x<1)
        Console.WriteLine($"Число {num} не содержится в матрице");