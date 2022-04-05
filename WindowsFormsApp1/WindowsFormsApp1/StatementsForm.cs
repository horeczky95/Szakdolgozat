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
        public class Cost
        {
            public float amount;
            public string date;
        }
        public class Revenu
        {
            public float amount;
            public string date;
        }
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
        
        public void display_revenues_data()
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
        public void display_costs_data()
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

        public void chart_revenues()
        {
            this.chart1.Series["Revenues"].Points.Clear();
            string format = "yyyy. MM. dd";
            DateTime start = startDate.Value;
            DateTime finish = finishDate.Value;
            List<Revenu> revenus = new List<Revenu>();
            connection.Open();
            SqlCommand cmd_revenu = connection.CreateCommand();
            SqlDataReader reader = (null);
            cmd_revenu.CommandType = CommandType.Text;
            cmd_revenu.CommandText = "select SUM(Amount) as amount, Date from [Revenues] where Date between '" +
                    start.ToString(format) + "' and '" + finish.ToString(format) + "' group by Date";
            cmd_revenu.ExecuteNonQuery();
            reader = cmd_revenu.ExecuteReader();
            while (reader.Read())
            {
                Revenu r = new Revenu();
                r.amount = float.Parse(reader["amount"].ToString());
                r.date = Convert.ToDateTime(reader["Date"]).ToString(format);
                revenus.Add(r);
            }
            reader.Close();
            foreach (Revenu r in revenus)
            {
                this.chart1.Series["Revenues"].Points.AddXY(r.date, r.amount);
            }
            revenus.Clear();
            connection.Close();
        }

        public void chart_costs()
        {
            this.chart1.Series["Costs"].Points.Clear();
            string format = "yyyy. MM. dd";
            DateTime start = startDate.Value;
            DateTime finish = finishDate.Value;
            List<Cost> costs = new List<Cost>();
            connection.Open();
            SqlCommand cmd_cost = connection.CreateCommand();
            SqlDataReader reader = (null);
            cmd_cost.CommandType = CommandType.Text;
            cmd_cost.CommandText = "select SUM(Amount) as Amount, Date from [Costs]where Date between '" +
                    start.ToString(format) + "' and '" + finish.ToString(format) + "' group by Date";
            cmd_cost.ExecuteNonQuery();
            reader = cmd_cost.ExecuteReader();
            while (reader.Read())
            {
                Cost c = new Cost();
                c.amount = float.Parse(reader["Amount"].ToString());
                c.date = Convert.ToDateTime(reader["Date"]).ToString(format);
                costs.Add(c);
            }
            reader.Close();
            foreach (Cost c in costs)
            {
                this.chart1.Series["Costs"].Points.AddXY(c.date, c.amount);
            }
            costs.Clear();
            connection.Close();
        }

        private void revenues_statements_Click(object sender, EventArgs e)
        {

            display_revenues_data();
            chart_revenues();

        }

        private void costs_statements_Click(object sender, EventArgs e)
        {
            display_costs_data();
            chart_costs();
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

            cmd_cash.CommandText = "select * from [Cash_Flow] where Date between '" +
                    start.ToString(format) + "' and '" + finish.ToString(format) + "'";
            cmd_cash.ExecuteNonQuery();

            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd_cash);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;

            cmd_cash.CommandText = "drop table [Cash_Flow]";
            cmd_cash.ExecuteNonQuery();
            connection.Close();
            chart_costs();
            chart_revenues();
        }
    }
}
