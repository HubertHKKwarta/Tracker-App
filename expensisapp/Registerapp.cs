using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expensisapp //min29:00
{
    public partial class Registerapp : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hubertkwarta\source\repos\expensisapp\expensisapp\Expenses.mdf;Integrated Security=True;Connect Timeout=30");
        public Registerapp()
        {
            InitializeComponent();
        }
        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
        }

        private void Login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Regis_confpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_registerbutton_Click(object sender, EventArgs e)
        {
            signinform signinform = new signinform();
            signinform.Show();

            this.Hide();
        }

        private void Register_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            Reg_password.PasswordChar = Register_showpassword.Checked ? '\0' : '*';
            Regis_confpass.PasswordChar = Register_showpassword.Checked ? '\0' : '*';

        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            if (Register_username.Text == "" || Register_password.Text == "" || Register_confpass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectUserename = "SELECT * FROM users WHERE username = @usern";

                        using (SqlCommand checkUser = new SqlCommand(selectUserename, connect))
                        {
                            checkUser.Parameters.AddWithValue("@Usern", Register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            adapter.Fill(table);
                            if (table.Rows.Count != 0)
                            {
                                string tempUsern = Register_username.Text.Substring(0, 1).ToUpper() + Register_username.Text.Substring(1);
                                MessageBox.Show(tempUsern + "is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (Reg_password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password, at least 8 charakters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (Reg_password.Text != Regis_confpass.Text)
                            {
                                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string inserData = "INSERT INTO users (username, password, date_create) VALUES(@usern, @pass, @date)";

                                using (SqlCommand insertUser = new SqlCommand(inserData, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", Register_username.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", Reg_password.Text.Trim());

                                    DateTime today = DateTime.Today;
                                    insertUser.Parameters.AddWithValue("@date", today);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("Registerred succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    signinform signinform = new signinform();
                                    signinform.Show();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

      
    }
}
