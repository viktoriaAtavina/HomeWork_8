// Показать Треугольник Паскаля,сделать вывод в виде равнобедренного треугольника


Console.Write("Введите размер треугольника: ");
int n = int.Parse(Console.ReadLine() ?? "0");

for (int i = 0; i < n; i++)
{
    int c = 1;
    for (int j = 0; j < n - i; j++)
    {
        Console.Write("  ");
    }
    for (int k = 0; k <= i; k++)
    {
        Console.Write($" {c}  ");
        c = c * (i - k) / (k + 1);
    }
    Console.WriteLine();
}
Console.WriteLine();