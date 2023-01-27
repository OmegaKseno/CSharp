//Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве
//[345, 897, 568, 234] -> 2

int[] CreationArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] printArray)
{
    Console.Write("[");
    for (int i = 0; i < printArray.Length; i++)
    {

        if (i == printArray.Length - 1)
        {
            Console.Write(printArray[i]);
        }
        else
        {
            Console.Write($"{printArray[i]} , ");
        }
    }
    Console.Write("]");
    
}

int EvenNumberOfArray(int[] arr)
{
    int count= 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i]%2==0)
       {
        count++;
       }
    }
    return count;
}

int[] array= CreationArray(6,100,1000);
PrintArray(array);
int result= EvenNumberOfArray(array);
Console.Write($"-> {result}");