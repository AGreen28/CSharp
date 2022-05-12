/*Задайте двумерный массив.
Найдите сумму элементов, находящихся на главной диагонали
(с индексами (0,0); (1;1) и т.д.


int SumOfDiagonal(int[,] quad)
{
    int sum = 0;

    for(int i = 0; i < quad.GetLength(0); i++)
    {
        sum += quad[i,i];
    }

    return sum;
}

Console.Write("Введите размер матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[size,size];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(SumOfDiagonal(matrix));
*/

/*Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = i + j;
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
*/

/*Задайте двумерный массив.
Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты.
*/

int[,] MassiveQuad(int[,] quad)
{
    for(int i = 0; i < quad.GetLength(0); i+=2)
    {
        for(int j = 0; j < quad.GetLength(1); j+=2)
        {
            quad[i,j] *= quad[i,j];
        }
    }

    return quad;
}

void ShowMassive(int[,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write(massive[i,j] + " ");
        }
    Console.WriteLine();
    }
}


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
ShowMassive(MassiveQuad(matrix));
