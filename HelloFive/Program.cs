Console.WriteLine("Введите имя пользователя");
string UserName = Console.ReadLine();

if (UserName.ToLower() == "маша")
{ 
    Console.WriteLine("ЗДАРОВА, МАХЕЕВЪ!!!");


} 
else
{
    Console.WriteLine("Тебе тут не рады, " + UserName);
}