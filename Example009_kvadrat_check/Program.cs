Console.Write("Введите целое число: ");
string userInput_1 = Console.ReadLine();
Console.Write("Введите второе целое число: ");
string userInput_2 = Console.ReadLine();

int number_1 = int.Parse(userInput_1);
int number_2 = int.Parse(userInput_2);

if (number_1 == number_2 * number_2)
{
    Console.WriteLine ("Yes");
}
else
{
    Console.WriteLine ("No");
}
