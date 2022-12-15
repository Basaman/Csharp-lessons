Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine() ?? "";

if(username.ToLower() == "сергей")
{
    Console.WriteLine("Ура, это же Сергей!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
