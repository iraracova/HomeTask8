// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.WriteLine("Исходный массив: ");
int[,] matrix = FillMatrixRandomNumbers();
PrintMatrix(matrix);

Console.WriteLine();

Console.WriteLine("\nОтсортированный массив: ");
OrderArrayLines(matrix);
PrintMatrix(matrix);

void OrderArrayLines(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] > matrix[i, k + 1])
        {
          int temp = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
}

int[,] FillMatrixRandomNumbers(int rows = 3, int columns = 4, int leftRange = 0, int rightRange = 10)
{
    int[,] _matrix = new int[rows, columns];
    Random rand = new Random();

    for(int i = 0; i < _matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < _matrix.GetLength(1); j ++)
        {
            _matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return _matrix;
}


void PrintMatrix(int[,] _matrix)
{
        for(int i = 0; i < _matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < _matrix.GetLength(1); j ++)
        {
            Console.Write(_matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

