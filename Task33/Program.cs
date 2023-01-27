//33: Задайте массив , написать программу присутствует ли число в массиве.


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
    Console.WriteLine(" ");
}
bool CheckNumber(int[] arr,int num)
{
for (int i = 0; i < arr.Length; i++)
{
   if(arr[i]==num)
   {
    return true;
   }
}
 return false;
}

Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = CreationArray(5,0,4);
PrintArray(array);
bool status = CheckNumber(array,number);
Console.Write(status?" -> Yes":" -> No");
