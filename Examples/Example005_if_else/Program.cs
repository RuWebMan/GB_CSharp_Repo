Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Это же Маша!!!");
}
else
{
    Console.WriteLine($"Не демон ли ты  {username} ?");
}
