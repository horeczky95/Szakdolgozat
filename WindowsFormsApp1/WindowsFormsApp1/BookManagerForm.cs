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
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\SULI\SZAKDOLGOZAT\WINDOWSFORMSAPP1\WINDOWSFORMSAPP1\ANTIQUEDB.MDF;Integrated Security = True");
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
            cmd.CommandText = "select [Book_ID] as ID, [ISBN], [Author] as [Szerző], [Title] as [Cím], [Release_Year] as [Kiadás\néve], [Genre] as [Műfaj], [Publisher] as [Kiadó], [Pagenumber] as [Oldal-\nszám], [Condition] as [Állapot]" +
                ", [Binding] as [Kötés], [Purchase_Price] as [Beszer\nár], [Selling_Price] as [Elad.\nár] from [Books]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView.DataSource = dta;
            connection.Close();
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        public void display_books()
        {
            if (tB_ID.Text != "" && tB_ID.Text != "Könyv ID") {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Books] where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView.DataSource = dta;
                connection.Close();
                tB_ID.ForeColor = Color.Gray;
                tB_ID.Text = "Könyv ID";
            } else
            {
                MessageBox.Show("Nincs megadva könyv azonosító!");
            }
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void books_display_Click(object sender, EventArgs e)
        {
            display_books();
        }

        public void textClear()
        {
            tB_ID.ForeColor = Color.Gray;
            tB_ID.Text = "Könyv ID";
            tB_ISBN.ForeColor = Color.Gray;
            tB_ISBN.Text = "ISBN";
            tB_author.ForeColor = Color.Gray;
            tB_author.Text = "Szerző";
            tB_title.ForeColor = Color.Gray;
            tB_title.Text = "Cím";
            tB_year.ForeColor = Color.Gray;
            tB_year.Text = "Kiadás éve";
            tB_genre.ForeColor = Color.Gray;
            tB_genre.Text = "Műfaj";
            tB_publisher.ForeColor = Color.Gray;
            tB_publisher.Text = "Kiadó";
            tB_condition.ForeColor = Color.Gray;
            tB_condition.Text = "Állapot";
            tB_binding.ForeColor = Color.Gray;
            tB_binding.Text = "Kötés";
            tB_pagenumber.ForeColor = Color.Gray;
            tB_pagenumber.Text = "Oldalszám";
            tB_purchase_price.ForeColor = Color.Gray;
            tB_purchase_price.Text = "Beszerzési ár forintban";
            tB_selling_price.ForeColor = Color.Gray;
            tB_selling_price.Text = "Hozzáadásnál nem kell megadni!";
        }

        private void button_new_book_Click(object sender, EventArgs e)
        {

            if (tB_ISBN.Text != "" && tB_author.Text != "" && tB_title.Text != "" &&
            tB_year.Text != "" && tB_genre.Text != "" && tB_publisher.Text != "" && tB_condition.Text != "" &&
            tB_binding.Text != "" && tB_pagenumber.Text != "" && tB_purchase_price.Text != "" && tB_ISBN.Text != "ISBN" &&
            tB_author.Text != "Szerző" && tB_title.Text != "Cím" && tB_year.Text != "Kiadás éve" && tB_genre.Text != "Műfaj" &&
            tB_publisher.Text != "Kiadó" && tB_condition.Text != "Állapot" && tB_binding.Text != "Kötés" &&
            tB_pagenumber.Text != "Oldalszám" && tB_purchase_price.Text != "") {
                float selling_price = 0;
                float purchese_price = float.Parse(tB_purchase_price.Text.ToString());
                selling_price += purchese_price / 100 * 125;
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
                cmd.CommandText = "insert into [Books] (ISBN, Author, Title, [Release_Year], Genre, Publisher, Condition, Binding, Pagenumber, [Purchase_Price], [Selling_Price]) " +
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
                cmd_expend.CommandText = "insert into [Costs] (Book_ID, Name, Amount, Date) " +
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
                if (count > 0)
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
            if (tB_ID.Text != "" && tB_ID.Text != "Könyv ID")
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
            if (tB_ID.Text != "" && tB_ID.Text != "Könyv ID")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (tB_ISBN.Text != "" && tB_ISBN.Text != "ISBN")
                {
                    cmd.CommandText = "update [Books] set ISBN = '"+ tB_ISBN.Text +"' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_author.Text != "" && tB_author.Text != "Szerző") {
                    cmd.CommandText = "update [Books] set Author = '" + tB_author.Text + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_title.Text != "" && tB_title.Text != "Cím") {
                    cmd.CommandText = "update [Books] set Title = '" + tB_title.Text + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_year.Text != "" && tB_year.Text != "Kiadás éve") {
                    cmd.CommandText = "update [Books] set [Release_Year]= '" + int.Parse(tB_year.Text) + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_genre.Text != "" && tB_genre.Text != "Műfaj") {
                    cmd.CommandText = "update [Books] set Genre= '" + tB_genre.Text + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_publisher.Text != "" && tB_publisher.Text != "Kiadó") {
                    cmd.CommandText = "update [Books] set Publisher = '" + tB_publisher.Text + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_condition.Text != "" && tB_condition.Text != "Állapot") {
                    cmd.CommandText = "update [Books] set Condition = '" + tB_condition.Text+ "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_binding.Text != "" && tB_binding.Text != "Kötés") {
                    cmd.CommandText = "update [Books] set Binding = '" + tB_binding.Text + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_pagenumber.Text != "" && tB_pagenumber.Text != "Oldalszám") {
                    cmd.CommandText = "update [Books] set Pagenumber = '" + int.Parse(tB_pagenumber.Text) + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_purchase_price.Text != "" && tB_purchase_price.Text != "Beszerzési ár forintban") {
                    cmd.CommandText = "update [Books] set [Purchase_Price] = '" + float.Parse(tB_purchase_price.Text) + "' where Book_ID = '" + int.Parse(tB_ID.Text) + "'";
                } else if (tB_selling_price.Text != "" && tB_selling_price.Text != "Hozzáadásnál nem kell megadni!") {
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
            tB_ID.ForeColor = Color.Black;
            tB_ID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        //Email

        public void send_mail(string e_mail) {
            try
            {
                login = new NetworkCredential("horeczky95@gmail.com", "2020junius24");
                client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = login;
                msg = new MailMessage { From = new MailAddress("horeczky95@gmail.com") };
                msg.To.Add(e_mail);
                msg.Subject = "Keresett könyv beérkezett";
                msg.Body = "Tisztelt Vásárló!<br /><br />" +
                    "Az ön által keresett könyv mostantól megtalálható boltunkba.<br /><br />" +
                    "Ez egy automatikus email kérem ne válaszoljon rá.<br /><br />Antikvár könyves bolt<br /><br />" +
                    "Üdvözlettel:Antikvár könyves bolt";
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
            if(tB_author.Text == "Szerző")
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

        private void tB_year_Enter(object sender, EventArgs e)
        {
            if(tB_year.Text == "Kiadás éve")
            {
                tB_year.Text = "";
                tB_year.ForeColor = Color.Black;
            }
        }

        private void tB_year_Leave(object sender, EventArgs e)
        {
            if (tB_year.Text == "")
            {
                tB_year.Text = "Kiadás éve";
                tB_year.ForeColor = Color.Gray;
            }
        }

        private void tB_genre_Enter(object sender, EventArgs e)
        {
            if(tB_genre.Text == "Műfaj")
            {
                tB_genre.Text = "";
                tB_genre.ForeColor = Color.Black;
            }
        }

        private void tB_genre_Leave(object sender, EventArgs e)
        {
            if(tB_genre.Text == "")
            {
                tB_genre.Text = "Műfaj";
                tB_genre.ForeColor = Color.Gray;
            }
        }

        private void tB_publisher_Enter(object sender, EventArgs e)
        {
            if(tB_publisher.Text == "Kiadó")
            {
                tB_publisher.Text = "";
                tB_publisher.ForeColor = Color.Black;
            }
        }

        private void tB_publisher_Leave(object sender, EventArgs e)
        {
            if (tB_publisher.Text == "")
            {
                tB_publisher.Text = "Kiadó";
                tB_publisher.ForeColor = Color.Gray;
            }
        }

        private void tB_condition_Enter(object sender, EventArgs e)
        {
            if (tB_condition.Text == "Állapot")
            {
                tB_condition.Text = "";
                tB_condition.ForeColor = Color.Black;
            }
        }

        private void tB_condition_Leave(object sender, EventArgs e)
        {
            if (tB_condition.Text == "")
            {
                tB_condition.Text = "Állapot";
                tB_condition.ForeColor = Color.Gray;
            }
        }

        private void tB_binding_Enter(object sender, EventArgs e)
        {
            if(tB_binding.Text == "Kötés")
            {
                tB_binding.Text = "";
                tB_binding.ForeColor = Color.Black;
            }
        }

        private void tB_binding_Leave(object sender, EventArgs e)
        {
            if (tB_binding.Text == "")
            {
                tB_binding.Text = "Kötés";
                tB_binding.ForeColor = Color.Gray;
            }
        }

        private void tB_pagenumber_Enter(object sender, EventArgs e)
        {
            if(tB_pagenumber.Text == "Oldalszám")
            {
                tB_pagenumber.Text = "";
                tB_pagenumber.ForeColor = Color.Black;
            }
        }

        private void tB_pagenumber_Leave(object sender, EventArgs e)
        {
            if(tB_pagenumber.Text == "")
            {
                tB_pagenumber.Text = "Oldalszám";
                tB_pagenumber.ForeColor = Color.Gray;
            }
        }

        private void tB_purchase_price_Enter(object sender, EventArgs e)
        {
            if(tB_purchase_price.Text == "Beszerzési ár forintban")
            {
                tB_purchase_price.Text = "";
                tB_purchase_price.ForeColor = Color.Black;
            }
        }

        private void tB_purchase_price_Leave(object sender, EventArgs e)
        {
            if (tB_purchase_price.Text == "")
            {
                tB_purchase_price.Text = "Beszerzési ár forintban";
                tB_purchase_price.ForeColor = Color.Gray;
            }
        }
        private void tB_selling_price_Enter(object sender, EventArgs e)
        {
            if (tB_selling_price.Text == "Hozzáadásnál nem kell megadni!")
            {
                tB_selling_price.Text = "";
                tB_selling_price.ForeColor = Color.Black;
            }
        }

        private void tB_selling_price_Leave(object sender, EventArgs e)
        {
            if (tB_selling_price.Text == "")
            {
                tB_selling_price.Text = "Hozzáadásnál nem kell megadni!";
                tB_selling_price.ForeColor = Color.Gray;
            }
        }

        private void tB_ID_Enter(object sender, EventArgs e)
        {
            if(tB_ID.Text == "Könyv ID")
            {
                tB_ID.Text = "";
                tB_ID.ForeColor = Color.Black;
            }
        }

        private void tB_ID_Leave(object sender, EventArgs e)
        {
            if (tB_ID.Text == "")
            {
                tB_ID.Text = "Könyv ID";
                tB_ID.ForeColor = Color.Gray;
            }
        }

        private void form_Close_Click(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void new_book_help_click(object sender, EventArgs e)
        {
            MessageBox.Show("Új könyv hozzáadása!\n\nMinden adatot megkell adni az eladási ár és a könyv azonosítóját kivéve." +
                " Ezt követően az új  könyv hozzáadása gombra kattintva elmentésre kerül a könyv." +
                " Utána ellenőrizni kell, hogy a funkció sikeresen végre hajtodott.");
        }

        private void book_modification_help_click(object sender, EventArgs e)
        {
            MessageBox.Show("Könyv adatainak módosítása!\n\nElőszőr megkell adni a módosítani kívánt köny azonosítóját majd azon adatot amit módosítani akarunk." +
                " Gomb nyomást követően ellenőrizni kell a sikeres lefutást.");
        }

        private void book_delete_help_click(object sender, EventArgs e)
        {
            MessageBox.Show("Könyv törlése!\n\nA könyv azonosítóját megadva a törlés gomb megnyomásával lehet a könyvet törölni.");
        }
    }
}
