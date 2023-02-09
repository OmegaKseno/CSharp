//*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Например, задан массив размером 2 x 2 x 2.
//Результат:
//66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
//34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] Creation3dArrayIntNumber(int line, int column, int depth)
{
    int[,,] matrix = new int[line, column,depth];
     int count = 1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
         
          for (int k = 0; k < matrix.GetLength(2); k++)
        {
         matrix[i, j,k] = count;   
         count++;
        }
       
        }
    }
    return matrix;
}
void Print3dArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine(" ") ; 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
    
           
          for (int k = 0; k < matrix.GetLength(2); k++)
        {
           Console.Write($"{matrix[i, j,k],4} ({i},{j},{k})");
            
        }
       
    }
}
}
  int [,,] arr3D = Creation3dArrayIntNumber(2, 2, 2);
  Print3dArray(arr3D);
  