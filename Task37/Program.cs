// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
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
    Console.Write(" ");
}


int[] MultyplayArray (int[]arr)
{
int size = arr.Length%2==0?arr.Length/2:arr.Length/2+1;
int secondSize = arr.Length-1;
int[] arrResult = new int[size];
for (int i = 0; i < size; i++)
{
  if(i==arr.Length-i-1)
  {
    arrResult[i]=arr[i];
  }
  else
  {
    arrResult[i]=arr[i]*arr[secondSize-i];
  }
}
return arrResult;
}
int[] array =  CreationArray(15,2,5);
PrintArray(array);
int[] ResArr= MultyplayArray (array);
Console.Write(" -> ");
PrintArray(ResArr);