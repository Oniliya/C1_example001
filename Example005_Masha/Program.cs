// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя: ");
string user_name = Console.ReadLine();
if (user_name.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(user_name);
}