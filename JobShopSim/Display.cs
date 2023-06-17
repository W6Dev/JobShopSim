using System.Reflection;
namespace JobShopSim;
public class Display
{
    public static Display Instance
    {
        get { return instance; }
    }

    private static Display instance;

    public Display()
    {
        instance = this;

        Console.Clear();
        DisplayTitle();

        Date_Adder date_Adder = new Date_Adder();
        Worker worker = new Worker();

        Console.WriteLine(Program.CurrentDate.ToString());
        Console.WriteLine("Press SPACEBAR to start");
      
    }

    public static void DisplayTitle()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Job Shop Simulator");
        Console.BackgroundColor = ConsoleColor.Black;
    }
}