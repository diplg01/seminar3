// задача 1
int X, Y;
X = new Random().Next(-100, 100);
Y = new Random().Next(-100, 100);
Console.WriteLine($" X = {X}, Y = {Y}");

if (X == 0 | Y == 0)
{
    Console.WriteLine("Не пренадлежит какой либо конкретной плоскости");
}
else if (X > 0 & Y > 0)
{
    Console.WriteLine("Пренадлежит плоскости 1");
}
else if (X > 0 & Y < 0)
{
    Console.WriteLine("Пренадлежит плоскости 2");
}
else if (X < 0 & Y < 0)
{
    Console.WriteLine("Пренадлежит плоскости 3");
}
else if (X < 0 & Y > 0)
{
    Console.WriteLine("Пренадлежит плоскости 4");
}