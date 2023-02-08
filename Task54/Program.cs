﻿//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
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

void SortRowe(int[,] matrix)
{
  int temp = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
    {
       
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          int indexMax = 0;
          for(int k = 1;k<matrix.GetLength(1); k++ )
          {
            if(matrix[i,indexMax]<matrix[i,k])
            {
              temp = matrix[i,indexMax];
              matrix[i,indexMax]=matrix[i,k];
              matrix[i,k]=temp;
              indexMax++;
            }
            else
            {
              indexMax++;
            }
            
          }
    
        }
   
    }
}

int[,]array2D = Creation2dArrayIntNumber(4, 5, -10, 20);
Print2dArray(array2D);
SortRowe(array2D);
Console.WriteLine("Ответ");
Print2dArray(array2D);