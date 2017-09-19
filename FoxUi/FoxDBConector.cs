using System;
using System.Data;
using System.Data.OleDb;

namespace FoxUi
{
    public class FoxDBConector
    {
        public void connect()
        {
            Console.Write("Coco connect");
        }
    
        public DataTable GetYourData()
        {
            DataTable YourResultSet = new DataTable();

            OleDbConnection yourConnectionHandler = new OleDbConnection(
                @"Provider=VFPOLEDB.1;Data Source=E:\work\projects\spyfox\db\");

            // Open the connection, and if open successfully, you can try to query it
            yourConnectionHandler.Open();

            if (yourConnectionHandler.State == ConnectionState.Open)
            {
                string mySQL = "select * from totcom";  // dbf table name

                OleDbCommand MyQuery = new OleDbCommand(mySQL, yourConnectionHandler);
                OleDbDataAdapter DA = new OleDbDataAdapter(MyQuery);

                DA.Fill(YourResultSet);

                yourConnectionHandler.Close();
            }

            return YourResultSet;
        }
    }
}
