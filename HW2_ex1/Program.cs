Console.WriteLine("Введите трёхзначное число: ");
string userInput = Console.ReadLine() ?? "";

int num = int.Parse(userInput);

if (num < 100 || num > 999)
{
    Console.WriteLine("Число не является трёхзначным, попробуйте еще раз");
}
else
{
    int num1 = num % 100;
    int num2 = num1 % 10;
    int num3 = (num1 - num2)/10;
    Console.WriteLine ($"{num} -> {num3}");
}
