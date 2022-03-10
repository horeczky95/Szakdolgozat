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
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Suli\GitHub\WindowsFormsApp1\WindowsFormsApp1\AntiqueDB.mdf;Integrated Security = True");
        public WishListForm()
        {
            InitializeComponent();
            display_data();
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

        private void WishListForm_Load(object sender, EventArgs e)
        {
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
            dataGridView1.DataSource = dta;
            connection.Close();
        }

        private void wishList_display_click(object sender, EventArgs e)
        {
            display_data();
        }

        private void new_wish_click(object sender, EventArgs e)
        {
            if (tB_ISBN.Text != "" && tB_author.Text != "" && tB_title.Text != "" && tB_name.Text != "" &&
                tB_add.Text != "" && tB_phone.Text != "" && tB_email.Text != "") {
                string regCust;
                if (tB_RegCust.Text != "")
                {
                  regCust  = tB_RegCust.Text;
                } else
                {
                    regCust = "Nem törzsvásárló!";
                }
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Wish_List] (ISBN, Author, Title, [Customer_Name], [Customer_Address], [Customer_Phone_Number], [Customer_Email_Address], [Regular_Customer_ID]) values ('" +
                    tB_ISBN.Text + "', '" + tB_author.Text + "', '" + tB_title.Text + "', '" + tB_name.Text + "', '" + tB_add.Text + "', '" + tB_phone.Text + "', '" +
                    tB_email.Text + "', '" + tB_RegCust.Text + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data();
            } else
            {
                MessageBox.Show("Hiányos adatok!");
            }
            tB_ISBN.Text = "";
            tB_author.Text = "";
            tB_title.Text = "";
            tB_name.Text = "";
            tB_add.Text = "";
            tB_phone.Text = "";
            tB_email.Text = "";
            tB_RegCust.Text = "";
        }

        private void wish_modification_Click(object sender, EventArgs e)
        {
            
            if (tB_ID.Text != "")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (tB_ISBN.Text != "")
                {
                    cmd.CommandText = "update [Wish_List] set ISBN = '" + tB_ISBN.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_ISBN.Text = "";
                }
                else if (tB_author.Text != "")
                {
                    cmd.CommandText = "update [Wish_List] set Author = '" + tB_author.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_author.Text = "";
                }
                else if (tB_title.Text != "")
                {
                    cmd.CommandText = "update [Wish_List] set Title = '" + tB_title.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_title.Text = "";
                }
                else if (tB_name.Text != "")
                {
                    cmd.CommandText = "update [Wish_List] set [Customer_Name] = '" + tB_name.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_name.Text = "";
                }
                else if (tB_add.Text != "")
                {
                    cmd.CommandText = "update [Wish_List] set  [Customer_Address]= '" + tB_add.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_add.Text = "";
                }
                else if (tB_phone.Text != "")
                {
                    cmd.CommandText = "update [Wish_List] set [Customer_Phone_Number]= '" + tB_phone.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_phone.Text = "";
                }
                else if (tB_email.Text != "")
                {
                    cmd.CommandText = "update [Wish_List] set [Customer_Email_Address] = '" + tB_email.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_email.Text = "";
                }
                else if (tB_RegCust.Text != "")
                {
                    cmd.CommandText = "update [Wish_List] set [Regular_Customer_ID] = '" + tB_RegCust.Text + "' where Wish_ID = '" + int.Parse(tB_ID.Text) + "'";
                    tB_RegCust.Text = "";
                } else {
                    MessageBox.Show("Hiányzó adat!");
                    cmd.CommandText = "select * from [Wish_List]";
                }
                tB_ID.Text = "";
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
            if (tB_ID.Text != "")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [Wish_List] where [Wish_ID] = '" + int.Parse(tB_ID.Text) + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data();
                tB_ID.Text = "";
            }
            else
            {
                MessageBox.Show("Nincs meg adva ID");
            }
        }

        private void dG_double_Click(object sender, DataGridViewCellEventArgs e)
        {
            tB_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    
    }
}
