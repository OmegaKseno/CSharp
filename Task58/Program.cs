//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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

int[,] ProductOfMatrices (int[,] firstArray,int[,] secondArray)
{
int sizeLine = firstArray.GetLength(0);
int sizeColumn = secondArray.GetLength(1);
if(firstArray.GetLength(0)>secondArray.GetLength(0))sizeLine =  secondArray.GetLength(1);
if(secondArray.GetLength(1)>firstArray.GetLength(1))sizeColumn = firstArray.GetLength(1);
int[,] resultArray2d = new int[sizeLine,sizeColumn];
 for (int i = 0; i < sizeLine; i++)
    {
        for (int j = 0; j < sizeColumn; j++)
        {
            
           for (int k = 0; k < sizeColumn; k++)
            {
             resultArray2d[i,j]+=  firstArray [i,k] *  secondArray [k,j] ;
            
            }
        }
    }
 
return resultArray2d;
}

Console.WriteLine("Первая матрица:");
int[,]array2DFirst = Creation2dArrayIntNumber(3, 2, 1, 5);
Print2dArray(array2DFirst);
Console.WriteLine("Вторая матрица:");
int[,]array2DSecond = Creation2dArrayIntNumber(2, 3, 1, 5);
Print2dArray(array2DSecond);
Console.WriteLine("результат  нахождения произведения двух матриц :");
if(array2DFirst.GetLength(1)==array2DSecond.GetLength(0))
{
 int[,] resultARR2 =ProductOfMatrices (array2DFirst,array2DSecond);

Print2dArray(resultARR2);   
}
else
{
    Console.Write("Число столбцов первой матрицы не равно числу строк второй матрицы, умножение невозможно.");
    
}

