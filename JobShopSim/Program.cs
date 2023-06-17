namespace JobShopSim;

public class Program
{
    public static DateOnly StartDate = new DateOnly(2020, 1, 1);
    public static DateOnly CurrentDate = StartDate;
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Experiment 1-001");
        Console.WriteLine("Press SPACEBAR to start");

        while (Console.ReadKey().Key == ConsoleKey.Spacebar)
        {
            Display display = new Display();
        }
        
    }
}