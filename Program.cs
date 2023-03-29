namespace DPPizza;
class Program
{

    static void Main(string[] args)
    {
        welcome();
    }

    static void welcome()
    {
        string username;
        string pizzatypename;
        string toppingname;
        string pizzabase;
        

        Console.WriteLine("=================================");
        Console.WriteLine("=====  Welcome to DPPizza!  =====");
        Console.WriteLine("=================================");
        Console.WriteLine("Please type your fist name and press enter:");
        username = Console.ReadLine();
        Console.WriteLine($"Thank you {username}, please select your £5 pizza from list below:");
        Console.WriteLine("Margherita   £5");
        Console.WriteLine("Pepperoni    £5");
        Console.WriteLine("Vegetarian   £5");
        pizzatypename = Console.ReadLine();
        Console.WriteLine($"Thank you {username}, you have selected a {pizzatypename} pizza.");
        Console.WriteLine("Please select additional £1 toppings from list below:");
        Console.WriteLine("Pepperoni    £1");
        Console.WriteLine("Mushrooms    £1");
        Console.WriteLine("Onions       £1");
        Console.WriteLine("Peppers      £1");
        Console.WriteLine("Sweetcorn    £1");
        toppingname = Console.ReadLine();
        Console.WriteLine($"Thank you {username}, you have selected a {pizzatypename} pizza with additional toppings {toppingname}, please now select your preferred type of base from list below:");
        Console.WriteLine("Thin");
        Console.WriteLine("Deep Pan");
        Console.WriteLine("Gluten Free");
        pizzabase = Console.ReadLine();
        Console.WriteLine($"Thank you {username}. You have chosen a {pizzatypename} pizza with additional toppings {toppingname} on a {pizzabase} base.");
        Console.WriteLine("Please confirm if this is the correct pizza for you today (y/n):");
        Console.ReadKey(true);

    }
}
