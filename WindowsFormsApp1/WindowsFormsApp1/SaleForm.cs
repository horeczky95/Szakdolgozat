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
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Suli\Szakdolgozat\WindowsFormsApp1\WindowsFormsApp1\AntiqueDB.mdf;Integrated Security = True");
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
            cmd.CommandText = "select * from [Books]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }

        public void display_regcust()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Regular_Customer_ID] as Azonosító, [Name] as Név, [Current_Points] as Pontok, [Previous_Year_Points] as [Előző éves pontok] from [Regular_Customers]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView2.DataSource = dta;
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
                    listView1.Items.Add(item);
                    label_subtotal.Text = subtotal.ToString() + " Ft";
                    label_total.Text = total.ToString() + " Ft";
                    books_ID.Add(int.Parse(tB_id.Text));
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

        private void list_click(object sender, MouseEventArgs e)
        {
            tB_id.Text = listView1.SelectedItems[0].SubItems[0].Text;
            tB_ISBN.Text = listView1.SelectedItems[0].SubItems[1].Text;
            tB_author.Text = listView1.SelectedItems[0].SubItems[2].Text;
            tB_title.Text = listView1.SelectedItems[0].SubItems[3].Text;
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
            listView1.Items.Remove(listView1.SelectedItems[0]);
            connection.Close();
            tB_id.Clear();
        }

        private void sale_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (tB_RegCust_ID.Text != "")
            {
                SqlCommand cmd_regcust = connection.CreateCommand();
                cmd_regcust.CommandType = CommandType.Text;
                SqlDataReader read = (null);
                cmd_regcust.CommandText = ("select * from Regular_Customers where Regular_Customer_ID = '" + tB_RegCust_ID.Text + "'");
                cmd_regcust.ExecuteNonQuery();
                read = cmd_regcust.ExecuteReader();
                read.Read();
                float current_points = float.Parse(read["Current_Points"].ToString());
                read.Close();
                current_points += total/100;
                SqlCommand cmd_regcust2 = connection.CreateCommand();
                cmd_regcust2.CommandType = CommandType.Text;
                cmd_regcust2.CommandText = "update [Regular_Customers] set Current_Points = '" + float.Parse(current_points.ToString()) + "' where Regular_Customer_ID = '" + tB_RegCust_ID.Text + "'";
                cmd_regcust2.ExecuteNonQuery();
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
                cmd_wish.CommandText = "delete from [Wish_List] where [ISBN] = '" + ISBN + "' and [Regular_Customer_ID] = '" + tB_RegCust_ID.Text + "'";
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
            tB_RegCust_ID.Clear();
        }

        private void discount_Click(object sender, EventArgs e)
        {
            if (tB_book_discount.Text != "")
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
                tB_book_discount.Clear();
                tB_id.Clear();
            } else if (tB_total_discount.Text != "")
            {
                float salenumber = float.Parse(tB_total_discount.Text.ToString()) / 100;
                float sale = total * salenumber;
                total -= sale;
                label_total.Text = total.ToString() + " Ft";
                tB_total_discount.Clear();
                tB_id.Clear();
            } else
            {
                MessageBox.Show("Nincs megadva kedvezmény mérték!");
            }
        }


        private void reg_cust_point_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            if(tB_RegCust_ID.Text != "")
            {
                SqlCommand cmd_regcust = connection.CreateCommand();
                SqlCommand cmd_regcust2 = connection.CreateCommand();
                cmd_regcust.CommandType = CommandType.Text;
                cmd_regcust2.CommandType = CommandType.Text;
                SqlDataReader read = (null);
                cmd_regcust.CommandText = ("select * from Regular_Customers where Regular_Customer_ID = '" + tB_RegCust_ID.Text + "'");
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
                        cmd_regcust2.CommandText = "update [Regular_Customers] set Previous_Year_Points = '" + 0 + "' where Regular_Customer_ID = '" + tB_RegCust_ID.Text + "'";
                    } else
                    {
                        previous_points -= total;
                        total = 0;
                        cmd_regcust2.CommandText = "update [Regular_Customers] set Previous_Year_Points = '" + previous_points.ToString() + "' where Regular_Customer_ID = '" + tB_RegCust_ID.Text + "'";

                    }
                } else if( current_points > 0)
                {
                    if (current_points < total)
                    {
                        total -= current_points;
                        cmd_regcust2.CommandText = "update [Regular_Customers] set Current_Points = '" + 0 + "' where Regular_Customer_ID = '" + tB_RegCust_ID.Text + "'";
                    } else
                    {
                        current_points -= total;
                        total = 0;
                        cmd_regcust2.CommandText = "update [Regular_Customers] set Current_Points = '" + current_points.ToString() + "' where Regular_Customer_ID = '" + tB_RegCust_ID.Text + "'";

                    }
                }
                cmd_regcust2.ExecuteNonQuery();
                label_total.Text = total.ToString() + " Ft";
            }
            connection.Close();
            display_regcust();
            tB_RegCust_ID.Clear();
        }

        private void reg_cust_db_double_click(object sender, DataGridViewCellEventArgs e)
        {
            tB_RegCust_ID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

    }
}
