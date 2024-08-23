using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace expensisapp
{
    internal class CategoryData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hubertkwarta\source\repos\expensisapp\expensisapp\Expenses.mdf;Integrated Security=True;Connect Timeout=30";
        
        public int ID { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        public string Date {  get; set; }

        public List<CategoryData> categoryListData()
        {
            List<CategoryData> listData = new List<CategoryData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoryData cData = new CategoryData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Type = reader["type"].ToString();
                        cData.Status = reader["status"].ToString();
                        DateTime dateValue = Convert.ToDateTime(reader["date_insert"]);
                        cData.Date = dateValue.ToString("dd-MM-yyyy"); // Format date here
                        listData.Add(cData);
                    }

                }
                connect.Close();
            }
            return listData;
        }   
    }
}
