internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите имя пользователя: ");
        string username = Console.ReadLine();
        if (username.ToLower != "маша")
        {
            Console.WriteLine("Привет, " + username);
        }
        else
        {
            Console.WriteLine("Ура это же Маша!");
        }
    }
}