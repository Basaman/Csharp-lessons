Console.WriteLine("Введите целое число от 1 до 7: ");
string userInput = Console.ReadLine() ?? "";

int num = int.Parse(userInput);

if (num == 1) Console.WriteLine($"{num} -> нет");
if (num == 2) Console.WriteLine($"{num} -> нет");
if (num == 3) Console.WriteLine($"{num} -> нет");
if (num == 4) Console.WriteLine($"{num} -> нет");
if (num == 5) Console.WriteLine($"{num} -> нет");
if (num == 6) Console.WriteLine($"{num} -> Да");
if (num == 7) Console.WriteLine($"{num} -> Да");
if (num < 1 || num > 7) Console.WriteLine("Вы ввели неверное число, попробуйте еще раз");
