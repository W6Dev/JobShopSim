using Microsoft;
using Microsoft.Data.SqlClient;

namespace JobShopSim;

public class Worker
{
    static void GenTime()
    {
        int WorkerID = 11001;
        string WorkCenterID = "MULTI001";
        string JobID = "";
        
        Connect();
        
        ;
        
    }

    private void enterTime()
    {
        Program.CurrentDate.ToString();
        
    }
    
    

    static void Connect()
    {
        string constr;

        constr = Data.constr;
        
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        Console.WriteLine("Connected");
    }

    public static void Close()
    {
        string constr;
        constr = Data.constr;

        SqlConnection con = new SqlConnection(constr);
        con.Close();
    }
}