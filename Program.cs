namespace DPPizza;
class Program
{
    static void Main(string[] args)
    {
        string username;
        
        
        Console.WriteLine("=================================");
        Console.WriteLine("=====  Welcome to DPPizza!  =====");
        Console.WriteLine("=================================");
        Console.WriteLine("Please type your fist name and press enter:");
        username = Console.ReadLine();
        Console.WriteLine($"Thank you {username}, please select your pizza from list below (1/2/3/4):");
        Console.ReadKey(true);
    }
}
