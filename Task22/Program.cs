//Напишите программу которая на вход принемает число (N)
//и выдает таблицу квадратов чисел от 1 до N.
//5-> 1,4,9,16,25
Console.Write("Введите число (N) ->");
int digital = Convert.ToInt32(Console.ReadLine());
PrintSquares(digital);
void PrintSquares(int number)
{
int temp = 1;
while(temp<=number)
{
    Console.WriteLine($"| {temp}|{temp*temp}   ");
    temp++;
    Console.WriteLine("|__|___|");
}
}