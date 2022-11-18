// В двумерном массиве целых чисел. Удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.

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

int rows = 5;
int columns = 5;
int[,] array = new int[rows, columns];

Console.WriteLine("Оригинальная матрица: ");
FillArray(array);
PrintArray(array);
Console.WriteLine();

int m = 0;
int n = 0;
int MinNumber = array[0, 0];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < MinNumber)
        {
            MinNumber = array[i, j];
            m = i;
            n = j;
        }
    }
}
Console.WriteLine($"Наименьший элемент: {MinNumber} ");
Console.WriteLine();
Console.WriteLine("Матрица без строки и столбца с минимальным элементом: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        {
            if ((i == m) || (j == n))
                continue;
            else
                Console.Write($"{array[i, j]} ");
        }
    }
    Console.WriteLine();
}