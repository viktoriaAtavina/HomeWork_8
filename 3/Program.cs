// Задание 3. Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы соответствующего элемента
Console.Clear();
void New3DArray (int[,,] matr)
{
    int count = 10;
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            for (int n = 0; n < matr.GetLength(2); n++)
            {
                matr[i, j, n] = count;
                count++;
            }
}
void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
                Console.Write($"Элемент[{i},{j},{k}] = {matr[i, j, k]} ");
            Console.WriteLine();
        }
}
Console.Clear();
Console.Write("Введите двузначное число 1 массива: ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите двузначное число 2 массива: ");
int y = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите двузначное число 3 массива: ");
int z = int.Parse(Console.ReadLine() ?? "0");
int[,,] matrix = new int[x, y, z];
if (x * y * z + 9 > 99)
{
    Console.WriteLine($"Невозможно заполнить 3-х мерную матрицу с измерениями {x}, {y}, {z}");
    Console.WriteLine("не повторяющимися двухзначными числами! Будут также использованы трехзначные числа.");
}
New3DArray(matrix);
Print3DArray(matrix);