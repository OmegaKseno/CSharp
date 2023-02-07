// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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
void StringReplacement(int[,]matrix)
{
int temp =0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    temp =  matrix[0,i];
    matrix[0,i]= matrix[matrix.GetLength(0)-1,i];
    matrix[matrix.GetLength(0)-1,i]=temp;
}


}

int[,] array2d=Creation2dArrayIntNumber(3, 3, 1, 10);
Print2dArray(array2d);
StringReplacement(array2d);
Console.WriteLine("Ответ");
Print2dArray(array2d);
