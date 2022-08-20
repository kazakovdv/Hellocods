Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "данил")
{
    Console.WriteLine("Ура, это же Данил!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}