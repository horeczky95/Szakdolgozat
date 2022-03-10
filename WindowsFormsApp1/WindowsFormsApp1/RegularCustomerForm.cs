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
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class RegularCustomerForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Suli\GitHub\WindowsFormsApp1\WindowsFormsApp1\AntiqueDB.mdf;Integrated Security = True");
        public RegularCustomerForm()
        {
            InitializeComponent();
            display_data();
        }

        //Fájl műveletek
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

        private void statementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatementsForm state = new StatementsForm();
            state.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Adatbázis műveletek
        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Regular_Customers]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView.DataSource = dta;
            connection.Close();

        }
        private void regcus_display_Click(object sender, EventArgs e)
        {
            display_data();
        }


        private void new_regcust_Click(object sender, EventArgs e)
        {
            

            if ( tB_name.Text != "" && tB_address.Text != "" && tB_born_date.Text != "" && cB_gender.Text != "" && tB_phone.Text != "" && tB_email.Text != "")
            {
                string tb_born = tB_born_date.Text;
                string date = null;
                date += tb_born[0].ToString()+ tb_born[1].ToString() + tb_born[2].ToString() + tb_born[3].ToString() + tb_born[5].ToString() + tb_born[6].ToString();
                string gender_number, gender;
                if (cB_gender.Text == "Nő"){
                    gender_number = "1";
                    gender = "Nő";
                } else {
                    gender_number = "2";
                    gender = "Férfi";
                }
                string nick_name = tB_name.Text;
                string name = null;
                name += nick_name[0].ToString() + nick_name[1].ToString().ToUpper();
                string reg_cust = null;
                reg_cust += date.ToString() + gender_number.ToString() + name.ToString();
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Regular_Customers] (Regular_Customer_ID, Name, Address, [Born date], Gender, [Phone_Number], [Email_Address], [Current_Points], [Previous_Year_Points]) " +
                    "values ('" + reg_cust.ToString() + "', '" + tB_name.Text + "', '" + tB_address.Text + "','" + tB_born_date.Text + "', " +
                    "'" + gender.ToString()+ "', '" + tB_phone.Text + "', '" + tB_email.Text + "', '" + 0 + "', " + "'" + 0 + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                tB_ID.Text = "";
                tB_name.Text = "";
                tB_address.Text = "";
                tB_born_date.Text = "";
                cB_gender.Text = "";
                tB_phone.Text = "";
                tB_email.Text = "";
                display_data();
            }
            else
            {
                MessageBox.Show("Hiányosak az adatok!");
            }
        }

        private void delete_regcus_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Regular_Customers] where Regular_Customer_ID = '" + tB_ID.Text +"'";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data();
        }

        private void regcus_modification_Click(object sender, EventArgs e)
        {
            if (tB_ID.Text != "")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (tB_name.Text != "")
                {
                    cmd.CommandText = "update [Regular_Customers] set Name = '" + tB_name.Text + "' where Regular_Customer_ID = '" + tB_ID.Text + "'";
                    tB_name.Text = "";
                }
                else if (tB_address.Text != "")
                {
                    cmd.CommandText = "update [Regular_Customers] set Address = '" + tB_address.Text + "' where Regular_Customer_ID = '" + tB_ID.Text + "'";
                    tB_address.Text = "";
                }
                else if (tB_born_date.Text != "")
                {
                    cmd.CommandText = "update [Regular_Customers] set [Born year] = '" + tB_born_date.Text + "' where Regular_Customer_ID = '" + tB_ID.Text + "'";
                    tB_born_date.Text = "";
                }
                else if (cB_gender.Text != "")
                {
                    cmd.CommandText = "update [Regular_Customers] set Gender = '" + cB_gender.Text + "' where Regular_Customer_ID = '" + tB_ID.Text + "'";
                    cB_gender.Text = "";
                }
                else if (tB_phone.Text != "")
                {
                    cmd.CommandText = "update [Regular_Customers] set  [Phone_Number] = '" + tB_phone.Text + "' where Regular_Customer_ID = '" + tB_ID.Text  + "'";
                    tB_phone.Text = "";
                }
                else if (tB_email.Text != "")
                {
                    cmd.CommandText = "update [Regular_Customers] set [Email_Address]= '" + tB_email.Text + "' where Regular_Customer_ID = '" + tB_ID.Text + "'";
                    tB_email.Text = "";
                }
                else
                {
                    MessageBox.Show("Hiányzó adat!");
                    cmd.CommandText = "select * from [Books]";
                }
                tB_ID.Text = "";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data();
            }
            else
            {
                MessageBox.Show("Nincs meg adva ID!");
            }
        }

        private void dG_double_Click(object sender, DataGridViewCellEventArgs e)
        {
            tB_ID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
