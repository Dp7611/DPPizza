namespace DPPizza;
class Program
{

    static void Main(string[] args)
    {
        welcome();
    }

    static void welcome()
    {
        string userName;
        string pizzatypeName;
        string toppingName;
        string pizzabaseName;
        

        Console.WriteLine("=================================");
        Console.WriteLine("=====  Welcome to DPPizza!  =====");
        Console.WriteLine("=================================");
        Console.WriteLine("Please type your fist name and press enter:");
        userName = Console.ReadLine();
        Console.WriteLine($"Thank you {userName}, please select your £5 pizza from list below:");
        Console.WriteLine("Margherita   £5");
        Console.WriteLine("Pepperoni    £5");
        Console.WriteLine("Vegetarian   £5");
        pizzatypeName = Console.ReadLine();
        Console.WriteLine($"Thank you {userName}, you have selected a {pizzatypeName} pizza.");
        Console.WriteLine("Please select additional £1 toppings from list below:");
        Console.WriteLine("Pepperoni    £1");
        Console.WriteLine("Mushrooms    £1");
        Console.WriteLine("Onions       £1");
        Console.WriteLine("Peppers      £1");
        Console.WriteLine("Sweetcorn    £1");
        toppingName = Console.ReadLine();
        Console.WriteLine($"Thank you {userName}, you have selected a {pizzatypeName} pizza with additional toppings {toppingName}");
        Console.WriteLine("Please now select your preferred type of base from list below:");
        Console.WriteLine("Thin");
        Console.WriteLine("Deep Pan");
        Console.WriteLine("Gluten Free");
        pizzabaseName = Console.ReadLine();
        Console.WriteLine($"Thank you {userName}. You have chosen a {pizzatypeName} pizza with additional toppings {toppingName} on a {pizzabaseName} base.");
        Console.WriteLine("Please press any key to end program:");
        Console.ReadKey(true);

    }
}
