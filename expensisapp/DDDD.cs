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
    public partial class DDDD : UserControl
    {

        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hubertkwarta\source\repos\expensisapp\expensisapp\Expenses.mdf;Integrated Security=True;Connect Timeout=30";

        public DDDD()
        {
            InitializeComponent();
            incomeTodayincome();
            incomeYesterdayincome();
            incomeThisMonthincome();
            incomeThisMYearincome();
            totalincome();


            expensesTodaycost();
            expensesYesterdaycost();
            expensesThisMonthcost();
            expensesThisMYearcost();
            totalcost();

        }

        public void refreshData() 
        {
            if (InvokeRequired) 
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            InitializeComponent();
            incomeTodayincome();
            incomeYesterdayincome();
            incomeThisMonthincome();
            incomeThisMYearincome();
            totalincome();


            expensesTodaycost();
            expensesYesterdaycost();
            expensesThisMonthcost();
            expensesThisMYearcost();
            totalcost();
        }
        public void incomeTodayincome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(income) FROM income WHERE date_income = @date_in";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in", today);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal todaycost = Convert.ToDecimal(result);
                        income_todayincome.Text = todaycost.ToString("N2") + "zl";
                    }
                    else
                    {
                        income_todayincome.Text = "0.00zl";
                    }
                }

            }
           
        }
        public void incomeYesterdayincome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(income) FROM income WHERE CONVERT(DATE, date_income) = DATEADD(day, DATEDIFF(day, 0, GETDATE()), -1)";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal yesterdaycost = Convert.ToDecimal(result);
                        income_yesterdayincome.Text = yesterdaycost.ToString("N2") + "zl" ;
                    }
                    else
                    {
                        income_yesterdayincome.Text = "0.00zl";
                    }
                }


            }

        }
        public void incomeThisMonthincome() 
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startMonth AND date_income <= @endMonth";
                using (SqlCommand cmd = new SqlCommand(query, connect)) 
                {
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthcost = Convert.ToDecimal(result);
                        income_thismonthincome.Text = monthcost.ToString("N2") + "zl";
                    }
                    else
                    {
                        income_thismonthincome.Text = "0.00zl";
                    }
                }
                
            }
            
        }
        public void incomeThisMYearincome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year,1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startYear AND date_income <= @endYear";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearcost = Convert.ToDecimal(result);
                        income_thisyearincome.Text = yearcost.ToString("N2") + "zl";
                    }
                    else
                    {
                        income_thisyearincome.Text = "0.00zl";
                    }
                }

            }

        }
        public void totalincome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(income) FROM income";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalincome = Convert.ToDecimal(result);
                        income_totalincome.Text = totalincome.ToString("N2") + "zl";
                    }
                    else
                    {
                        income_totalincome.Text = "0.00zl";
                    }
                }

            }

        }

        //EXPENSES
        public void expensesTodaycost()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense = @date_ex";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_ex", today);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal todaycost = Convert.ToDecimal(result);
                        expenses_todayexpenses.Text = todaycost.ToString("N2") + "zl";
                    }
                    else
                    {
                        expenses_todayexpenses.Text = "0.00zl";
                    }
                }

            }

        }
        public void expensesYesterdaycost()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(cost) FROM expenses WHERE CONVERT(DATE, date_expense) = DATEADD(day, DATEDIFF(day, 0, GETDATE()), -1)";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal yesterdaycost = Convert.ToDecimal(result);
                        expenses_yesterdayexpenses.Text = yesterdaycost.ToString("N2") + "zl";
                    }
                    else
                    {
                        expenses_yesterdayexpenses.Text = "0.00zl";
                    }
                }


            }

        }
        public void expensesThisMonthcost()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startMonth AND date_expense <= @endMonth";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthcost = Convert.ToDecimal(result);
                        expenses_thismonthexpenses.Text = monthcost.ToString("N2") + "zl";
                    }
                    else
                    {
                        expenses_thismonthexpenses.Text = "0.00zl";
                    }
                }

            }

        }
        public void expensesThisMYearcost()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startYear AND date_expense <= @endYear";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearcost = Convert.ToDecimal(result);
                        expenses_thisyearexpenses.Text = yearcost.ToString("N2") + "zl";
                    }
                    else
                    {
                        expenses_thisyearexpenses.Text = "0.00zl";
                    }
                }

            }

        }
        public void totalcost()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(cost) FROM expenses";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalcost = Convert.ToDecimal(result);
                        expenses_totalexpenses.Text = totalcost.ToString("N2") + "zl";
                    }
                    else
                    {
                        expenses_totalexpenses.Text = "0.00zl";
                    }
                }

            }

        }


    }
}
