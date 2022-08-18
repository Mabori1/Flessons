internal class Program1
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите имя пользователя: ");
        string name =  Console.ReadLine();
        Console.WriteLine(name);
        if (name == "Маша")
            Console.WriteLine("Привет! Это же Маша!");
                else
                Console.WriteLine("Привет! " + name);



    }
}