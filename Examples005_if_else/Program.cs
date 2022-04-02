Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "карина")
{
    Console.Write("Ну наконец-то, рады видеть, ");
    Console.WriteLine(username);
}
else
{
    Console.Write("Ну вот и приперся, не ждали... "); 
    Console.WriteLine(username);
}