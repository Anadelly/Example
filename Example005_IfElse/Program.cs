Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
System.Console.WriteLine(username);

if(username == "Маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}