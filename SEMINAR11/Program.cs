int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int min = 0, int max = 10)
{
    int size = array.Length;
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
int[] SolveEx(int[] array) 
{
    int size = array.Length;
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[i];
    }

    return result;
}
string Print(int[] array) 
{
    string res = string.Empty;
    int size = array.Length;
    res = "[ ";
    for(int i = 0; i < size; i++)
    {
        res+= $"{array[i], 3} ";
    }
    res += " ]";

    return res;
}

int[] startArray = CreateArray(10);
FillArray(startArray);
Console.WriteLine(Print(startArray));
int[] resultArray = SolveEx(startArray);
Console.WriteLine(Print(resultArray));