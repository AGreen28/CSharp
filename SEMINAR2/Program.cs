/*
void ShowNumber()
{
    int num = new Random().Next(10, 99);
    int firstNum = num/10;
    int secondNum = num%10;

    Console.Write(num + " -> ");

    if(firstNum > secondNum)
    {
        Console.WriteLine(firstNum);
    }
    else
    {
        Console.WriteLine(secondNum);
    }
}

ShowNumber();
*/

/*
int ShowNumber()
{
    int num = new Random().Next(10, 99);
    int firstNum = num/10;
    int secondNum = num%10;

    Console.Write(num + " -> ");

    if(firstNum > secondNum)
    {
        return firstNum;
    }
    else
    {
        return secondNum;
    }
}

int a = ShowNumber();

Console.WriteLine(a);
*/

/*
Напишите программу, которая выводит случайное трёхзначное число
 и удаляет вторую цифру этого числа.
456 -> 46

void ReduceNumber()
{
    int num = new Random().Next(100, 999);
    Console.Write(num + " -> ");

    int n1 = num/100;
    int n3 = num%10;
    int n13 = n1 * 10 + n3;

    Console.Write(n13);
}

ReduceNumber();
*/

/*
Напишите программу, которая будет принимать на вход два числа и выводить,
 является ли второе число кратным первому. 
 Если второе число не кратно числу первому, то программа выводит остаток от деления.


void DividingNumber()
{
    Console.Write("Введите первое число: ");
    int firstNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int secondNum = Convert.ToInt32(Console.ReadLine());
    int rem = firstNum%secondNum;

    if(rem == 0)
    {
        Console.WriteLine("Результат деления равен: " + firstNum/secondNum); 
    }
    else
    {
        Console.WriteLine("Делится с остатком: " + rem);
    }

}

DividingNumber();
*/

/*
Напишите программу, которая принимает на вход число и проверяет,
 кратно ли оно одновременно 7 и 23.

void Multiple(int num)
{
    if(num % 7 == 0 && num % 23 ==0)
    {
        Console.Write(num + " кратно 7 и 23");
    }
    else
    {
        Console.Write(num + " не кратно 7 и 23");
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Multiple(num);
*/

/*
Напишите программу, которая принимает на вход два числа и проверяет,
 является ли одно число квадратом другого.
*/

void Square(int num1, int num2)
{
    if(num1 == num2 * num2)
    {
        Console.Write("Yes");
    }
    else
    {
        Console.Write("No");
    }
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Square(num1, num2);