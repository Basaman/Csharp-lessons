//Напишите программу, которая принимает на вход координаты точки (X и Y), причем они не рвны 0
//и выдает номер четверти  плоскости где находится эта точка

Console.Clear();
int X = 0, Y = 0;
InitCoordinatesByUser(ref X, ref Y); //Вызов Метода с передачей параметров по ссылке (ref)
PrintQuarterByCoords(X, Y); //Выов метода с передачей параметров по значению

static void InitCoordinatesByUser(ref int X, ref int Y) //static void метод возвращаемого значения.
{
    try
    {
        Console.Write("Введите X:");
        X = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите Y:");
        Y = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}
static void PrintQuarterByCoords(int X, int Y)
{
if(X > 0 && Y > 0)
    Console.WriteLine("1");
else if(X < 0 && Y > 0)
    Console.WriteLine("2");
else if(X < 0 && Y < 0)
    Console.WriteLine("3");
else if(X > 0 && Y < 0)
    Console.WriteLine("4");
else
    Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}
