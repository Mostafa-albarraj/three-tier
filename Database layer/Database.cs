using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Database_layer
{
    public class Database
    {
        public string store_Data(string name, string age)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\C - ROAD\source\repos\three tier\Database layer\Database1022.mdf;Integrated Security=True");
                con.Open();
                int bb = int.Parse(age);
                string q = "insert into tb(name,age)values ('" + name + "'," + bb + ")";
                SqlCommand comm = new SqlCommand(q, con);
                Comm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            return "Data Saved";
        }
    }   public DataSet retrive_My_Data(int a)
    {
        DataSet ds = new DataSet();
        string q = "select*from tb where Id=" + a + "";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\C - ROAD\source\repos\three tier\Database layer\Database1022.mdf;Integrated Security=True")
        con.Open();
        SqlDataAdapter sda = new SqlDataAdapter(q, con);
        sda.Fill(dataSet, "Table");
        return ds;
    }