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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace expensisapp
{
    public partial class signinform : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hubertkwarta\source\repos\expensisapp\expensisapp\Expenses.mdf;Integrated Security=True;Connect Timeout=30");
        public signinform()
        {
            InitializeComponent();
        }
        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_registerbutton_Click(object sender, EventArgs e)
        {
            Registerapp registerapp = new Registerapp();
            registerapp.Show();

            this.Hide();

        }

        public static string username;

        private void Loggin_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hubertkwarta\source\repos\expensisapp\expensisapp\Expenses.mdf;Integrated Security=True;Connect Timeout=30")) 
            {
                connect.Open();

                string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", Login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", Login_password.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        username = Login_username.Text;
                        MessageBox.Show("Login successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainForm mForm = new MainForm();
                        mForm.Show();

                        this.Hide();
                    }
                    else 
                    {
                        MessageBox.Show("Incorrect username or password", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                connect.Close();
            }
        }

        private void Login_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            Login_password.PasswordChar = Login_showpassword.Checked ? '\0' : '*';
        }

    }
}