//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] Creation2dArrayRealNumber(int line,int column, int min,int max )
{
    double[,] matrix = new double[line,column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.NextDouble() * (max - min) + min;
        }

    }
    return matrix;
}
void Print2dArrayRealNumber(double[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j==matrix.GetLength(1)-1)Console.Write($"{Math.Round(matrix[i,j], 1),3} ");
           else Console.Write($"{Math.Round(matrix[i,j], 1),3}| ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }

}
 Console.Write("Введите количество строк массива -> ");
 int lineMatrix = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите количество столбцов массива -> ");
 int columnMatrix = Convert.ToInt32(Console.ReadLine());

double[,] array2d = Creation2dArrayRealNumber(lineMatrix,columnMatrix, 0,10 );
Print2dArrayRealNumber(array2d);