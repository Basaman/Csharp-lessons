//Напишите программу, которая принимает на вход координаты точки (X и Y), причем они не рвны 0
//и выдает номер четверти  плоскости где находится эта точка

Console.Clear();
Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine()); //перевод в целочисленное значение

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine());

if(X > 0 && Y > 0)
{
    Console.WriteLine("1");
}
else if(X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
else if(X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
else if(X > 0 && Y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}