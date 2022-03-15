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
    public partial class SaleForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Suli\GitHub\WindowsFormsApp1\WindowsFormsApp1\AntiqueDB.mdf;Integrated Security = True");
        List<string> books = new List<string>();
        int subtotal = 0;
        int total = 0;

        public SaleForm()
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

        private void SaleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'antiqueDBDataSet.Books' table. You can move, or remove it, as needed.
        }

        //Adatbázis műveletek
        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Books]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }

        public void search_data()
        {
            if (tB_ISBN.Text != "")
            {

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Books] where [ISBN] = '" + tB_ISBN.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;
                connection.Close();
            } else if (tB_author.Text != "")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Books] where [Author] like '%" + tB_author.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;
                connection.Close();
            }
            else if (tB_title.Text != "")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Books] where [Title] like '%" + tB_title.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;
                connection.Close();
            }
            else if (tB_year.Text != "")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Books] where [Release year] = '" + tB_year.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;
                connection.Close();
            }
            else if (tB_genre.Text != "")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Books] where [Genre] like '%" + tB_genre.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;
                connection.Close();
            } else
            {
                MessageBox.Show("Nincs meghatározva egyik adat sem! Nem lehetséges a keresés.");
            }

        }

        private void dG_double_Click(object sender, DataGridViewCellEventArgs e)
        {
            tB_ISBN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tB_author.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tB_title.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tB_year.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tB_genre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tB_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            search_data();
        }

        private void display_button_Click(object sender, EventArgs e)
        {
            display_data();
        }


        private void add_button_Click(object sender, EventArgs e)
        {
            if(tB_ISBN.Text != "" && tB_author.Text != "" && tB_title.Text != "" && tB_year.Text != "" && tB_genre.Text != "")
            {
                
                connection.Open();
                SqlCommand cmd_price = connection.CreateCommand();
                SqlDataReader read = (null);
                cmd_price.CommandText = ("select * from Books where Book_ID = '" + tB_id.Text + "'");
                cmd_price.ExecuteNonQuery();
                read = cmd_price.ExecuteReader();
                read.Read();
                subtotal = int.Parse(read["Selling_Price"].ToString());
                total += subtotal;
                string price = read["Selling_Price"].ToString();
                read.Close();
                if(tB_id.Text != "" && tB_ISBN.Text != "" && tB_author.Text != "" && tB_title.Text != "")
                {
                    ListViewItem item = new ListViewItem(tB_id.Text);
                    item.SubItems.Add(tB_ISBN.Text);
                    item.SubItems.Add(tB_author.Text);
                    item.SubItems.Add(tB_title.Text);
                    item.SubItems.Add(price + " Ft");
                    listView1.Items.Add(item);
                    label_subtotal.Text = subtotal.ToString() + " Ft";
                    label_total.Text = total.ToString() + " Ft";
                    tB_id.Clear();
                    tB_ISBN.Clear();
                    tB_author.Clear();
                    tB_title.Clear();
                    tB_year.Clear();
                    tB_genre.Clear();
                }
                connection.Close();

            } else
            {
                MessageBox.Show("Hiányos adatok");
            }

        }
    }
}
