// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

int ReadNumber(string message)
 {
     Console.WriteLine(message);
     return Convert.ToInt32(Console.ReadLine());
 }
 int size = ReadNumber($"Введите длину массива: ");
int[] numbers = new int[size];

 void FillArrayRandomNumbers(int[] numbers)
 {
     for(int i = 0; i < numbers.Length; i++)
         {
             numbers[i] = new Random().Next(1,10);
         }
 }
 void PrintArray(int[] numbers)
 {

     for(int i = 0; i < numbers.Length; i++)
         {
             Console.Write(numbers[i] + " ");
         }

     Console.WriteLine();
 }  

FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);

int min = numbers[0];
int max = numbers[0];

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
}
Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");


