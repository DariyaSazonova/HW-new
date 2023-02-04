// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.


double[,] getRandomMatrix(int rows, int colums, int leftRange, int rightRange)
{
    double[,] matrix = new double[rows,colums];
    for(int i = 0; i< matrix.GetLength(0);i++)
    {
        for(int j = 0; j<matrix.GetLength(1);j++)
        {
            matrix[i,j] = Convert.ToDouble(new Random().Next(leftRange, rightRange+1))/10;
            
        }
    }
    return matrix;
}
void printMatrix(double[,] matrix)
{
    for(int i = 0; i< matrix.GetLength(0);i++)
    {
        for(int j = 0; j<matrix.GetLength(1);j++)
        {
           Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] array = getRandomMatrix(3,4,0,10);
printMatrix(array);