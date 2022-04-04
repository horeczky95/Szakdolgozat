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
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Suli\Szakdolgozat\WindowsFormsApp1\WindowsFormsApp1\AntiqueDB.mdf;Integrated Security = True");
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
            cmd.CommandText = "select [Regular_Customer_ID] as [Törzsvásárlói kód], [Name] as Név, [Address] as Cím, [Born date] as [Születési idő], [Gender] as [Nem], [Phone_number] as Telefonszám, " +
                "[Email_Address] as [Email cím], [Current_Points] as [Aktuális pontok], [Previous_Year_Points] as [Előző éves pontok] from [Regular_Customers]";
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
            

            if ( tB_name.Text != "" && tB_address.Text != "" &&  cB_gender.Text != "" && tB_phone.Text != "" && tB_email.Text != "")
            {
                string format = "yyyy. MM. dd";
                DateTime born_date = dtP_born_date.Value;
                string born_date_string = born_date.ToString(format);
                string date = null;
                date += born_date_string[0].ToString()+ born_date_string[1].ToString() + born_date_string[2].ToString() + born_date_string[3].ToString() + born_date_string[6].ToString() + born_date_string[7].ToString();
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
                    "values ('" + reg_cust.ToString() + "', '" + tB_name.Text + "', '" + tB_address.Text + "','" + born_date.ToString(format) + "', " +
                    "'" + gender.ToString()+ "', '" + tB_phone.Text + "', '" + tB_email.Text + "', '" + 0 + "', " + "'" + 0 + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                tB_ID.Text = "";
                tB_name.Text = "";
                tB_address.Text = "";
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
                string format = "yyyy. MM. dd";
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
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
                /*else if (dtP_born_date.Value.ToString() != "")
                {
                    cmd.CommandText = "update [Regular_Customers] set [Born year] = '" + tB_born_date.Text + "' where Regular_Customer_ID = '" + tB_ID.Text + "'";
                    tB_born_date.Text = "";
                }*/
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
