Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";

int number = int.Parse(userInput);
int result = (int)Math.Pow(number, 3);

Console.WriteLine($"{number} -> {result}");
