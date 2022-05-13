// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0");
Console.WriteLine("Введите число x");
int numX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число y");
int numY = int.Parse(Console.ReadLine());
if(numX > 0 && numY > 0)
{
    Console.WriteLine("Координаты находятся в 1 четверти");
}
else if (numX < 0 && numY > 0)
{
    Console.WriteLine("Координаты находятся в 2 четверти");
}
else if (numX < 0 && numY < 0)
{
    Console.WriteLine("Координаты находятся в 3 четверти");
}
else if (numX > 0 && numY < 0)
{
    Console.WriteLine("Координаты находятся в 4 четверти");
}
else
{
    Console.WriteLine("Координаты введены не верно");
}


