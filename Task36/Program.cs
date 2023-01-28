//Задача 36: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
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

int SunOfElaments(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}

int[] array = CreationArray(8, -100, 100);
PrintArray(array);

int result = SunOfElaments(array);
Console.WriteLine($"-> {result}");