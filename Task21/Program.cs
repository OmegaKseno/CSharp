
Console.WriteLine("Введите координаты точки A: ");
Console.Write("X1: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Y1: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Z1: ");
double az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X2: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Y2: ");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write("Z2: ");
double bz = Convert.ToDouble(Console.ReadLine());

double dist = Distans(ax, ay,az, bx, by,bz);

Console.WriteLine(Math.Round(dist, 2, MidpointRounding.ToZero));

double Distans(double x1, double y1,double z1, double x2, double y2,double z2)
{
    double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)+ (z2 - z1) * (z2 - z1));
    return result;
}

