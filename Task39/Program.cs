//Задача 39: Напишите программу, которая перевернёт
//одномерный массив (последний элемент будет на первом
//месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
int[] CreatArray (int size,int min ,int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0;i<size;i++) 
    {

        arr[i] = rnd.Next(min,max);
    } 
return arr;
}
void PrintArray (int[] arr)
{
    Console.Write("[");
for(int i =0;i<arr.Length;i++)
{
    if(arr.Length-1 == i)
    {
        Console.Write(arr[i]);
    }
    else
    {
        Console.Write($"{arr[i]}, ");
    }
}
 Console.Write("]");
}
void CoupArray(int[] arr)
{
  int temp = 0;
  for(int i = 0;i<arr.Length/2;i++)
  {
     temp = arr[i];
    arr[i]= arr[arr.Length-i-1];
    arr[arr.Length-i-1]=temp;
  }
}

int[] array = CreatArray(6,1,9);
PrintArray(array);
CoupArray(array);
Console.WriteLine(" ");
PrintArray(array);