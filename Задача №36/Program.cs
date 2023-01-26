// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

int ReadNumber(string message)
 {
     Console.WriteLine(message);
     return Convert.ToInt32(Console.ReadLine());
 }

 int size = ReadNumber($"Введите длину массива: ");

 int[] numbers = new int[size];

 FillArrayRandomNumbers(numbers);
 Console.WriteLine("массив: ");
 PrintArray(numbers);
 int sum = 0;

 for (int z = 1; z < numbers.Length; z+=2)
     sum = sum + numbers[z];

     Console.WriteLine($"Cумма элементов cтоящих на нечётных позициях = {sum}");

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

 //не получается запушить  

