Console.Write("Enter a number between 0 and 7-> ");
int NumberDay = Convert.ToInt32(Console.ReadLine());
if ( NumberDay>7|NumberDay<1)
{
Console.WriteLine("Invalid number entered. Enter a number between 0 and 7.");
}
else if(NumberDay == 1)
{
    Console.WriteLine("Mondаy");
}
else if(NumberDay == 2)
{
    Console.WriteLine("Tyesday");
}
else if (NumberDay == 3)
{
    Console.WriteLine("Wednesday");
}

else if (NumberDay == 4)
{
    Console.WriteLine("Thursday");
}
else if (NumberDay == 5)
{
    Console.WriteLine("Friday");
}
else if (NumberDay == 6)
{
    Console.WriteLine("Saturday");
}
else if (NumberDay == 7)
{
    Console.WriteLine("Sunday");
}