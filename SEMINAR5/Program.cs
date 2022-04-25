/*Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.


int[] ChangeNums(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] *= (-1);

    return array;
}
*/

/*Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве.


bool FindNum(int[] array, int num)
{
    bool n = false;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        {
            n = true;
            break;
        }
        else
            n = false;
    }
    return n;
}

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

Console.Write("Задайте искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(10, -10, 10);
ShowArray(myArray);
Console.WriteLine(FindNum(myArray, number));
*/

/*Задайте одномерный массив из 15 случайных чисел.
Найдите количество элементов массива,
значения которых лежат в отрезке [10,99].


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

int QuantOfNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99)
        count++;
    }
    return count;
}

int[] myArray = CreateRandomArray(15, -100, 100);
ShowArray(myArray);
int quantity = QuantOfNumbers(myArray);
Console.WriteLine("Количество чисел от 10 до 99: " + quantity);
*/

/*Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
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

int[] MultPair(int[] array)
{
    int newSize = array.Length/2;
    int[] result = new int[newSize];
    for(int i = 0, j = array.Length - 1; i < newSize; i++, j--)
    {
        result[i] = array[i] * array[j];
    }
    return result;
}

int[] myArray = CreateRandomArray(10, -10, 10);
ShowArray(myArray);
int[] myNewArray = MultPair(myArray);
ShowArray(myNewArray);
