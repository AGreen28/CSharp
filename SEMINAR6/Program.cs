/*bool IsTriangleExist(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b)
    {
        return true;
    }

    return false;

}

if(IsTriangleExist(2, 2, 3))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

/*Написать программу, которая принимает
 одномерный массив и возвращает его перевернутую версию.
 

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

int[] ReverseArray(int[] array)
{
    int newSize = array.Length;
    int[] newArray = new int[newSize];
    
    for(int i = 0, j = newSize - 1; i < newSize; j--, i++)
    {
        newArray[i] = array[j];
    }
    return newArray;
}

int[] myArray = CreateRandomArray(10, 0, 10);
int[] newArr = ReverseArray(myArray);
ShowArray(myArray);
ShowArray(newArr);
*/

 /*Не используя рекурсию, выведите первые N чисел Фибоначчи.
 Первые два числа Фибоначчи: 0 и 1.
*/

int[] GetFibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for(int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] newArray = GetFibonacci(10);
ShowArray(newArray);