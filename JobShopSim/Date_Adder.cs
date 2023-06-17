namespace JobShopSim;
public class Date_Adder
{
    public Date_Adder()
    {
        Program.CurrentDate = Program.CurrentDate.AddDays(1);
        if (Program.CurrentDate.DayOfWeek == DayOfWeek.Saturday)
        {
            Program.CurrentDate = Program.CurrentDate.AddDays(2);
        }

        if (Program.CurrentDate.DayOfWeek == DayOfWeek.Sunday)
        {
            Program.CurrentDate = Program.CurrentDate.AddDays(1);
        }
        
    }
}