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
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            SqlCommand cmd2 = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Revenues]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            SqlDataReader read = (null);
            cmd2.CommandText = ("select sum(Amount) as Amount from Revenues");
            cmd2.ExecuteNonQuery();
            read = cmd2.ExecuteReader();
            read.Read();
            float all_revenues = float.Parse(read["Amount"].ToString());
            label_revenue.Text = all_revenues.ToString() + " Ft";
            read.Close();
            connection.Close();
        }
        public void display_expend_data()
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            SqlCommand cmd2 = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Costs]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            SqlDataReader read = (null);
            cmd2.CommandText = ("select sum(Amount) as Amount from Costs");
            cmd2.ExecuteNonQuery();
            read = cmd2.ExecuteReader();
            read.Read();
            float all_costs = float.Parse(read["Amount"].ToString());
            label_cost.Text = all_costs.ToString() + " Ft";
            read.Close();

            connection.Close();
        }

        private void full_statments_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            SqlCommand cmd2 = connection.CreateCommand();
            SqlDataReader read = (null);
            cmd.CommandText = ("select sum(Amount) as Amount from Revenues");
            cmd.ExecuteNonQuery();
            read = cmd.ExecuteReader();
            read.Read();
            float all_revenues = float.Parse(read["Amount"].ToString());
            label_revenue.Text = all_revenues.ToString() + " Ft";
            read.Close();
            SqlDataReader read1 = (null);
            cmd2.CommandText = ("select sum(Amount) as Amount from Costs");
            cmd2.ExecuteNonQuery();
            read1 = cmd2.ExecuteReader();
            read1.Read();
            float all_costs = float.Parse(read1["Amount"].ToString());
            label_cost.Text = all_costs.ToString() + " Ft";
            read.Close();
            float all_profit = all_revenues - all_costs;
            label_profit.Text = all_profit.ToString() + " Ft";
            connection.Close();
            connection.Open();
            SqlCommand cmd3= connection.CreateCommand();

            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select* from [Costs] " + "select * from [Revenues]";
            cmd3.ExecuteNonQuery();

            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd3);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;

            connection.Close();
        }
    }
}
