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

        private void BookManagerForm_Load(object sender, EventArgs e)
        {
        }

        //Adatbázis műveletek
        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Könyvek]";
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

        private void button_new_book_Click(object sender, EventArgs e)
        {

            if (textBox_ISBN.Text != "" && textBox_author.Text != "" && textBox_title.Text != "" &&
            textBox_year.Text != "" && textBox_genre.Text != "" && textBox_publisher.Text != "" && textBox_condition.Text != "" &&
            textBox_binding.Text != "" && textBox_pagenumber.Text != "" && textBox_purchase_price.Text != "" && textBox_selling_price.Text != "") {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Könyvek] (ISBN, Szerző, Cím, [Kiadás éve], Műfaj, Kiadó, Állapot, Kötés, Oldalszám, [Beszerzési ár], [Eladási ár]) " +
                    "values ('" + textBox_ISBN.Text + "', '" + textBox_author.Text + "', '" + textBox_title.Text + "','" + int.Parse(textBox_year.Text) + "', " +
                    "'" + textBox_genre.Text + "', '" + textBox_publisher.Text + "', '" + textBox_condition.Text + "', '" + textBox_binding.Text + "', " +
                    "'" + int.Parse(textBox_pagenumber.Text) + "', '" + int.Parse(textBox_purchase_price.Text) + "', '" + int.Parse(textBox_selling_price.Text) + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                textBox_ISBN.Text = "";
                textBox_author.Text = "";
                textBox_title.Text = "";
                textBox_year.Text = "";
                textBox_genre.Text = "";
                textBox_publisher.Text = "";
                textBox_condition.Text = "";
                textBox_binding.Text = "";
                textBox_pagenumber.Text = "";
                textBox_purchase_price.Text = "";
                textBox_selling_price.Text = "";
                display_data();
            } else
            {
                MessageBox.Show("Hiányosak az adatok!");
            }
        }

        private void button_book_delete_Click(object sender, EventArgs e)
        {
            if(textBox_ID.Text != "")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [Könyvek] where [Könyv_id] = '" + int.Parse(textBox_ID.Text) + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data();
                textBox_ID.Text = "";
            } else
            {
                MessageBox.Show("Nincs meg adva ID");
            }
        }

        private void button_book_modification_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text != "")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (textBox_ISBN.Text != "")
                {
                    cmd.CommandText = "update [Könyvek] set ISBN = '"+ textBox_ISBN.Text +"' where Könyv_id = '" + int.Parse(textBox_ID.Text) + "'";
                    textBox_ISBN.Text = "";
                } else if (textBox_author.Text != "") {
                    cmd.CommandText = "update [Könyvek] set Szerző = '" + textBox_author.Text + "' where Könyv_id = '" + int.Parse(textBox_ID.Text) + "'";
                    textBox_author.Text = "";
                } else if (textBox_title.Text != "") {
                    cmd.CommandText = "update [Könyvek] set Cím = '" + textBox_title.Text + "' where Könyv_id = '" + int.Parse(textBox_ID.Text) + "'";
                    textBox_title.Text = "";
                } else if (textBox_year.Text != "") {
                    cmd.CommandText = "update [Könyvek] set [Kiadás éve] = '" + int.Parse(textBox_year.Text) + "' where Könyv_id = '" + int.Parse(textBox_ID.Text) + "'";
                    textBox_year.Text = "";
                } else if (textBox_genre.Text != "") {
                    cmd.CommandText = "update [Könyvek] set  Műfaj= '" + textBox_genre.Text + "' where Könyv_id = '" + int.Parse(textBox_ID.Text) + "'";
                    textBox_genre.Text = "";
                } else if (textBox_publisher.Text != "") {
                    cmd.CommandText = "update [Könyvek] set Kiadó= '" + textBox_publisher.Text + "' where Könyv_id = '" + int.Parse(textBox_ID.Text) + "'";
                    textBox_publisher.Text = "";
                } else if (textBox_condition.Text != "") {
                    cmd.CommandText = "update [Könyvek] set Állapot = '" + textBox_condition.Text+ "' where Könyv_id = '" + int.Parse(textBox_ID.Text) + "'";
                    textBox_condition.Text = "";
                } else if (textBox_binding.Text != "") {
                    cmd.CommandText = "update [Könyvek] set Kötés = '" + textBox_binding.Text + "' where Könyv_id = '" + int.Parse(textBox_ID.Text) + "'";
                    textBox_binding.Text = "";
                } else if (textBox_pagenumber.Text != "") {
                    cmd.CommandText = "update [Könyvek] set Oldalszám = '" + int.Parse(textBox_pagenumber.Text) + "' where Könyv_id = '" + int.Parse(textBox_ID.Text) + "'";
                    textBox_pagenumber.Text = "";
                } else if (textBox_purchase_price.Text != "") {
                    cmd.CommandText = "update [Könyvek] set [Beszerzési ár] = '" + int.Parse(textBox_purchase_price.Text) + "' where Könyv_id = '" + int.Parse(textBox_ID.Text) + "'";
                    textBox_purchase_price.Text = "";
                } else if (textBox_selling_price.Text != "") {
                    cmd.CommandText = "update [Könyvek] set [Eladási ár] = '" + int.Parse(textBox_selling_price.Text) + "' where Könyv_id = '" + int.Parse(textBox_ID.Text) + "'";
                    textBox_selling_price.Text = "";
                } else {
                    MessageBox.Show("Hiányzó adat!");
                    cmd.CommandText = "select * from [Könyvek]";
                }
                textBox_ID.Text = "";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data();
            } else {
                MessageBox.Show("Nincs meg adva ID!");
            }
            
        }
    }
}
