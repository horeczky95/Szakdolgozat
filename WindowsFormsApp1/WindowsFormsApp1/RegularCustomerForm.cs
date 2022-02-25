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
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class RegularCustomerForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Suli\GitHub\WindowsFormsApp1\WindowsFormsApp1\AntiqueDB.mdf;Integrated Security = True");
        public RegularCustomerForm()
        {
            InitializeComponent();
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
            cmd.CommandText = "select * from [Törzsvásárlók]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView.DataSource = dta;
            connection.Close();

        }
        private void regcus_display_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if(textBox_torzsvasarloi_kod.Text != "" && textBox_name.Text != "" && textBox_address.Text != "" && textBox_born_date.Text != "" && comboBox_gender != null 
                && textBox_phone_number.Text != "" && textBox_email_address.Text != "")
            {
                dataBase.openConnection();
                cmd = new SQLiteCommand("INSERT INTO RegularCustomer(" +
                    "Regular_customer_id, Name, Address, Born_date, Gender, Phone_number, Email_address, Current_points, Previous_annual_points) values " +
                    "('" + textBox_torzsvasarloi_kod.Text + "', '" + textBox_name.Text + "', '" + textBox_address.Text + "', '" + textBox_born_date.Text + "', '" +
                    comboBox_gender.Text + "', '" + textBox_phone_number.Text + "', '" + textBox_email_address.Text + "', '" + 0 + "', '" + 0 + "')", dataBase.GetConnection());
                cmd.ExecuteNonQuery();
                dataBase.closeConnection();
            } else
            {
                MessageBox.Show("\tHiányzó adat!");
            }*/

        }

        private void info_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Új törzsvásárló regisztrálása esetén a " +
                "törzsvásárlói kód kialakítása a következők képpen történik.\n" +
                "-> Első 6 karakter: A vásárló születési dátumának éve és a hónapja számokban megadva.\n" +
                "-> Ezt követi a nem meghatározás egy karakterrel: hölgy esetén 1, úr esetében 2.\n" +
                "-> Az utolsó két karakter a vezeték név és a keresztnév kezdő betűi nagy betűvel írva.\n" +
                "-> Péládul Kis Pista törzsvásárlói kódja aki 1975. Március 05. született: 1975032KP.\n" +
                "-> Abban az esetben, ha már létezne hasonló kód az adatbázisban, akkor a születési dátum első számjegyét eggyel meg kell növelnünk.\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*dataBase.openConnection();
            cmd = new SQLiteCommand("UPDATE RegularCustomer SET name = '" + textBox_name.Text + "', Born_date = '" + textBox_born_date.Text +
                                                            "', Gender = '" + comboBox_gender.Text + "', Address = '" + textBox_address.Text +
                                                            "', Phone_Number = '" + textBox_phone_number.Text + "', Email_address = '" + textBox_email_address.Text + "' " +
                                                            "WHERE Regular_customer_id = '" + textBox_torzsvasarloi_kod.Text + "'", dataBase.GetConnection());
            cmd.ExecuteNonQuery();
            dataBase.closeConnection();
            cmd = new SQLiteCommand("SELECT * FROM RegularCustomer", dataBase.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataBase.closeConnection();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /*if (textBox_torzsvasarloi_kod.Text != "")
            {
                dataBase.openConnection();
                cmd = new SQLiteCommand("DELETE FROM RegularCustomer WHERE Regular_customer_id = '" + textBox_torzsvasarloi_kod.Text + "'", dataBase.GetConnection());
                cmd.ExecuteNonQuery();
                dataBase.closeConnection();
            }
            else
            {
                MessageBox.Show("Nincs megadva törzsvásárlói kód!");
            }*/
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView.CurrentRow.Selected = true;
                textBox_torzsvasarloi_kod.Text = dataGridView.Rows[e.RowIndex].Cells["Regular_customer_id"].FormattedValue.ToString();
                textBox_name.Text = dataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                textBox_born_date.Text = dataGridView.Rows[e.RowIndex].Cells["Born_date"].FormattedValue.ToString();
                comboBox_gender.Text = dataGridView.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                textBox_address.Text = dataGridView.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                textBox_phone_number.Text = dataGridView.Rows[e.RowIndex].Cells["Phone_number"].FormattedValue.ToString();
                textBox_email_address.Text = dataGridView.Rows[e.RowIndex].Cells["Email_address"].FormattedValue.ToString();
                
            }*/
        }

        private void RegularCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'antiqueDBDataSet.Törzsvásárlók' table. You can move, or remove it, as needed.

        }
    }
}
