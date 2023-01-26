// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] GetRandomArray(int size, int leftRange, int rightRange)
{
    
    int [] array = new int[size];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1); 
    }
        return array;
}
const int SIZE = 123;
const int leftRange = 0;
const int rightRange = 150;

int[] massive = GetRandomArray(SIZE, leftRange, rightRange);
Console.WriteLine(string.Join(", ", massive));

int result = 0;

for(int i = 0; i <massive.Length; i++)
{ 
    if(massive[i]  >= 10 && massive[i] <= 99)
    {
        result++;
    } 
}
Console.WriteLine();
Console.WriteLine($"В массиве {result} чисел, значения которых лежат в отрезке [10,99]");

