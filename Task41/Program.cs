//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3


int[]TransferStringToIntArray( string[]stringArray)
{
  int[]intArray = new int[stringArray.Length];
  for (int i = 0; i < stringArray.Length; i++)
  {
    intArray[i]=Convert.ToInt32(stringArray[i]);
  }  
  return intArray;
} 

void PrintArray(int[] printArray)
{
   // Console.Write("[");
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
   // Console.Write("]");

}

int CountAboveZero (int[] arr)
{
    int count =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0)
        {
            count++;
        }
      
    }
    return count;
}

Console.Write("Введите числа разделяя запятой или пробелом -> ");
string[] num = Console.ReadLine().Split(new char[]{',',' '});
int[] array = TransferStringToIntArray(num);
PrintArray(array);
int result = CountAboveZero(array);
Console.Write(" ->"+result);



