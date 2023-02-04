// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int rows = ReadNumber("Введите индекс строки: ");
int colums = ReadNumber("Введите индекс столбца: ");
int[,] numbers = new int[4, 6];
FillMatrix(numbers);
PrintMatrix(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) 
{
    Console.WriteLine(numbers[rows, colums]);
}
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");


// Заполнение массива случайными числами от 1 до 9
void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//  Функция вывода массива в терминал
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция ввода 
int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}