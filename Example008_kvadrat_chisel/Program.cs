Console.Write("Введите целое число: ");

int number = int.Parse(Console.ReadLine() ?? "");
int result = (int)Math.Pow(number, 3);

Console.WriteLine($"{number} -> {result}");
