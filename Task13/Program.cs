Console.WriteLine("Введите координаты X точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки A: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());


double distance = Math.Round(Distance(xa, ya, za, xb, yb, zb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {distance}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return dist;
}