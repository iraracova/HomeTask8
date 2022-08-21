// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] firstMatrix = FillMatrixRandomNumbers();

Console.WriteLine("Первая матрица:");
PrintMatrix(firstMatrix);
Console.WriteLine();

int[,] secondMatrix = FillMatrixRandomNumbers();

Console.WriteLine("Вторая матрица:");
PrintMatrix(secondMatrix);

int[,] resultMatrix = new int[3, 3];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine("\nПроизведение первой и второй матриц:");
PrintMatrix(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
        int sum = 0;
        for (int k = 0; k < firstMatrix.GetLength(0); k++)
        {
            sum += firstMatrix[i,k] * secondMatrix[k,j];
        }
        resultMatrix[i,j] = sum;
    }
  }
}

int[,] FillMatrixRandomNumbers(int rows = 3, int columns = 3, int leftRange = 0, int rightRange = 10)
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

