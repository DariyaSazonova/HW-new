/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

// метод ввода числа с консоли
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SIZE = ReadNumber($"Введите длину массива: ");

int[] GetRandomArray(int SIZE, int leftRange, int rightRange)

{
    int[] array = new int[SIZE];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange +1);
    }

    return array;
}

const int leftRange = 100;
const int rightRange = 999;

int[] massive = GetRandomArray(SIZE, leftRange, rightRange);
Console.WriteLine(string.Join(", ", massive));

int result = 0;

for(int i = 0; i <massive.Length; i++)
{ 
    if(massive[i] % 2 == 0)
    {
        result++;
    } 
}
if (result % 10 == 1)
{
    Console.WriteLine($"В массиве {result} четное число");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"В массиве {result} четных числа");
}
else

    Console.WriteLine($"В массиве {result} четных чисел");

