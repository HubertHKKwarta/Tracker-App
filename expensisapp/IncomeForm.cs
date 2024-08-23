using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace expensisapp
{
    public partial class IncomeForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hubertkwarta\source\repos\expensisapp\expensisapp\Expenses.mdf;Integrated Security=True;Connect Timeout=30";
        public IncomeForm()
        {
            InitializeComponent();

            displayCategyList();
            displayIncomeData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            
            displayCategyList();
            displayIncomeData();
        }
        public void displayIncomeData()
        {
            IncomeData iData = new IncomeData();
            List<IncomeData> listData = iData.incomeData();

            dataGridView1.DataSource = listData;
        }
        public void displayCategyList() 
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Income");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    Income_category.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Income_category.Items.Add(reader["category"].ToString());
                    }
                }
                connect.Close();
            }
        }
        private void Income_addBtn_Click(object sender, EventArgs e)
        {
            if (Income_category.SelectedIndex == -1 || Income_item.Text == "" || Income_income.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                using (SqlConnection connect = new SqlConnection(stringConnection)) 
                {
                    connect.Open();

                    string insertData = "INSERT INTO income (category, item, income, description, date_income, date_insert)" + "VALUES(@cat, @item, @income, @desc, @date_in, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", Income_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", Income_item.Text);
                        cmd.Parameters.AddWithValue("@income", Income_income.Text);
                        cmd.Parameters.AddWithValue("@desc", Income_description.Text);
                        cmd.Parameters.AddWithValue("@date_in", Income_date.Value);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connect.Close() ;
                }
            }
            displayIncomeData();
        }

        public void clearFields()
        {
            Income_item.Text = "";
            Income_category.SelectedIndex = -1;
            Income_income.Text = "";
            Income_description.Text = "";
        }
        private void Income_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void Income_updatebtn_Click(object sender, EventArgs e)
        {
            if (Income_category.SelectedIndex == -1 || Income_item.Text == "" || Income_income.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string updateData = "UPDATE income SET category = @cat, item = @item, income = @income, description = @desc, date_income = @date_in WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(updateData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", Income_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", Income_item.Text);
                        cmd.Parameters.AddWithValue("@income", Income_income.Text);
                        cmd.Parameters.AddWithValue("@desc", Income_description.Text);
                        cmd.Parameters.AddWithValue("@date_in", Income_date.Value);
                        cmd.Parameters.AddWithValue("@id", getID);



                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connect.Close();
                }
            }
            displayIncomeData();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                Income_category.SelectedItem = row.Cells[1].Value.ToString();
                Income_description.Text = row.Cells[2].Value.ToString();
                Income_item.Text = row.Cells[3].Value.ToString();
                Income_income.Text = row.Cells[4].Value.ToString();
                
                
                

                string dateValue = row.Cells[5].Value.ToString();
                if (!string.IsNullOrEmpty(dateValue))
                {
                    try
                    {
                       Income_date.Value = DateTime.ParseExact(dateValue, "dd-MM-yyyy", null);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("The date format is incorrect. Please ensure the date is in dd-MM-yyyy format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Income_deletebtn_Click(object sender, EventArgs e)
        {
            if (Income_category.Text == "" || Income_category.SelectedIndex == -1 || Income_category.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM income WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connect.Close();
                    }
                }
                displayIncomeData();
            }
        }
    }
}
