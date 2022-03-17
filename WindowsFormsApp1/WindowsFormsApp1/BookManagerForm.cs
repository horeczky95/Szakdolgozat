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
   
    public partial class BookManagerForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Suli\GitHub\WindowsFormsApp1\WindowsFormsApp1\AntiqueDB.mdf;Integrated Security = True");
        public BookManagerForm()
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

        private void regularCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegularCustomerForm regCust = new RegularCustomerForm();
            regCust.Show();
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
            cmd.CommandText = "select * from [Books]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }

        private void books_display_Click(object sender, EventArgs e)
        {
            display_data();
        }

        public void textClear()
        {
            tB_ID.Text = "";
            tB_ISBN.Text = "";
            tB_author.Text = "";
            tB_title.Text = "";
            tB_year.Text = "";
            tB_genre.Text = "";
            tB_publisher.Text = "";
            tB_condition.Text = "";
            tB_binding.Text = "";
            tB_pagenumber.Text = "";
            tB_purchase_price.Text = "";
            tB_selling_price.Text = "";
        }

        private void button_new_book_Click(object sender, EventArgs e)
        {

            if (tB_ISBN.Text != "" && tB_author.Text != "" && tB_title.Text != "" &&
            tB_year.Text != "" && tB_genre.Text != "" && tB_publisher.Text != "" && tB_condition.Text != "" &&
            tB_binding.Text != "" && tB_pagenumber.Text != "" && tB_purchase_price.Text != "" && tB_selling_price.Text != "") {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                SqlCommand cmd_expend = connection.CreateCommand();
                SqlCommand cmd_id = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd_expend.CommandType = CommandType.Text;
                cmd_id.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Books] (ISBN, Author, Title, [Release year], Genre, Publisher, Condition, Binding, Pagenumber, [Purchase_Price], [Selling_Price]) " +
                    "values ('" + tB_ISBN.Text + "', '" + tB_author.Text + "', '" + tB_title.Text + "','" + int.Parse(tB_year.Text) + "', " +
                    "'" + tB_genre.Text + "', '" + tB_publisher.Text + "', '" + tB_condition.Text + "', '" + tB_binding.Text + "', " +
                    "'" + int.Parse(tB_pagenumber.Text) + "', '" + int.Parse(tB_purchase_price.Text) + "', '" + int.Parse(tB_selling_price.Text) + "')";
                cmd.ExecuteNonQuery();
                string name = tB_author.Text + ", " + tB_title.Text;
                SqlDataReader read = (null);
                cmd_id.CommandText = ("select top(1) * from Books order by Book_ID desc");
                cmd_id.ExecuteNonQuery();
                read = cmd_id.ExecuteReader();
                read.Read();
                string id = read["Book_ID"].ToString();
                read.Close();
                string format = "yyyy.MM.dd";
                cmd_expend.CommandText ="insert into [Costs] (Book_ID, Name, Amount, Date) " +
                    "values ('" + int.Parse(id.ToString()) + "', '" + name.ToString() + "', '" + int.Parse(tB_purchase_price.Text) +
                    "', '" + DateTime.Today.ToString(format) + "')";
                cmd_expend.ExecuteNonQuery();
                connection.Close();
                display_data();
                textClear();
            } else
            {
                MessageBox.Show("Hiányosak az adatok!");
            }
        }

        private void button_book_delete_Click(object sender, EventArgs e)
        {
            if(tB_ID.Text != "")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [Books] where [Book_ID] = '" + int.Parse(tB_ID.Text) + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data();
                textClear();
            } else
            {
                MessageBox.Show("Nincs meg adva ID");
            }
        }

        private void button_book_modification_Click(object sender, EventArgs e)
        {
            if (tB_ID.Text != "")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (tB_ISBN.Text != "")
                {
                    cmd.CommandText = "update [Books] set ISBN = '"+ tB_ISBN.Text +"' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_author.Text != "") {
                    cmd.CommandText = "update [Books] set Author = '" + tB_author.Text + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_title.Text != "") {
                    cmd.CommandText = "update [Books] set Title = '" + tB_title.Text + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_year.Text != "") {
                    cmd.CommandText = "update [Books] set [Release year]= '" + int.Parse(tB_year.Text) + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_genre.Text != "") {
                    cmd.CommandText = "update [Books] set Genre= '" + tB_genre.Text + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_publisher.Text != "") {
                    cmd.CommandText = "update [Books] set Publisher = '" + tB_publisher.Text + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_condition.Text != "") {
                    cmd.CommandText = "update [Books] set Condition = '" + tB_condition.Text+ "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_binding.Text != "") {
                    cmd.CommandText = "update [Books] set Binding = '" + tB_binding.Text + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_pagenumber.Text != "") {
                    cmd.CommandText = "update [Books] set Pagenumber = '" + int.Parse(tB_pagenumber.Text) + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_purchase_price.Text != "") {
                    cmd.CommandText = "update [Books] set [Purchase_Price] = '" + int.Parse(tB_purchase_price.Text) + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_selling_price.Text != "") {
                    cmd.CommandText = "update [Books] set [Selling_Price] = '" + int.Parse(tB_selling_price.Text) + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else {
                    MessageBox.Show("Hiányzó adat!");
                    cmd.CommandText = "select * from [Books]";
                }
                textClear();
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data();
            } else {
                MessageBox.Show("Nincs meg adva ID!");
            }
            
        }

        private void dG_double_Click(object sender, DataGridViewCellEventArgs e)
        {
            tB_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
