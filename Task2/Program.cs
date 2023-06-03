//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int stroki,stolb;

int[,] matrix = FillMatrix(stroki=ReadInt("Введите количество строк: "),
stolb=ReadInt("Введите количество столбцов: "), 0, 20);
PrintMatrix(matrix);

int i=ReadInt("Вводим позицию элемента в массиве. Введите номер строки I=" );
int j=ReadInt("Введите номер столбца J=");

if (i <= stroki && j <= stolb)
{
Console.Write($"Элемент массива. [{i},{j}] = {matrix[i-1,j-1]}");
}
else
{
    Console.WriteLine("Элемента массива с такими характеристиками нет");
}
