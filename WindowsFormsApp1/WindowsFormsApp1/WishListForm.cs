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
    public partial class WishListForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\SULI\SZAKDOLGOZAT\WINDOWSFORMSAPP1\WINDOWSFORMSAPP1\ANTIQUEDB.MDF;Integrated Security = True");
        public WishListForm()
        {
            InitializeComponent();
            display_data();
            display_regcust();
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
            cmd.CommandText = "select * from [Wish_List]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView_wishlist.DataSource = dta;
            connection.Close();
        }

        public void display_regcust()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Regular_Customer_ID] as Azonosító, [Name] as Név from [Regular_Customers]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView_regcust.DataSource = dta;
            connection.Close();
        }

        private void wishlist_display_click(object sender, EventArgs e)
        {
            display_data();
        }

        private void new_wish_add_click(object sender, EventArgs e)
        {
            if (tB_ISBN.Text != "" && tB_author.Text != "" && tB_title.Text != "" && tB_name.Text != "" &&
                tB_address.Text != "" && tB_phone.Text != "" && tB_email.Text != "" && tB_ISBN.Text != "ISBN" &&
                tB_author.Text != "Szerző" && tB_title.Text != "Cím" && tB_name.Text != "Teljes név" &&
                tB_address.Text != "Lakcím" && tB_phone.Text != "Telefonszám" && tB_email.Text != "Email cím") {
                string regCust;
                if (tB_regcust_ID.Text != "" && tB_regcust_ID.Text != "Törzsvásárló kód")
                {
                    regCust = tB_regcust_ID.Text;
                    tB_regcust_ID.ForeColor = Color.Gray;
                    tB_regcust_ID.Text = "Törzsvásárlói kód";
                } else
                {
                    regCust = "Nem törzsvásárló!";
                }
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Wish_List] (ISBN, Author, Title, [Customer_Name], [Customer_Address], [Customer_Phone_Number], [Customer_Email_Address], [Regular_Customer_ID]) values ('" +
                    tB_ISBN.Text + "', '" + tB_author.Text + "', '" + tB_title.Text + "', '" + tB_name.Text + "', '" + tB_address.Text + "', '" + tB_phone.Text + "', '" +
                    tB_email.Text + "', '" + tB_regcust_ID.Text + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data();
            } else
            {
                MessageBox.Show("Hiányos adatok!");
            }
            tB_ISBN.ForeColor = Color.Gray;
            tB_ISBN.Text = "ISBN";
            tB_author.ForeColor = Color.Gray;
            tB_author.Text = "Szerző";
            tB_title.ForeColor = Color.Gray;
            tB_title.Text = "Cím";
            tB_name.ForeColor = Color.Gray;
            tB_name.Text = "Teljes név";
            tB_address.ForeColor = Color.Gray;
            tB_address.Text = "Lakcím";
            tB_phone.ForeColor = Color.Gray;
            tB_phone.Text = "Telefonszám";
            tB_email.ForeColor = Color.Gray;
            tB_email.Text = "Email cím";

        }

        private void wish_modification_Click(object sender, EventArgs e)
        {
            
            if (tB_ID.Text != "" && tB_ID.Text != "Kívánság ID")
            {

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (tB_ISBN.Text != "" && tB_ISBN.Text != "ISBN")
                {
                    cmd.CommandText = "update [Wish_List] set ISBN = '" + tB_ISBN.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_ISBN.Text = "ISBN";
                    tB_ISBN.ForeColor = Color.Gray;
                }
                else if (tB_author.Text != "" && tB_author.Text != "Szerző")
                {
                    cmd.CommandText = "update [Wish_List] set Author = '" + tB_author.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_author.Text = "Szerző";
                    tB_author.ForeColor = Color.Gray;
                }
                else if (tB_title.Text != "" && tB_title.Text != "Cím")
                {
                    cmd.CommandText = "update [Wish_List] set Title = '" + tB_title.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_title.Text = "Cím";
                    tB_title.ForeColor = Color.Gray;
                }
                else if (tB_name.Text != "" && tB_name.Text != "Teljes név")
                {
                    cmd.CommandText = "update [Wish_List] set [Customer_Name] = '" + tB_name.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_name.Text = "Teljes név";
                    tB_name.ForeColor = Color.Gray;
                }
                else if (tB_address.Text != "" && tB_address.Text != "Lakcím")
                {
                    cmd.CommandText = "update [Wish_List] set  [Customer_Address]= '" + tB_address.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_address.Text = "Lakcím";
                    tB_address.ForeColor = Color.Gray;
                }
                else if (tB_phone.Text != "" && tB_phone.Text != "Telefonszám")
                {
                    cmd.CommandText = "update [Wish_List] set [Customer_Phone_Number]= '" + tB_phone.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_phone.Text = "Telefonszám";
                    tB_phone.ForeColor = Color.Gray;
                }
                else if (tB_email.Text != "" && tB_email.Text != "Email cím" )
                {
                    cmd.CommandText = "update [Wish_List] set [Customer_Email_Address] = '" + tB_email.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_email.Text = "Email cím";
                    tB_email.ForeColor = Color.Gray;
                }
                else if (tB_regcust_ID.Text != "" && tB_regcust_ID.Text != "Törzsvásárlói kód")
                {
                    cmd.CommandText = "update [Wish_List] set [Regular_Customer_ID] = '" + tB_regcust_ID.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_regcust_ID.Text = "Törzsvásárlói kód";
                    tB_regcust_ID.ForeColor = Color.Gray;
                } else {
                    MessageBox.Show("Hiányzó adat!");
                    cmd.CommandText = "select * from [Wish_List]";
                }
                tB_ID.ForeColor = Color.Gray;
                tB_ID.Text = "Kívánság ID";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data();
            }
            else
            {
                MessageBox.Show("Nincs meg adva ID");
            }
            
        }

        private void wish_delete_Click(object sender, EventArgs e)
        {
            if (tB_ID.Text != "" && tB_ID.Text != "Kívánság ID")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [Wish_List] where [Wish_ID] = '" + int.Parse(tB_ID.Text) + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data();
                tB_ID.ForeColor = Color.Gray;
                tB_ID.Text = "Kívánság ID";
            }
            else
            {
                MessageBox.Show("Nincs meg adva ID");
            }
        }

        private void dG_double_Click(object sender, DataGridViewCellEventArgs e)
        {
            tB_ID.ForeColor = Color.Black;
            tB_ID.Text = dataGridView_wishlist.CurrentRow.Cells[0].Value.ToString();
        }

        private void reg_cust_db_double_click(object sender, DataGridViewCellEventArgs e)
        {
            tB_regcust_ID.ForeColor = Color.Black;
            tB_regcust_ID.Text = dataGridView_regcust.CurrentRow.Cells[0].Value.ToString();
        }

        //Formázás

        private void tB_ISBN_Enter(object sender, EventArgs e)
        {
            if(tB_ISBN.Text == "ISBN")
            {
                tB_ISBN.Text = "";
                tB_ISBN.ForeColor = Color.Black;
            }
        }

        private void tB_ISBN_Leave(object sender, EventArgs e)
        {
            if (tB_ISBN.Text == "")
            {
                tB_ISBN.Text = "ISBN";
                tB_ISBN.ForeColor = Color.Gray;
            }
        }

        private void tB_author_Enter(object sender, EventArgs e)
        {
            if (tB_author.Text == "Szerző")
            {
                tB_author.Text = "";
                tB_author.ForeColor = Color.Black;
            }
        }

        private void tB_author_Leave(object sender, EventArgs e)
        {
            if (tB_author.Text == "")
            {
                tB_author.Text = "Szerző";
                tB_author.ForeColor = Color.Gray;
            }
        }

        private void tB_title_Enter(object sender, EventArgs e)
        {
            if (tB_title.Text == "Cím")
            {
                tB_title.Text = "";
                tB_title.ForeColor = Color.Black;
            }
        }

        private void tB_title_Leave(object sender, EventArgs e)
        {
            if (tB_title.Text == "")
            {
                tB_title.Text = "Cím";
                tB_title.ForeColor = Color.Gray;
            }
        }

        private void tB_regcust_ID_Enter(object sender, EventArgs e)
        {
            if (tB_regcust_ID.Text == "Törzsvásárlói kód")
            {
                tB_regcust_ID.Text = "";
                tB_regcust_ID.ForeColor = Color.Black;
            }
        }

        private void tB_regcust_ID_Leave(object sender, EventArgs e)
        {
            if (tB_regcust_ID.Text == "")
            {
                tB_regcust_ID.Text = "Törzsvásárlói kód";
                tB_regcust_ID.ForeColor = Color.Gray;
            }
        }

        private void tB_name_Enter(object sender, EventArgs e)
        {
            if (tB_name.Text == "Teljes név")
            {
                tB_name.Text = "";
                tB_name.ForeColor = Color.Black;
            }
        }

        private void tB_name_Leave(object sender, EventArgs e)
        {
            if (tB_name.Text == "")
            {
                tB_name.Text = "Teljes név";
                tB_name.ForeColor = Color.Gray;
            }
        }

        private void tB_address_Enter(object sender, EventArgs e)
        {
            if (tB_address.Text == "Lakcím")
            {
                tB_address.Text = "";
                tB_address.ForeColor = Color.Black;
            }
        }

        private void tB_address_Leave(object sender, EventArgs e)
        {
            if (tB_address.Text == "")
            {
                tB_address.Text = "Lakcím";
                tB_address.ForeColor = Color.Gray;
            }
        }

        private void tB_phone_Enter(object sender, EventArgs e)
        {
            if (tB_phone.Text == "Telefonszám")
            {
                tB_phone.Text = "";
                tB_phone.ForeColor = Color.Black;
            }
        }

        private void tB_phone_Leave(object sender, EventArgs e)
        {
            if (tB_phone.Text == "")
            {
                tB_phone.Text = "Telefonszám";
                tB_phone.ForeColor = Color.Gray;
            }
        }

        private void tB_email_Enter(object sender, EventArgs e)
        {
            if (tB_email.Text == "Email cím")
            {
                tB_email.Text = "";
                tB_email.ForeColor = Color.Black;
            }
        }

        private void tB_email_Leave(object sender, EventArgs e)
        {
            if (tB_email.Text == "")
            {
                tB_email.Text = "Email cím";
                tB_email.ForeColor = Color.Gray;
            }
        }

        private void tB_ID_Enter(object sender, EventArgs e)
        {
            if(tB_ID.Text == "Kívánság ID")
            {
                tB_ID.Text = "";
                tB_ID.ForeColor = Color.Black;
            }
        }

        private void tB_ID_Leave(object sender, EventArgs e)
        {
            if (tB_ID.Text == "")
            {
                tB_ID.Text = "Kívánság ID";
                tB_ID.ForeColor = Color.Gray;
            }
        }

        private void form_Close_Click(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
