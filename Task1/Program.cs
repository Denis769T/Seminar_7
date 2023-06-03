// //  Задайте двумерный массив размером m×n,
// //  заполненный случайными вещественными числами.

// // m = 3, n = 4.

// // 0,5 7 -2 -0,2

// // 1 -3,3 8 -9,9

// // 8 7,8 -7,1 9


int ReadInt(string text)//Вывод строки м преобразование введенных данных в число.
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double [,] FillMatrix(int row, int col /*, int leftRange, int rightRange*/)
{
    double[,] matrix = new double[row, col];
    Random rand = new Random();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           //matrix[i, j] = Math.Round(rand.Next(-1000, 1001) * 0.1, 1);
           matrix[i,j] = Convert.ToDouble(rand.Next(-1000, 1000)/10.0 );
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix) // Вывод массива.
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

double[,] matrix = FillMatrix(ReadInt("Введите количество строк: "),
 ReadInt("Введите количество столбцов: ")/*, 0, 10*/);
PrintMatrix(matrix);
