//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число (N) ->");
int digital = Convert.ToInt32(Console.ReadLine());
PrintSquares(digital);



void PrintSquares(int number)
{
int temp = 1;
while(temp<=number)
{
    Console.WriteLine($"{temp,5},{temp*temp*temp,5}  ");
    temp++;

}
}