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
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp1
{
   
    public partial class BookManagerForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Suli\Szakdolgozat\WindowsFormsApp1\WindowsFormsApp1\AntiqueDB.mdf;Integrated Security = True");
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

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
            cmd.CommandText = "select [ISBN], [Author] as [Szerző], [Title] as [Cím], [Release year] as [Kiadás éve], [Genre] as [Műfaj], [Publisher] as [Kiadó], [Pagenumber] as [Oldalszám], [Condition] as [Állapot]" +
                ", [Binding] as [Kötés], [Purchase_Price] as [Beszerzési ár], [Selling_Price] as [Eladási ár] from [Books]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }

        public void display_books()
        {
            if (tB_ID.Text != "") {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Books] where Book_ID = '" + tB_ID.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;
                connection.Close(); 
            } else
            {
                MessageBox.Show("Nincs megadva könyv azonosító!");
            }
            float selling_price = 0;
            string purchese_price_string = tB_purchase_price.Text;
            float purchese_price = float.Parse(purchese_price_string.ToString());
            float clear_purchese_price = 0;
            clear_purchese_price += (purchese_price / 100 * 73);
            selling_price += clear_purchese_price / 100 * 125;
            selling_price = float.Parse(Math.Round(selling_price, 0).ToString());
            tB_selling_price.Text = selling_price.ToString();
        }

        private void books_display_Click(object sender, EventArgs e)
        {
            display_books();
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
            tB_selling_price.Text = "Hozzáadásnál nem kell megadni!";
        }

        private void button_new_book_Click(object sender, EventArgs e)
        {

            if (tB_ISBN.Text != "" && tB_author.Text != "" && tB_title.Text != "" &&
            tB_year.Text != "" && tB_genre.Text != "" && tB_publisher.Text != "" && tB_condition.Text != "" &&
            tB_binding.Text != "" && tB_pagenumber.Text != "" && tB_purchase_price.Text != "") {
                float selling_price = 0;
                float purchese_price = float.Parse(tB_purchase_price.Text.ToString());
                selling_price += purchese_price / 100 * 125 ;
                selling_price = float.Parse(Math.Round(selling_price, 0).ToString());
                string selling_price_string = selling_price.ToString();
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                SqlCommand cmd_id = connection.CreateCommand();
                SqlCommand cmd_expend = connection.CreateCommand();
                SqlCommand cmd_wish_count = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd_expend.CommandType = CommandType.Text;
                cmd_id.CommandType = CommandType.Text;
                cmd_wish_count.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Books] (ISBN, Author, Title, [Release year], Genre, Publisher, Condition, Binding, Pagenumber, [Purchase_Price], [Selling_Price]) " +
                    "values ('" + tB_ISBN.Text + "', '" + tB_author.Text + "', '" + tB_title.Text + "','" + int.Parse(tB_year.Text) + "', " +
                    "'" + tB_genre.Text + "', '" + tB_publisher.Text + "', '" + tB_condition.Text + "', '" + tB_binding.Text + "', " +
                    "'" + int.Parse(tB_pagenumber.Text) + "', '" + float.Parse(tB_purchase_price.Text) + "', '" + float.Parse(selling_price_string) + "')";
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
                    "values ('" + int.Parse(id.ToString()) + "', '" + name.ToString() + "', '" + float.Parse(tB_purchase_price.Text) +
                    "', '" + DateTime.Today.ToString(format) + "')";
                cmd_expend.ExecuteNonQuery();
                SqlDataReader read_wish_count = (null);
                cmd_wish_count.CommandText = "select COUNT(ISBN) as Count from [Wish_List] where ISBN = '" + tB_ISBN.Text + "'";
                cmd_wish_count.ExecuteNonQuery();
                read_wish_count = cmd_wish_count.ExecuteReader();
                read_wish_count.Read();
                int count = 0;
                count += int.Parse(read_wish_count["Count"].ToString());
                read_wish_count.Close();
                if(count > 0)
                {
                    SqlCommand cmd_wish = connection.CreateCommand();
                    SqlDataReader read_wish = (null);
                    cmd_wish.CommandText = "select TOP(1) * from [Wish_List] where ISBN = '" + tB_ISBN.Text + "'";
                    cmd_wish.ExecuteNonQuery();
                    read_wish = cmd_wish.ExecuteReader();
                    read_wish.Read();
                    string e_mail = "";
                    e_mail = read_wish["Customer_Email_Address"].ToString();
                    read_wish.Close();
                    send_mail(e_mail);
                } else
                {
                    MessageBox.Show("Nincs kívánság!");
                }


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
                    cmd.CommandText = "update [Books] set [Purchase_Price] = '" + float.Parse(tB_purchase_price.Text) + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_selling_price.Text != "") {
                    cmd.CommandText = "update [Books] set [Selling_Price] = '" + float.Parse(tB_selling_price.Text) + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
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

        public void send_mail(string e_mail) {
            try
            {
                login = new NetworkCredential("horeczky95@gmail.com", "louis123!!!");
                client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = login;
                msg = new MailMessage { From = new MailAddress("horeczky95@gmail.com") };
                msg.To.Add(e_mail);
                msg.Subject = "Keresett könyv beérkezett";
                msg.Body = "Tisztelt Vásárló!\nAz ön által keresett könyv mostantól megtalálható boltunkba.\nEz egy automatikus email kérem ne válaszoljon rá.\nAntikvár könyves bolt";
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                string userstate = "Sending...";
                client.SendAsync(msg, userstate);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Sikertelen küldés!" + ex.ToString());
            }
        }
    }
}
