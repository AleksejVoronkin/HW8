// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//6 16
//9 6

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      resultMatrix[i,j] = firstMartrix[i,j]*secomdMartrix[i,j];
    }
  }
}
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.WriteLine("Введите размер массива a x b");
Console.WriteLine("Введите a");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
int n = Convert.ToInt32(Console.ReadLine());

int[,] firstMartrix = new int[m, n];
Console.WriteLine($"\nПервая матрица:");
CreateArray(firstMartrix);

int[,] secomdMartrix = new int[m, n];
Console.WriteLine($"\nВторая матрица:");
CreateArray(secomdMartrix);

int[,] resultMatrix = new int[m,n];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);
