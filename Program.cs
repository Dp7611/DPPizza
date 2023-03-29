namespace DPPizza;
class Program
{

        

    static void Main(string[] args)
    {
        string username;
        string pizzatypename;

        Console.WriteLine("=================================");
        Console.WriteLine("=====  Welcome to DPPizza!  =====");
        Console.WriteLine("=================================");
        Console.WriteLine("Please type your fist name and press enter:");
        username = Console.ReadLine();
        Console.WriteLine($"Thank you {username}, please select your pizza from list below:");
        Console.WriteLine("Margherita");
        Console.WriteLine("Pepperoni");
        Console.WriteLine("Vegetarian");
        pizzatypename = Console.ReadLine();
        Console.WriteLine($"Thank you {username}, you have selected {pizzatypename}");
        Console.WriteLine("Please confirm if this is the correct pizza for you today (y/n):");
        Console.ReadKey(true);
    }
}
