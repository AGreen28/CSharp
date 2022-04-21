/*
Напишите программу, которая принимает на вход число (А)
и выдаёт сумму чисел от 1 до А.


int NaturalSum(int a)
{
    int sum = 0;
    
    if(a < 1) return 0;
    else
    {
        for(int i = 1; i <= a; i++)
        {
            sum += i; //sum = sum + i;
        }

        return sum;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма элементов равна " + NaturalSum(num));
*/

/*
Напишите программу, которая принимает на вход число
и выдаёт количество цифр в числе.


void LengthNum(int num)
{
    int length = 0;
    while(num > 0)
    {
        num = num / 10;
        length++;
    }
    Console.Write(length);
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
LengthNum(num);
*/

/*
Напишите программу, которая принимает на вход число N
и выдаёт произведение чисел от 1 до N.


int Multipl(int a)
{
    int mult = 1;
    
    if(a < 1) return 0;
    else
    {
        for(int i = 1; i <= a; i++)
        {
            mult = mult * i;
        }

        return mult;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Произведение элементов равно " + Multipl(num));
*/

/*
Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.

[1,0,1,1,0,1,0,0]


int[] PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write(arr[i] + " ");
    }
    return arr;
}

int[]array = new int[8];
PrintArray(array);
*/

/*
Задайте массив из 12 элементов, заполненный случайными числами
из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
*/

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

void FindSumOfElements(int[] array)
{
    int plusSum = 0;
    int minusSum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            plusSum+= array[i];
        else
            minusSum += array[i];
    }
    Console.WriteLine("Сумма положительных элементов " + plusSum);
    Console.WriteLine("Сумма отрицательных элементов " + minusSum);
}

int[] myArray = CreateRandomArray(5, -5, 5);
ShowArray(myArray);
FindSumOfElements(myArray);