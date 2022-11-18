// Найти произведение двух матриц

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер матрицы: ");
int size = int.Parse(Console.ReadLine() ?? "0");

int[,] FirstArray = new int[size, size];
int[,] SecondArray = new int[size, size];

FillArray(FirstArray);
FillArray(SecondArray);
int[,] ProductMatrix = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            ProductMatrix[i, j] += FirstArray[i, k] * SecondArray[k, j];
        }
    }
}
Console.WriteLine("Первая Матрица:");
PrintArray(FirstArray);
Console.WriteLine();

Console.WriteLine("Вторая Матрица:");
PrintArray(SecondArray);
Console.WriteLine();

Console.WriteLine("Произведение Матриц:");
PrintArray(ProductMatrix);
