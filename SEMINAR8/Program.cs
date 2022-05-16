/*Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку массива.


int[,] ChangeLine(int[,] matrix)
{
    int tmp = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        tmp = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = tmp;
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    Console.WriteLine();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
    Console.WriteLine();
    }
}

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(-10,10);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

Console.Write("Введите количество строк: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int length = Convert.ToInt32(Console.ReadLine());

PrintArray(ChangeLine(CreateArray(height, length)));
*/

/*Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(-10,10);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    Console.WriteLine();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
    Console.WriteLine();
    }
}

/*int[,] ChangeRowToCol(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(0)];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i, j] = matrix[j, i];
        }
    }
    return result;
}
*/

int[,] ChangeRowToCol(int[,] matrix)
{
    int tmp = 0;
    int k = matrix.GetLength(0) - 1;
    int l = matrix.GetLength(1) - 1;
    for(int i = 0; i < k ; i++)
    {
        for(int j = i + 1; j <= l ; j++)
        {
            tmp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = tmp;
        }
    }
    return matrix;
}

Console.Write("Введите количество строк: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int length = Convert.ToInt32(Console.ReadLine());

if(height == length)
{
    PrintArray(ChangeRowToCol(CreateArray(height, length)));
}
else
{
    Console.WriteLine("Невозможно поменять местами!");
}