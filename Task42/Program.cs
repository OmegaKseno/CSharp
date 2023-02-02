//Задача 42: Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10
Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int IntToBool(int num)
{
    int res = 0;
    int temp = 1;
    while(num>0)
    {
      res = res + (num%2*temp);
      num = num/2;
      temp*=10;

    }
    return res;
}
int result = IntToBool(number);
Console.Write(result);