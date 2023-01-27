//32: Напишите программу замена элементов массива:
//положительные элементы замените на отрицательные и наоборот.
//[-1]->[1]
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
void ReplacementNumber(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *=-1; 
    }
}

int[] array = CreationArray(4,-5,5);
PrintArray(array);
ReplacementNumber(array);
PrintArray(array);
