Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower () == "юлияна")
{
     Console.WriteLine("Ура, это же ЮЛЬКА");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
