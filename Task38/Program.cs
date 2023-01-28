//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным
//элементами массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreationArrayDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] printArray)
{
    Console.Write("[");
    for (int i = 0; i < printArray.Length; i++)
    {
        if (i == printArray.Length - 1)
        {
            Console.Write(ReplaceDotComma(printArray[i]));
            //Console.Write(Math.Round(printArray[i], 1));
        }
        else
        {

            Console.Write($"{ReplaceDotComma(printArray[i])}, ");
        }
    }
    Console.Write("]");

}

double DifferenceMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];

        if (arr[i] > max) max = arr[i];
    }

    return max - min;
}
string ReplaceDotComma(double num)
{

string str = Convert.ToString(Math.Round(num, 1));
str=str.Replace(",",".");
return str;
    
}

double[] array = CreationArrayDouble(6, 1, 100);
PrintArrayDouble(array);
string result = ReplaceDotComma(DifferenceMinMax(array));
Console.Write($" -> {result}");
