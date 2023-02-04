//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] Creation2dArrayIntNumber(int line, int column, int min, int max)
{
    int[,] matrix = new int[line, column];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void Print2dArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}
string ReplaceDotComma(double num)
{

    string str = Convert.ToString(Math.Round(num, 2));
    str = str.Replace(",", ".");
    return str;

}
void PrintArrayDouble(double[] printArray)
{
    Console.Write("[");
    for (int i = 0; i < printArray.Length; i++)
    {
        if (i == printArray.Length - 1)
        {
            Console.Write(ReplaceDotComma(printArray[i]));
        }
        else
        {
            Console.Write($"{ReplaceDotComma(printArray[i])}, ");
        }
    }
    Console.Write("]");

}

double[] ArithmeticMeanArray(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arr[j] += matrix[i, j];
        }
        arr[j] /= matrix.GetLength(0);
    }
    return arr;
}




int[,] array2d = Creation2dArrayIntNumber(3, 4, 1, 10);
Print2dArray(array2d);
double[] array = ArithmeticMeanArray(array2d);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(array);