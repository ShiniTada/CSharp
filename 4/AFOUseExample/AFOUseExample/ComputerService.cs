using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFOUseExample
{
    class ComputerService
    {
        string con = "Data Source=ADMIN-PK\\SQLEXPRESS;Initial Catalog=storedb;Integrated Security=True";
        SqlConnection myConnection;

        public ComputerService()
        {
            myConnection = new SqlConnection(con);
            myConnection.Open();
        }

        public List<Computer> GetComputers()
        {
            List<Computer> comps = new List<Computer>();

            string oString = "Select * from store";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    comps.Add(new Computer(oReader["Date"].ToString(),
                    oReader["Type"].ToString(),
                    int.Parse(oReader["Amount"].ToString())));
                }
            }
            return comps;
        }

        public void DeleteComputer(string type, string date)
        {
            string oString = "delete from store where Type = @type and Date = @date";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            oCmd.Parameters.AddWithValue("@type", type);
            oCmd.Parameters.AddWithValue("@date", date);
            oCmd.ExecuteNonQuery();
        }

        public void AddComputer(Computer comp)
        {
            string oString = "insert into STORE values(@date, @type, @amount);";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            oCmd.Parameters.AddWithValue("@date", comp.Date);
            oCmd.Parameters.AddWithValue("@type", comp.Type);
            oCmd.Parameters.AddWithValue("@amount", comp.Amount);
            oCmd.ExecuteNonQuery();
        }

    }
}
