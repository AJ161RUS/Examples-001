Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Виктория")
{
    Console.WriteLine("Ура, это Виктория!!!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
