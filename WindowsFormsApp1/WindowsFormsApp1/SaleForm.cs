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
using ZXing;

namespace WindowsFormsApp1
{
    public partial class SaleForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\SULI\SZAKDOLGOZAT\WINDOWSFORMSAPP1\WINDOWSFORMSAPP1\ANTIQUEDB.MDF;Integrated Security = True");
        List<int> books_ID = new List<int>();
        float subtotal = 0;
        float total = 0;

        public SaleForm()
        {
            InitializeComponent();
            display_data();
            for (int i = 0; i < books_ID.Count; i++)
            {
                books_ID.Remove(books_ID[i]);
            }
            display_regcust();
        }

        //Menü

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

        //Adatbázis műveletek
        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Book_ID] as [ID], [ISBN], [Author] as [Szerző], [Title] as [Cím], [Release_Year] as [Kiadás\néve], [Genre] as [Műfaj], [Publisher] as [Kiadó], [Pagenumber] as [Oldal-\nszám], [Condition] as [Állapot]" +
                ", [Binding] as [Kötés], [Purchase_Price] as [Beszer.\nár], [Selling_Price] as [Elad.\nár] from [Books]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView_books.DataSource = dta;
            connection.Close();
        }

        public void display_regcust()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Regular_Customer_ID] as ID, [Name] as Név, [Current_Points] as Pontok, [Previous_Year_Points] as [Előző éves pontok] from [Regular_Customers]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView_regcust.DataSource = dta;
            connection.Close();
        }

        public void search_data()
        {
            if (tB_ISBN.Text != "" && tB_ISBN.Text != "ISBN")
            {
                tB_author.Text = "";
                tB_title.Text = "";
                tB_year.Text = "";
                tB_genre.Text = "";
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select [ISBN], [Author] as [Szerző], [Title] as [Cím], [Release_Year] as [Kiadás\néve], [Genre] as [Műfaj], [Publisher] as [Kiadó], [Pagenumber] as [Oldalszám], [Condition] as [Állapot]" +
                ", [Binding] as [Kötés], [Purchase_Price] as [Beszer.\nár], [Selling_Price] as [Elad.\nár] from [Books] where [ISBN] like '%" + tB_ISBN.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView_books.DataSource = dta;
                connection.Close();
                tB_ISBN.Text = "ISBN";
                tB_ISBN.ForeColor = Color.Gray;
                tB_author.Text = "Szerző";
                tB_title.Text = "Cím";
                tB_year.Text = "Kiadás éve";
                tB_genre.Text = "Műfaj";
            } else if (tB_author.Text != "" && tB_author.Text != "Szerző")
            {
                tB_ISBN.Text = "";
                tB_title.Text = "";
                tB_year.Text = "";
                tB_genre.Text = "";
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select [ISBN], [Author] as [Szerző], [Title] as [Cím], [Release_Year] as [Kiadás\néve], [Genre] as [Műfaj], [Publisher] as [Kiadó], [Pagenumber] as [Oldal-\nszám], [Condition] as [Állapot]" +
                ", [Binding] as [Kötés], [Purchase_Price] as [Beszer.\nár], [Selling_Price] as [Elad.\nár] from [Books] where [Author] like '%" + tB_author.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView_books.DataSource = dta;
                connection.Close();
                tB_ISBN.Text = "ISBN";
                tB_author.Text = "Szerző";
                tB_author.ForeColor = Color.Gray;
                tB_title.Text = "Cím";
                tB_year.Text = "Kiadás éve";
                tB_genre.Text = "Műfaj";
            }
            else if (tB_title.Text != "" && tB_title.Text != "Cím")
            {
                tB_ISBN.Text = "";
                tB_author.Text = "";
                tB_year.Text = "";
                tB_genre.Text = "";
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select [ISBN], [Author] as [Szerző], [Title] as [Cím], [Release_Year] as [Kiadás\néve], [Genre] as [Műfaj], [Publisher] as [Kiadó], [Pagenumber] as [Oldal-\nszám], [Condition] as [Állapot]" +
                ", [Binding] as [Kötés], [Purchase_Price] as [Beszer.\nár], [Selling_Price] as [Elad.\nár] from [Books] where [Title] like '%" + tB_title.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView_books.DataSource = dta;
                connection.Close();
                tB_ISBN.Text = "ISBN";
                tB_author.Text = "Szerző";
                tB_title.Text = "Cím";
                tB_title.ForeColor = Color.Gray;
                tB_year.Text = "Kiadás éve";
                tB_genre.Text = "Műfaj";
            }
            else if (tB_year.Text != "" && tB_year.Text != "Kiadás éve")
            {
                tB_ISBN.Text = "";
                tB_author.Text = "";
                tB_title.Text = "";
                tB_genre.Text = "";
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select [ISBN], [Author] as [Szerző], [Title] as [Cím], [Release_Year] as [Kiadás\néve], [Genre] as [Műfaj], [Publisher] as [Kiadó], [Pagenumber] as [Oldal-\nszám], [Condition] as [Állapot]" +
                ", [Binding] as [Kötés], [Purchase_Price] as [Beszer.\nár], [Selling_Price] as [Elad.\nár] from [Books] where [Release_Year] = '" + tB_year.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView_books.DataSource = dta;
                connection.Close();
                tB_ISBN.Text = "ISBN";
                tB_author.Text = "Szerző";
                tB_title.Text = "Cím";
                tB_year.Text = "Kiadás éve";
                tB_year.ForeColor = Color.Gray;
                tB_genre.Text = "Műfaj";
            }
            else if (tB_genre.Text != "" && tB_genre.Text != "Műfaj")
            {
                tB_ISBN.Text = "";
                tB_author.Text = "";
                tB_title.Text = "";
                tB_year.Text = "";
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select [ISBN], [Author] as [Szerző], [Title] as [Cím], [Release_Year] as [Kiadás\néve], [Genre] as [Műfaj], [Publisher] as [Kiadó], [Pagenumber] as [Oldal-\nszám], [Condition] as [Állapot]" +
                ", [Binding] as [Kötés], [Purchase_Price] as [Beszer.\nár], [Selling_Price] as [Elad.\nár] from [Books] where [Genre] like '%" + tB_genre.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView_books.DataSource = dta;
                connection.Close();
                tB_ISBN.Text = "ISBN";
                tB_author.Text = "Szerző";
                tB_title.Text = "Cím";
                tB_year.Text = "Kiadás éve";
                tB_genre.Text = "Műfaj";
                tB_genre.ForeColor = Color.Gray;
            } else
            {
                MessageBox.Show("Nincs meghatározva egyik adat sem! Nem lehetséges a keresés.");
            }

        }

        private void dG_double_Click(object sender, DataGridViewCellEventArgs e)
        {
            tB_ISBN.ForeColor = Color.Black;
            tB_ISBN.Text = dataGridView_books.CurrentRow.Cells[1].Value.ToString();
            tB_author.ForeColor = Color.Black;
            tB_author.Text = dataGridView_books.CurrentRow.Cells[2].Value.ToString();
            tB_title.ForeColor = Color.Black;
            tB_title.Text = dataGridView_books.CurrentRow.Cells[3].Value.ToString();
            tB_year.ForeColor = Color.Black;
            tB_year.Text = dataGridView_books.CurrentRow.Cells[4].Value.ToString();
            tB_genre.ForeColor = Color.Black;
            tB_genre.Text = dataGridView_books.CurrentRow.Cells[5].Value.ToString();
            tB_id.ForeColor = Color.Black;
            tB_id.Text = dataGridView_books.CurrentRow.Cells[0].Value.ToString();

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
            if(tB_ISBN.Text != "" && tB_ISBN.Text != "ISBN" 
                && tB_author.Text != "" && tB_author.Text != "Szerző"
                && tB_title.Text != "" && tB_title.Text != "Cím"
                && tB_year.Text != "" && tB_year.Text != "Kiadás éve"
                && tB_genre.Text != "" && tB_genre.Text != "Műfaj"
                && tB_id.Text != "" && tB_id.Text != "ID")
            {
                
                connection.Open();
                SqlCommand cmd_price = connection.CreateCommand();
                SqlDataReader read = (null);
                cmd_price.CommandType = CommandType.Text;
                cmd_price.CommandText = ("select * from Books where Book_ID = '" + tB_id.Text + "'");
                cmd_price.ExecuteNonQuery();
                read = cmd_price.ExecuteReader();
                read.Read();
                subtotal = float.Parse(read["Selling_Price"].ToString());
                total += subtotal;
                string price = read["Selling_Price"].ToString();
                read.Close();
                if(tB_id.Text != "" && tB_ISBN.Text != "" && tB_author.Text != "" && tB_title.Text != "")
                {
                    ListViewItem item = new ListViewItem(tB_id.Text);
                    item.SubItems.Add(tB_ISBN.Text);
                    item.SubItems.Add(tB_author.Text);
                    item.SubItems.Add(tB_title.Text);
                    item.SubItems.Add(price);
                    listView.Items.Add(item);
                    label_subtotal.Text = subtotal.ToString() + " Ft";
                    label_total.Text = total.ToString() + " Ft";
                    books_ID.Add(int.Parse(tB_id.Text));
                }
                connection.Close();

            } else
            {
                MessageBox.Show("Hiányos adatok");
            }
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
            tB_id.ForeColor = Color.Gray;
            tB_id.Text = "ID";
        }

        private void list_click(object sender, MouseEventArgs e)
        {
            tB_id.ForeColor = Color.Black;
            tB_id.Text = listView.SelectedItems[0].SubItems[0].Text;
            tB_ISBN.ForeColor = Color.Black;
            tB_ISBN.Text = listView.SelectedItems[0].SubItems[1].Text;
            tB_author.ForeColor = Color.Black;
            tB_author.Text = listView.SelectedItems[0].SubItems[2].Text;
            tB_title.ForeColor = Color.Black;
            tB_title.Text = listView.SelectedItems[0].SubItems[3].Text;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd_price = connection.CreateCommand();
            SqlDataReader read = (null);
            cmd_price.CommandText = ("select * from Books where Book_ID = '" + tB_id.Text + "'");
            cmd_price.ExecuteNonQuery();
            read = cmd_price.ExecuteReader();
            read.Read();
            subtotal = float.Parse(read["Selling_Price"].ToString());
            total -= subtotal;
            label_subtotal.Text = "0 Ft";
            label_total.Text = total.ToString() + " Ft";
            read.Close();
            listView.Items.Remove(listView.SelectedItems[0]);
            connection.Close();
            tB_id.ForeColor = Color.Gray;
            tB_id.Text = "ID";
        }

        private void sale_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (tB_regcust_ID.Text != "" && tB_regcust_ID.Text != "Törzsvásárlói kód")
            {
                SqlCommand cmd_regcust = connection.CreateCommand();
                cmd_regcust.CommandType = CommandType.Text;
                SqlDataReader read = (null);
                cmd_regcust.CommandText = ("select * from Regular_Customers where Regular_Customer_ID = '" + tB_regcust_ID.Text + "'");
                cmd_regcust.ExecuteNonQuery();
                read = cmd_regcust.ExecuteReader();
                read.Read();
                float current_points = float.Parse(read["Current_Points"].ToString());
                read.Close();
                current_points += total/100;
                SqlCommand cmd_regcust2 = connection.CreateCommand();
                cmd_regcust2.CommandType = CommandType.Text;
                cmd_regcust2.CommandText = "update [Regular_Customers] set Current_Points = '" + float.Parse(current_points.ToString()) + "' where Regular_Customer_ID = '" + tB_regcust_ID.Text + "'";
                cmd_regcust2.ExecuteNonQuery();
                tB_id.ForeColor = Color.Gray;
                tB_id.Text = "ID";
                tB_ISBN.ForeColor = Color.Gray;
                tB_ISBN.Text = "ISBN";
                tB_author.ForeColor = Color.Gray;
                tB_author.Text = "Szerző";
                tB_title.ForeColor = Color.Gray;
                tB_title.Text = "Cím";
            }
            for (int i= 0; i < books_ID.Count; i++)
            {
                SqlCommand cmd_ISBN = connection.CreateCommand();
                cmd_ISBN.CommandType = CommandType.Text;
                SqlDataReader read = (null);
                cmd_ISBN.CommandText = ("select * from Books where Book_ID = '" + books_ID[i].ToString() + "'");
                cmd_ISBN.ExecuteNonQuery();
                read = cmd_ISBN.ExecuteReader();
                read.Read();
                string ISBN = read["ISBN"].ToString();
                read.Close();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [Books] where [Book_ID] = '" + books_ID[i].ToString() + "'";
                cmd.ExecuteNonQuery();
                SqlCommand cmd_wish = connection.CreateCommand();
                cmd_wish.CommandType = CommandType.Text;
                cmd_wish.CommandText = "delete from [Wish_List] where [ISBN] = '" + ISBN + "' and [Regular_Customer_ID] = '" + tB_regcust_ID.Text + "'";
                cmd_wish.ExecuteNonQuery();
            }
            for(int i = 0; i < books_ID.Count; i++)
            {
                books_ID.Remove(books_ID[i]);
            }
            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            string format = "yyyy.MM.dd";
            cmd2.CommandText = "insert into [Revenues] (Amount, Date) values ('" + total + "', '" + DateTime.Today.ToString(format) + "')";
            total = 0;
            cmd2.ExecuteNonQuery();
            connection.Close();
            label_subtotal.Text = "0 Ft";
            label_total.Text = "0 Ft";
            display_data();
            tB_regcust_ID.ForeColor = Color.Gray;
            tB_regcust_ID.Text = "Törzsvásárlói kód";
        }

        private void discount_Click(object sender, EventArgs e)
        {
            if (tB_book_discount.Text != "" && tB_book_discount.Text != "Könyv kedvezmény")
            {
                float salenumber = float.Parse(tB_book_discount.Text.ToString()) / 100;
                connection.Open();
                SqlCommand cmd_price = connection.CreateCommand();
                SqlDataReader read = (null);
                cmd_price.CommandText = ("select * from Books where Book_ID = '" + tB_id.Text + "'");
                cmd_price.ExecuteNonQuery();
                read = cmd_price.ExecuteReader();
                read.Read();
                subtotal = float.Parse(read["Selling_Price"].ToString());
                float sale = subtotal * salenumber;
                subtotal -= sale;
                total -= sale;
                label_subtotal.Text = subtotal.ToString() + " Ft";
                label_total.Text = total.ToString() + " Ft";
                read.Close();
                connection.Close();
                tB_book_discount.ForeColor = Color.Gray;
                tB_book_discount.Text = "Könyv kedvezmény";
                tB_id.ForeColor = Color.Gray;
                tB_id.Text = "ID";
            } else if (tB_total_discount.Text != "" && tB_total_discount.Text != "Végösszeg kedvezmény")
            {
                float salenumber = float.Parse(tB_total_discount.Text.ToString()) / 100;
                float sale = total * salenumber;
                total -= sale;
                label_total.Text = total.ToString() + " Ft";
                tB_total_discount.ForeColor = Color.Gray;
                tB_total_discount.Text = "Végösszeg kedvezmény";
                tB_id.ForeColor = Color.Gray;
                tB_id.Text = "ID";
            } else
            {
                MessageBox.Show("Nincs megadva kedvezmény mérték!");
            }
        }

        private void reg_cust_point_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            if(tB_regcust_ID.Text != "" && tB_regcust_ID.Text != "Törzsvásárlói kód")
            {
                SqlCommand cmd_regcust = connection.CreateCommand();
                SqlCommand cmd_regcust2 = connection.CreateCommand();
                cmd_regcust.CommandType = CommandType.Text;
                cmd_regcust2.CommandType = CommandType.Text;
                SqlDataReader read = (null);
                cmd_regcust.CommandText = ("select * from Regular_Customers where Regular_Customer_ID = '" + tB_regcust_ID.Text + "'");
                cmd_regcust.ExecuteNonQuery();
                read = cmd_regcust.ExecuteReader();
                read.Read();
                float current_points = float.Parse(read["Current_Points"].ToString());
                float previous_points = float.Parse(read["Previous_Year_Points"].ToString());
                read.Close();
                if(previous_points > 0)
                {
                    if (previous_points < total)
                    {
                        total -= previous_points;
                        cmd_regcust2.CommandText = "update [Regular_Customers] set Previous_Year_Points = '" + 0 + "' where Regular_Customer_ID = '" + tB_regcust_ID.Text + "'";
                    } else
                    {
                        previous_points -= total;
                        total = 0;
                        cmd_regcust2.CommandText = "update [Regular_Customers] set Previous_Year_Points = '" + previous_points.ToString() + "' where Regular_Customer_ID = '" + tB_regcust_ID.Text + "'";

                    }
                } else if( current_points > 0)
                {
                    if (current_points < total)
                    {
                        total -= current_points;
                        cmd_regcust2.CommandText = "update [Regular_Customers] set Current_Points = '" + 0 + "' where Regular_Customer_ID = '" + tB_regcust_ID.Text + "'";
                    } else
                    {
                        current_points -= total;
                        total = 0;
                        cmd_regcust2.CommandText = "update [Regular_Customers] set Current_Points = '" + current_points.ToString() + "' where Regular_Customer_ID = '" + tB_regcust_ID.Text + "'";

                    }
                }
                cmd_regcust2.ExecuteNonQuery();
                label_total.Text = total.ToString() + " Ft";
            }
            connection.Close();
            display_regcust();
            tB_regcust_ID.ForeColor = Color.Gray;
            tB_regcust_ID.Text = "Törzsvásárlói kód";
        }

        private void reg_cust_db_double_click(object sender, DataGridViewCellEventArgs e)
        {
            tB_regcust_ID.Text = dataGridView_regcust.CurrentRow.Cells[0].Value.ToString();
        }

        private void barcode_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPG| *.jpg" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pB_barcode.Image = Image.FromFile(ofd.FileName);
                    BarcodeReader reader = new BarcodeReader();
                    var result = reader.Decode((Bitmap)pB_barcode.Image);
                    if(result != null)
                    {
                        tB_barcode.Text = result.ToString();
                    }
                    connection.Open();
                    SqlCommand cmd_read = connection.CreateCommand();
                    SqlCommand cmd_ISBN = connection.CreateCommand();
                    SqlDataReader read = (null);
                    cmd_read.CommandType = CommandType.Text;
                    cmd_ISBN.CommandType = CommandType.Text;
                    cmd_read.CommandText = "select Count(ISBN) as count from [Books] where [ISBN] = '" + tB_barcode.Text + "'";
                    cmd_read.ExecuteNonQuery();
                    read = cmd_read.ExecuteReader();
                    read.Read();
                    int count = int.Parse(read["count"].ToString());
                    read.Close();
                    if(count >= 1)
                    {
                        cmd_ISBN.CommandText = "select [Book_ID] as [ID], [ISBN], [Author] as [Szerző], [Title] as [Cím], [Release_Year] as [Kiadás\néve], [Genre] as [Műfaj], [Publisher] as [Kiadó], [Pagenumber] as [Oldal-\nszám], [Condition] as [Állapot]" +
                ", [Binding] as [Kötés], [Purchase_Price] as [Beszer.\nár], [Selling_Price] as [Elad.\nár] from [Books] where [ISBN]= '" + tB_barcode.Text + "'";
                        cmd_ISBN.ExecuteNonQuery();
                    } else
                    {
                        string barcode = tB_barcode.Text;
                        string ISBN = barcode[3].ToString() + barcode[4].ToString() + barcode[5].ToString() + barcode[6].ToString() + barcode[7].ToString() + barcode[8].ToString() + barcode[9].ToString() + barcode[10].ToString() + barcode[11].ToString();
                        tB_barcode.Text = ISBN.ToString();
                        cmd_ISBN.CommandText = "select [Book_ID] as [ID], [ISBN], [Author] as [Szerző], [Title] as [Cím], [Release_Year] as [Kiadás\néve], [Genre] as [Műfaj], [Publisher] as [Kiadó], [Pagenumber] as [Oldal-\nszám], [Condition] as [Állapot]" +
                ", [Binding] as [Kötés], [Purchase_Price] as [Beszer.\nár], [Selling_Price] as [Elad.\nár] from [Books] where [ISBN] like '%" + ISBN.ToString() + "%'";
                        cmd_ISBN.ExecuteNonQuery();
                    }
                    DataTable dta = new DataTable();
                    SqlDataAdapter dataadp = new SqlDataAdapter(cmd_ISBN);
                    dataadp.Fill(dta);
                    dataGridView_books.DataSource = dta;
                    connection.Close();

                }
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

        private void tB_year_Enter(object sender, EventArgs e)
        {
            if (tB_year.Text == "Kiadás éve")
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
            if (tB_genre.Text == "Műfaj")
            {
                tB_genre.Text = "";
                tB_genre.ForeColor = Color.Black;
            }
        }

        private void tB_genre_Leave(object sender, EventArgs e)
        {
            if (tB_genre.Text == "")
            {
                tB_genre.Text = "Műfaj";
                tB_genre.ForeColor = Color.Gray;
            }
        }

        private void tB_ID_Enter(object sender, EventArgs e)
        {
            if (tB_id.Text == "ID")
            {
                tB_id.Text = "";
                tB_id.ForeColor = Color.Black;
            }
        }

        private void tB_ID_Leave(object sender, EventArgs e)
        {
            if (tB_id.Text == "")
            {
                tB_id.Text = "ID";
                tB_id.ForeColor = Color.Gray;
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

        private void tB_book_discount_Enter(object sender, EventArgs e)
        {
            if (tB_book_discount.Text == "Könyv kedvezmény")
            {
                tB_book_discount.Text = "";
                tB_book_discount.ForeColor = Color.Black;
            }
        }

        private void tB_book_discount_Leave(object sender, EventArgs e)
        {
            if (tB_book_discount.Text == "")
            {
                tB_book_discount.Text = "Könyv kedvezmény";
                tB_book_discount.ForeColor = Color.Gray;
            }
        }

        private void tB_total_discount_Enter(object sender, EventArgs e)
        {
            if (tB_total_discount.Text == "Végösszeg kedvezmény")
            {
                tB_total_discount.Text = "";
                tB_total_discount.ForeColor = Color.Black;
            }
        }

        private void tB_total_discount_Leave(object sender, EventArgs e)
        {
            if (tB_total_discount.Text == "")
            {
                tB_total_discount.Text = "Végösszeg kedvezmény";
                tB_total_discount.ForeColor = Color.Gray;
            }
        }

        private void tB_barcode_Enter(object sender, EventArgs e)
        {
            if (tB_barcode.Text == "Vonalkód")
            {
                tB_barcode.Text = "";
                tB_barcode.ForeColor = Color.Black;
            }
        }

        private void tB_barcode_Leave(object sender, EventArgs e)
        {
            if (tB_barcode.Text == "")
            {
                tB_barcode.Text = "Vonalkód";
                tB_barcode.ForeColor = Color.Gray;
            }
        }

        private void form_Close_Click(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Súgó

        private void help_add_click(object sender, EventArgs e)
        {
            MessageBox.Show("Könyv kosárba helyezése\nKönyv vásárlás esetén az első lépés a könyv kosárba helyezése. " +
                "A könyvet az ISBN száma alapján megkeressük a rendszerbe és kosárba helyezzük.Az első könyv kosárba helyezésekor létre jön egy lista, " +
                "amely a kosárba helyezett könyvek azonosítóját tartalmazza." +
                "Ezen felül egy táblázat segítségével megjelenik a kosártartalma is. " +
                "Ebben a táblázatban a könyv ISBN száma, szerzője, címe és eladási ár jelenik meg. " +
                "Minden könyv kosárba helyezésekor a kosár alatt megjelenik az aktuális könyv ára mint részösszeg, " +
                "valamint minden alkalommal frissül a teljes fizetendő összeg is a hozzá adott könyv árával növelve. " +
                "Ha minden könyv bekerült a kosárba akkor tudunk kedvezményeket adni, pontot levonni, illetve a könyveket eladni.");
        }
    }
}
