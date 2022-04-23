Console.WriteLine("Введите номер четверти");
int num;
num = int.Parse(Console.ReadLine());
if (num == 1)
{
    Console.WriteLine("Диапазон возможных координат Х: от 0 до бесконечности, Y: от 0 до бесконечности");
}
else if (num == 2)
{
    Console.WriteLine("Диапазон возможных координат Х: от 0 до бесконечности, Y: от - бесконечности до 0");
}
else if (num == 3)
{
    Console.WriteLine("Диапазон возможных координат Х: от - бесконечности до 0, Y: от - бесконечности до 0");
}
else if (num == 4)
{
    Console.WriteLine("Диапазон возможных координат Х: от - бесконечности до 0, Y: от 0 до бесконечности");
}
else
{
    Console.WriteLine("Такой плоскости не сущестует");
}
