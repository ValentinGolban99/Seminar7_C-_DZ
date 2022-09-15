// Напишите программу, которая принимает на вход позиции элемента в двухмерном массиве,
// и возвращает значение этого элемента или указание, что такого элемента нет.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер строки: ");
int rowsValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int columnsValue = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n, int minRandom, int maxRandom)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
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
int FindingElement(int[,] inputMatrix)
{
    int element = 0;
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            if (i == rowsValue - 1 && j == columnsValue - 1)
            {
                element = inputMatrix[i, j];
            }
            else
            {
                element = -1;
            }
        }
    }
    return element;
}
int[,] resultMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(resultMatrix);
Console.WriteLine();
Console.WriteLine(FindingElement(resultMatrix));
