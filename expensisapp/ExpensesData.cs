using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace expensisapp
{
    internal class ExpensesData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hubertkwarta\source\repos\expensisapp\expensisapp\Expenses.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Item { get; set; }
        public string Cost { get; set; }
        public string Date_expenses { get; set; }
        public List<ExpensesData> expensesData()
        {
            List<ExpensesData> listData = new List<ExpensesData>();
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT *FROM expenses";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ExpensesData eData = new ExpensesData();
                        eData.ID = (int)reader["id"];
                        eData.Category = reader["category"].ToString();
                        eData.Item = reader["item"].ToString();
                        eData.Cost = reader["cost"].ToString();
                        eData.Description = reader["description"].ToString();
                        eData.Date_expenses = ((DateTime)reader["Date_expense"]).ToString("dd-MM-yyyy");

                        listData.Add(eData);
                    }
                }
                connect.Close();
            }
            return listData;
        }
    }
}
