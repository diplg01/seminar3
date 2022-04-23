// задание 3 ищем растояние между двумя точками 
int x1 = 3;
int y1 = 6;
int x2 = 2;
int y2 = 1;

int length = (int)Math.Sqrt(Math.Pow (x1-x2,2) + Math.Pow (y1-y2, 2));
Console.WriteLine(length);