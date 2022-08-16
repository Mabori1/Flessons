internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Friend! What you name?");
        string val = Console.ReadLine();
        if (val == null) return;
            Console.WriteLine("hi, " + val);
    }
 }