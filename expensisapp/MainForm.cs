using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace expensisapp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            displayUserName();
        }

        public void displayUserName()
        {
            string getUserName = signinform.username;

            usernametext.Text = getUserName.Substring(0,1).ToUpper() + getUserName.Substring(1);

        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                signinform signinform = new signinform();
                signinform.Show();

                this.Hide();
            }
        }

        private void expensesForm1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dddd1.Visible = true;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;

            DDDD dForm = dddd1 as DDDD;

            if (dForm != null)
            {
                dForm.refreshData();
            }

        }

        private void addcategory_btn_Click(object sender, EventArgs e)
        {
            dddd1.Visible = false;
            categoryForm1.Visible = true;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;

            CategoryForm cForm = categoryForm1 as CategoryForm;

            if (cForm != null)
            {
                cForm.refreshData();
            }

        }

        private void income_btn_Click(object sender, EventArgs e)
        {
            dddd1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = true;
            expensesForm1.Visible = false;

            IncomeForm iForm = incomeForm1 as IncomeForm;
            if (iForm != null)
            {
                iForm.refreshData();
            }

        }

        private void expenses_btn_Click(object sender, EventArgs e)
        {
            dddd1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = true;

            ExpensesForm eForm = expensesForm1 as ExpensesForm;

            if (eForm != null)
            {
                eForm.refreshData();
            }

        }
    }
}
