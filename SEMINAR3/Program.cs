/*
Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


int FindQvart(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x < 0 && y > 0)
        return 2;
    else if(x < 0 && y < 0)
        return 3;
    else if(x > 0 && y < 0)
        return 4;
    else
        return 0;
}

Console.Write("Ведите координату X: ");
int xDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координату Y: ");
int yDot = Convert.ToInt32(Console.ReadLine());

int qvartNum = FindQvart(xDot, yDot);

if(qvartNum == 0)
    Console.WriteLine("Точка размещена на осях!");
else
    Console.WriteLine(qvartNum + " четверть");
*/

/*
Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).


void Coordinates(int qvad)
{
    if(qvad == 1)
        Console.WriteLine("x > 0; y > 0");
    else if(qvad == 2)
        Console.WriteLine("x < 0; y > 0");
    else if(qvad == 3)
        Console.WriteLine("x < 0; y < 0");
    else if(qvad == 4)
        Console.WriteLine("x > 0; y > 0");
    else
        Console.WriteLine("Нет такой четверти!");
}

Console.Write("Ведите номер четверти: ");
int qvadNum = Convert.ToInt32(Console.ReadLine());

Coordinates(qvadNum);
*/

/*
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.
Math.Sqrt()


double FindLength(double xA, double yA, double xB, double yB)
{
    double length = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));
    return length;
}

Console.Write("Ведите xA: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите yA: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите xB: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите yB: ");
double yB = Convert.ToDouble(Console.ReadLine());

double result = FindLength(xA, yA, xB, yB);
Console.WriteLine("Расстояние равно: " + result);
*/

/*
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.

2 -> 1,4
*/

void SquareTable(int num)
{
    int i = 1;
    while(i <= num)
    {
        Console.Write(i * i + " ");
        i++;
    }
}

Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

SquareTable(number);