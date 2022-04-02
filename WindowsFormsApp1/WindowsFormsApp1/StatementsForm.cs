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
            SqlCommand cmd_Revenues_Date = connection.CreateCommand();
            SqlDataReader read_Revenues_Count = (null);
            cmd_Revenues_Date.CommandType = CommandType.Text;
            cmd_Revenues_Date.CommandText = "select count(Revenu_ID) as count from [Revenues] where Date between '" +
                    start.ToString(format) + "' and '" + finish.ToString(format) + "'";
            cmd_Revenues_Date.ExecuteNonQuery();
            read_Revenues_Count = cmd_Revenues_Date.ExecuteReader();
            read_Revenues_Count.Read();
            int count_revenues = int.Parse(read_Revenues_Count["count"].ToString());
            read_Revenues_Count.Close();
            SqlCommand cmd = connection.CreateCommand();
            SqlCommand cmd2 = connection.CreateCommand();
            float all_revenues;
            SqlCommand cmd_Costs_Date = connection.CreateCommand();
            SqlDataReader read_Costs_Count = (null);
            cmd_Costs_Date.CommandType = CommandType.Text;
            cmd_Costs_Date.CommandText = "select count(Cost_ID) as count from [Costs] where Date between '" +
                    start.ToString(format) + "' and '" + finish.ToString(format) + "'";
            cmd_Costs_Date.ExecuteNonQuery();
            read_Costs_Count = cmd_Costs_Date.ExecuteReader();
            read_Costs_Count.Read();
            int count_costs = int.Parse(read_Costs_Count["count"].ToString());
            read_Costs_Count.Close();
            float all_costs;
            if (count_revenues > 0)
            {
                SqlDataReader read = (null);
                cmd.CommandText = "select sum(Amount) as Amount from Revenues where Date between '" +
                        start.ToString(format) + "' and '" + finish.ToString(format) + "'";
                cmd.ExecuteNonQuery();
                read = cmd.ExecuteReader();
                read.Read();
                all_revenues = float.Parse(read["Amount"].ToString());
                label_revenue.Text = all_revenues.ToString() + " Ft";
                read.Close();
            }
            else
            {
                all_revenues = 0;
            }
            if (count_revenues > 0)
            {
                SqlDataReader read1 = (null);
                cmd2.CommandText = "select sum(Amount) as Amount from Costs where Date between '" +
                        start.ToString(format) + "' and '" + finish.ToString(format) + "'";
                cmd2.ExecuteNonQuery();
                read1 = cmd2.ExecuteReader();
                read1.Read();
                all_costs = float.Parse(read1["Amount"].ToString());
                label_cost.Text = all_costs.ToString() + " Ft";
                read1.Close();
            }
            else
            {
                all_costs = 0;
            }

            float all_profit = all_revenues - all_costs;
            label_profit.Text = all_profit.ToString() + " Ft";
            connection.Close();
            connection.Open();
            SqlCommand cmd3= connection.CreateCommand();

            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select* from [Costs]  where Date between '" +
                start.ToString(format) + "' and '" + finish.ToString(format) + "'" + "select * from [Revenues] where Date between '" +
                start.ToString(format) + "' and '" + finish.ToString(format) + "'";
            cmd3.ExecuteNonQuery();

            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd3);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;

            connection.Close();
        }
    }
}
