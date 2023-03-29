// принимаем на вход позиции элемента в двумерном массиве
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 10); // [-10, 9]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
void ArrayLimit(int[,] matrix)
{
Console.Write("Введите номер строки: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца: ");
int n = int.Parse(Console.ReadLine()!);     
    
if (m >= 0 && m < matrix.GetLength(0) && n >= 0 && n < matrix.GetLength(1))
    Console.WriteLine($"Элемент [{m}, {n}]: {matrix[m, n]}");
else
    Console.WriteLine($"Элемент [{m}, {n}] не существует");        
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив"); 
PrintMatrix(matrix);
ArrayLimit(matrix);