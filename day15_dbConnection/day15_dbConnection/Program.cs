using day15_dbConnection;

class program
{
    public static void Main(string[] args)
    {
        Connection conn1 = new Connection();
        //Console.WriteLine("Categories before Inserting!");
        //conn1.ReadData();
        //conn1.InsertData();
        //Console.WriteLine("Catrgories after Inserting");
        //conn1.ReadData();

        //Console.WriteLine("Categories after updating data");
        //conn1.UpdateData();
        //conn1.ReadData();

        Console.WriteLine("Categories after deleting data");
        conn1.DeleteData();
        conn1.ReadData();
    }
}