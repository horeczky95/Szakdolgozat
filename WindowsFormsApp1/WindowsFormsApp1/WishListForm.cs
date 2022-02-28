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
            cmd.CommandText = "select * from [Kívánságlista]";
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
                cmd.CommandText = "insert into [Kívánságlista] (ISBN, Szerző, Cím, [Vásárló neve], [Vásárló címe], [Vásárló telefonszáma], [Vásárló email címe], [Törzsvásárlói kód]) values ('" +
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
                    cmd.CommandText = "update [Kívánságlista] set ISBN = '" + tB_ISBN.Text + "' where Kívánság_id = '" + int.Parse(tB_ID.Text) + "'";
                    tB_ISBN.Text = "";
                }
                else if (tB_author.Text != "")
                {
                    cmd.CommandText = "update [Kívánságlista] set Szerző = '" + tB_author.Text + "' where Kívánság_id = '" + int.Parse(tB_ID.Text) + "'";
                    tB_author.Text = "";
                }
                else if (tB_title.Text != "")
                {
                    cmd.CommandText = "update [Kívánságlista] set Cím = '" + tB_title.Text + "' where Kívánság_id = '" + int.Parse(tB_ID.Text) + "'";
                    tB_title.Text = "";
                }
                else if (tB_name.Text != "")
                {
                    cmd.CommandText = "update [Kívánságlista] set [Vásárló neve] = '" + tB_name.Text + "' where Kívánság_id = '" + int.Parse(tB_ID.Text) + "'";
                    tB_name.Text = "";
                }
                else if (tB_add.Text != "")
                {
                    cmd.CommandText = "update [Kívánságlista] set  [Vásárló címe]= '" + tB_add.Text + "' where Kívánság_id = '" + int.Parse(tB_ID.Text) + "'";
                    tB_add.Text = "";
                }
                else if (tB_phone.Text != "")
                {
                    cmd.CommandText = "update [Kívánságlista] set [Vásárló telefonszáma]= '" + tB_phone.Text + "' where Kívánság_id = '" + int.Parse(tB_ID.Text) + "'";
                    tB_phone.Text = "";
                }
                else if (tB_email.Text != "")
                {
                    cmd.CommandText = "update [Kívánságlista] set [Vásárló email címe] = '" + tB_email.Text + "' where Kívánság_id = '" + int.Parse(tB_ID.Text) + "'";
                    tB_email.Text = "";
                }
                else if (tB_RegCust.Text != "")
                {
                    cmd.CommandText = "update [Kívánságlista] set [Törzsvásárlói kód] = '" + tB_RegCust.Text + "' where Kívánság_id = '" + int.Parse(tB_ID.Text) + "'";
                    tB_RegCust.Text = "";
                } else {
                    MessageBox.Show("Hiányzó adat!");
                    cmd.CommandText = "select * from [Kívánságlista]";
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
                cmd.CommandText = "delete from [Kívánságlista] where [Kívánság_ID] = '" + int.Parse(tB_ID.Text) + "'";
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
    }

}
