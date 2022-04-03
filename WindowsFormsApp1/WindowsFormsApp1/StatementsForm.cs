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

namespace WindowsFormsApp1
{
    public partial class StatementsForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Suli\Szakdolgozat\WindowsFormsApp1\WindowsFormsApp1\AntiqueDB.mdf;Integrated Security = True");        public StatementsForm()
        {
            InitializeComponent();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleForm sale = new SaleForm();
            sale.Show();
            this.Hide();
        }

        private void regularCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegularCustomerForm regCust = new RegularCustomerForm();
            regCust.Show();
            this.Hide();
        }

        private void bookManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookManagerForm bookMan = new BookManagerForm();
            bookMan.Show();
            this.Hide();
        }

        private void wishListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WishListForm wishList = new WishListForm();
            wishList.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
        //Adatbázis műveletek
        private void income_statements_Click(object sender, EventArgs e)
        {
            display_income_data();
        }

        private void expend_statements_Click(object sender, EventArgs e)
        {
            display_expend_data();
        }

        public void display_income_data()
        {
            string format = "yyyy. MM. dd";
            DateTime start = startDate.Value;
            DateTime finish = finishDate.Value;
            connection.Open();
            SqlCommand cmd_Date = connection.CreateCommand();
            SqlDataReader read_count = (null);
            cmd_Date.CommandType = CommandType.Text;
            cmd_Date.CommandText = "select count(Revenu_ID) as count from [Revenues] where Date between '" +
                    start.ToString(format) + "' and '" + finish.ToString(format) + "'";
            cmd_Date.ExecuteNonQuery();
            read_count = cmd_Date.ExecuteReader();
            read_count.Read();
            int count = int.Parse(read_count["count"].ToString());
            read_count.Close();
            if (count > 0)
            {
                SqlCommand cmd = connection.CreateCommand();
                SqlCommand cmd2 = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Revenues] where Date between '" +
                    start.ToString(format) + "' and '" + finish.ToString(format) + "'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;
                SqlDataReader read_amount = (null);
                cmd2.CommandText = "select sum(Amount) as Amount from [Revenues] where Date between '" +
                    start.ToString(format) + "' and '" + finish.ToString(format) + "'";
                cmd2.ExecuteNonQuery();
                read_amount = cmd2.ExecuteReader();
                read_amount.Read();
                float all_revenues = float.Parse(read_amount["Amount"].ToString());
                label_revenue.Text = all_revenues.ToString() + " Ft";
                read_amount.Close();
            } else
            {
                MessageBox.Show("Az adott időszakban nem volt bevétel.");

            }
            connection.Close();
        }
        public void display_expend_data()
        {
            string format = "yyyy. MM. dd";
            DateTime start = startDate.Value;
            DateTime finish = finishDate.Value;
            connection.Open();
            SqlCommand cmd_Date = connection.CreateCommand();
            SqlDataReader read_count = (null);
            cmd_Date.CommandType = CommandType.Text;
            cmd_Date.CommandText = "select count(Cost_ID) as count from [Costs] where Date between '" +
                    start.ToString(format) + "' and '" + finish.ToString(format) + "'";
            cmd_Date.ExecuteNonQuery();
            read_count = cmd_Date.ExecuteReader();
            read_count.Read();
            int count = int.Parse(read_count["count"].ToString());
            read_count.Close();
            if (count > 0) {
                SqlCommand cmd = connection.CreateCommand();
                SqlCommand cmd2 = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Costs] where Date between '" +
                    start.ToString(format) + "' and '" + finish.ToString(format) + "'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;
                SqlDataReader read_amount = (null);
                cmd2.CommandText = "select sum(Amount) as Amount from [Costs] where Date between '" +
                    start.ToString(format) + "' and '" + finish.ToString(format) + "'";
                cmd2.ExecuteNonQuery();
                read_amount = cmd2.ExecuteReader();
                read_amount.Read();
                float all_costs = float.Parse(read_amount["Amount"].ToString());
                label_cost.Text = all_costs.ToString() + " Ft";
                read_amount.Close(); 
            } else
            {
                MessageBox.Show("Az adott időszakban nem volt kiadás.");
            }

            connection.Close();
        }

        private void full_statments_button_Click(object sender, EventArgs e)
        {
            string format = "yyyy. MM. dd";
            DateTime start = startDate.Value;
            DateTime finish = finishDate.Value;

            connection.Open();

            SqlCommand cmd_cash= connection.CreateCommand();
            SqlDataReader read_amount = (null);
            cmd_cash.CommandType = CommandType.Text;
            cmd_cash.CommandText = "drop table if exists [Cash_Flow]";
            cmd_cash.ExecuteNonQuery();
            cmd_cash.CommandText = "create table [Cash_Flow] ([Cash_Flow_ID] INT NOT NULL IDENTITY (1, 1), Amount FLOAT NOT NULL, Date DATETIME NOT NULL, PRIMARY KEY CLUSTERED ([Cash_Flow_ID] ASC))";
            cmd_cash.ExecuteNonQuery();
            cmd_cash.CommandText = "insert into [Cash_Flow] (Amount, Date) select Amount*(-1), Date from Costs";
            cmd_cash.ExecuteNonQuery();
            cmd_cash.CommandText = "insert into [Cash_Flow] (Amount, Date) select Amount, Date from Revenues";
            cmd_cash.ExecuteNonQuery();

            cmd_cash.CommandText = "select sum(Amount) as Sum from [Cash_Flow]where Date between '" +
                    start.ToString(format) + "' and '" + finish.ToString(format) + "'";
            cmd_cash.ExecuteNonQuery();
            read_amount = cmd_cash.ExecuteReader();
            read_amount.Read();
            float all_cash = float.Parse(read_amount["Sum"].ToString());
            read_amount.Close();
            label_profit.Text = all_cash.ToString() + " Ft";

            cmd_cash.CommandText = "select * from [Cash_Flow]where Date between '" +
                    start.ToString(format) + "' and '" + finish.ToString(format) + "'";
            cmd_cash.ExecuteNonQuery();

            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd_cash);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;

            cmd_cash.CommandText = "drop table [Cash_Flow]";
            cmd_cash.ExecuteNonQuery();

            connection.Close();
        }
    }
}
