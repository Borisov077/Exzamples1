Console.WriteLine("Введите имя пользователя");
String username = Console.ReadLine();

if (username.ToLower() == "vitalii")
{
    Console.WriteLine("УРА - это Vitalii");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}