using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace expensisapp
{
    internal class IncomeData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hubertkwarta\source\repos\expensisapp\expensisapp\Expenses.mdf;Integrated Security=True;Connect Timeout=30";
    
        public int ID {  get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Item {  get; set; }
        public string Cost { get; set; }
        public string Dateincome { get; set; }

        public List<IncomeData> incomeData() 
        {
            List<IncomeData> listData = new List<IncomeData>();
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT *FROM income";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        IncomeData iData = new IncomeData();
                        iData.ID = (int)reader["id"];
                        iData.Category = reader["category"].ToString();
                        iData.Item = reader["item"].ToString();
                        iData.Cost = reader["income"].ToString();
                        iData.Description = reader["description"].ToString();
                        iData.Dateincome = ((DateTime)reader["Date_income"]).ToString("dd-MM-yyyy");

                        listData.Add(iData);
                    }
                }
                connect.Close();
            }
            return listData;
        }
    }
}
