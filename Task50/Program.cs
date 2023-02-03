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


int SearchArrayElement(int[,] matrix, int line, int column)
{

    return matrix[line - 1, column - 1];

}

Console.Write("Введите номер строки  -> ");
int matrixLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца -> ");
int matrixColumn = Convert.ToInt32(Console.ReadLine());

int[,] array2d = Creation2dArrayIntNumber(3, 4, 0, 10);
Print2dArray(array2d);

Console.WriteLine(" ");

if (matrixLine <= array2d.GetLength(0) || matrixColumn <= array2d.GetLength(1))
{
    int result = SearchArrayElement(array2d, matrixLine, matrixColumn);
    Console.Write($"Число в этом элементе [{matrixLine}, {matrixColumn}]-> {result}");
}
else
{
    Console.Write($"[{matrixLine}, {matrixColumn}]-> такого элемента в массиве нет");
}
