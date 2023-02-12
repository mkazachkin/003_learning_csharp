Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine()!;
if ((userName.ToLower() == "миша") | (userName.ToLower() == "Михаил"))
{
    Console.WriteLine("Ура! Хозяин пришел! Привет, Миша!");
}
else
{
    Console.WriteLine("Здравствуйте, " + userName + "!");
}