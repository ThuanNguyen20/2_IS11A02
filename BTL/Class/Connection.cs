using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Class
{
    public class Connection
    {
        public static SqlConnection connect;
        public static string databaseName = "QUANGCAO";
        public static string dataSource = @".";


        public static string connectionString = @"Data Source=" + dataSource + "; Initial Catalog=" + databaseName + "; Integrated Security=True";

        public static void Open()
        {
            try
            {
                connect = new SqlConnection();
                connect.ConnectionString = connectionString;
                if (connect.State != ConnectionState.Open)
                    connect.Open();
                return;
            }

            catch (Exception ex)
            {
                Close();
                MessageBox.Show("Cant open connection, please check your connect!\n" + ex.Message);
            }
        }

        public static void Close()
        {
            try
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Cant close connection!\n" + ex.Message);
            }
        }

        public static SqlDataAdapter GetDataAdapter(string command)
        {
            Open();
            return new SqlDataAdapter(command, connect);
        }

        public static DataTable ExecuteQuery(string command)
        {
            Open();
            var adapter = new SqlDataAdapter(command, connect);
            var tableReturn = new DataTable();
            
            adapter.Fill(tableReturn);
            Close();
            return tableReturn;
        }

        public static int ExecuteSQL(string command)
        {
            Open();
            var cmd = new SqlCommand(command, connect);
            try
            {
                int rr = cmd.ExecuteNonQuery();
                Close();
                return rr;
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            Close();
            return -1;
        }
    }
}
