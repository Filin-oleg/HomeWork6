// Задайте двумерный массив со случайными числами от -10 до 10. 
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

Console.Clear();
Console.WriteLine("Введите количество строк двумерного массива ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
void fillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"   {matr[i, j]}   ");
        }
        Console.WriteLine();
    }
}
fillMatrix(matrix);
PrintMatrix(matrix);
int Sums(int[,] matrix)
{
    int Sum = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        Sum += matrix[i, i];
    }
    return Sum;
}
Console.WriteLine("Сумма элементов, находящихся на главной диагонали массива = " + Sums(matrix));