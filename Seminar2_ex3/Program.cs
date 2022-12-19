Console.WriteLine ("Введите число 1: ");
string userInput1 = Console.ReadLine() ?? "";
Console.WriteLine ("Введите число 2: ");
string userInput2 = Console.ReadLine() ?? "";

int a1 = int.Parse(userInput1);
int a2 = int.Parse(userInput2);

if (a1 % a2 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    int result = a1 % a2;
    Console.WriteLine(result);
}
