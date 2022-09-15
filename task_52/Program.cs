// Задайте двухмерный массив из целых чисел.
// Найти среднее арефмитическое в каждом столбце.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n, int minRandom, int maxRandom)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        // i, m, k, j
        for (int j = 0; j < n; j++) 
        {
            matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); 
        }
    Console.WriteLine();
    }
}

int[,] resultMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(resultMatrix);
for (int j = 0; j < resultMatrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        avarage = (avarage + resultMatrix[i, j]);
    }
    avarage = avarage / columns;
    Console.Write(avarage + "\t");
}
