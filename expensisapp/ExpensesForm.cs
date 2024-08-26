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
    public partial class ExpensesForm : UserControl
    {

        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hubertkwarta\source\repos\expensisapp\expensisapp\Expenses.mdf;Integrated Security=True;Connect Timeout=30";
        public ExpensesForm()
        {
            InitializeComponent();
            displayCategyList();
            displayExpensesData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            
            displayCategyList();
            displayExpensesData();
        }
        public void displayExpensesData()
        {
            ExpensesData eData = new ExpensesData();
            List<ExpensesData> listData = eData.expensesData();

            dataGridView2.DataSource = listData;
        }
        public void displayCategyList()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Expenses");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    Expenses_category.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Expenses_category.Items.Add(reader["category"].ToString());
                    }
                }
                connect.Close();
            }
        }

        private void Expenses_addBtn_Click(object sender, EventArgs e)
        {
            if (Expenses_category.SelectedIndex == -1 || Expenses_item.Text == "" || Expenses_cost.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(Expenses_cost.Text, @"^\d+$"))
            {
                MessageBox.Show("Please enter only numeric values in the income field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Expenses_cost.Focus(); // Set focus back to the income input field
                return;
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO expenses (category, item, cost, description, date_expense, date_insert)" + "VALUES(@cat, @item, @cost, @desc, @date_ex, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", Expenses_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", Expenses_item.Text);
                        cmd.Parameters.AddWithValue("@cost", Expenses_cost.Text);
                        cmd.Parameters.AddWithValue("@desc", Expenses_description.Text);
                        cmd.Parameters.AddWithValue("@date_ex", Expenses_date.Value);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connect.Close();
                }
            }
            displayExpensesData();
        }

        public void clearFields()
        {
            Expenses_item.Text = "";
            Expenses_category.SelectedIndex = -1;
            Expenses_cost.Text = "";
            Expenses_description.Text = "";
        }

        private void Expenses_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void Expenses_updatebtn_Click(object sender, EventArgs e)
        {
            if (Expenses_category.SelectedIndex == -1 || Expenses_item.Text == "" || Expenses_cost.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(Expenses_cost.Text, @"^\d+$"))
            {
                MessageBox.Show("Please enter only numeric values in the income field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Expenses_cost.Focus(); // Set focus back to the income input field
                return;
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string updateData = "UPDATE expenses SET category = @cat, item = @item, cost = @cost, description = @desc, date_expense = @date_ex WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(updateData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", Expenses_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", Expenses_item.Text);
                        cmd.Parameters.AddWithValue("@cost", Expenses_cost.Text);
                        cmd.Parameters.AddWithValue("@desc", Expenses_description.Text);
                        cmd.Parameters.AddWithValue("@date_ex", Expenses_date.Value);
                        cmd.Parameters.AddWithValue("@id", getID);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connect.Close();
                }
            }
            displayExpensesData();
        }
        private int getID = 0;
        private void Expenses_deletebtn_Click(object sender, EventArgs e)
        {
            if (Expenses_category.Text == "" || Expenses_category.SelectedIndex == -1 || Expenses_category.SelectedIndex == -1)
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

                        string deleteData = "DELETE FROM expenses WHERE id = @id";

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
                displayExpensesData();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                    getID = (int)row.Cells[0].Value;
                    Expenses_category.SelectedItem = row.Cells[1].Value.ToString();
                    Expenses_description.Text = row.Cells[2].Value.ToString();
                    Expenses_item.Text = row.Cells[3].Value.ToString();
                    if (row.Cells[4].Value != null)
                    {
                        // Try to parse the cell value as a decimal
                        if (decimal.TryParse(row.Cells[4].Value.ToString(), out decimal incomeValue))
                        {
                            // Format the decimal value to two decimal places
                            Expenses_cost.Text = incomeValue.ToString("N2");

                        }
                    }

                    string dateValue = row.Cells[5].Value.ToString();
                    if (!string.IsNullOrEmpty(dateValue))
                    {
                        try
                        {
                            Expenses_date.Value = DateTime.ParseExact(dateValue, "dd-MM-yyyy", null);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("The date format is incorrect. Please ensure the date is in dd-MM-yyyy format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

    }
}
