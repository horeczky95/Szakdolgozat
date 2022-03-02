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

        private void info_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Új törzsvásárló regisztrálása esetén a " +
                "törzsvásárlói kód kialakítása a következők képpen történik.\n" +
                "-> Első 6 karakter: A vásárló születési dátumának éve és a hónapja számokban megadva.\n" +
                "-> Ezt követi a nem meghatározás egy karakterrel: hölgy esetén 1, úr esetében 2.\n" +
                "-> Az utolsó két karakter a vezeték név első két karaktere nagy betűvel írva.\n" +
                "-> Péládul Kis Pista törzsvásárlói kódja aki 1975. Március 05. született: 1975032KP.\n" +
                "-> Abban az esetben, ha már létezne hasonló kód az adatbázisban, akkor a születési dátum első számjegyét eggyel meg kell növelnünk.\n");
        }

        private void new_regcust_Click(object sender, EventArgs e)
        {
            

            if ( tB_name.Text != "" && tB_address.Text != "" && tB_born_date.Text != "" && cB_gender.Text != "" && tB_phone.Text != "" && tB_email.Text != "")
            {
                string tb_born = tB_born_date.Text;
                string date = null;
                date += tb_born[0].ToString()+ tb_born[1].ToString() + tb_born[2].ToString() + tb_born[3].ToString() + tb_born[5].ToString() + tb_born[6].ToString();
                string gender_number, gender;
                if (cB_gender.Text == "Nő"){
                    gender_number = "1";
                    gender = "Nő";
                } else {
                    gender_number = "2";
                    gender = "Férfi";
                }
                string nick_name = tB_name.Text;
                string name = null;
                name += nick_name[0].ToString() + nick_name[1].ToString().ToUpper();
                string reg_cust = null;
                reg_cust += date.ToString() + gender_number.ToString() + name.ToString();
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Törzsvásárlók] (Törzsvásárlói_id, Név, Cím, [Születési dátum], Nem, Telefonszám, [E-mail cím], [Aktuális pontok], [Előző éves pontok]) " +
                    "values ('" + reg_cust.ToString() + "', '" + tB_name.Text + "', '" + tB_address.Text + "','" + tB_born_date.Text + "', " +
                    "'" + gender.ToString()+ "', '" + tB_phone.Text + "', '" + tB_email.Text + "', '" + 0 + "', " + "'" + 0 + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                tB_regCus_ID.Text = "";
                tB_name.Text = "";
                tB_address.Text = "";
                tB_born_date.Text = "";
                cB_gender.Text = "";
                tB_phone.Text = "";
                tB_email.Text = "";
                display_data();
            }
            else
            {
                MessageBox.Show("Hiányosak az adatok!");
            }
        }

        private void delete_regcus_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Törzsvásárlók] where Törzsvásárlói_id = '" + tB_regCus_ID.Text +"'";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data();
        }

        private void regcus_modification_Click(object sender, EventArgs e)
        {
            if (tB_regCus_ID.Text != "")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (tB_name.Text != "")
                {
                    cmd.CommandText = "update [Törzsvásárlók] set Név = '" + tB_name.Text + "' where Törzsvásárlói_id = '" + tB_regCus_ID.Text + "'";
                    tB_name.Text = "";
                }
                else if (tB_address.Text != "")
                {
                    cmd.CommandText = "update [Törzsvásárlók] set Cím = '" + tB_address.Text + "' where Törzsvásárlói_id = '" + tB_regCus_ID.Text + "'";
                    tB_address.Text = "";
                }
                else if (tB_born_date.Text != "")
                {
                    cmd.CommandText = "update [Törzsvásárlók] set [Születési dátum] = '" + tB_born_date.Text + "' where Törzsvásárlói_id = '" + tB_regCus_ID.Text + "'";
                    tB_born_date.Text = "";
                }
                else if (cB_gender.Text != "")
                {
                    cmd.CommandText = "update [Törzsvásárlók] set Nem = '" + cB_gender.Text + "' where Törzsvásárlói_id = '" + tB_regCus_ID.Text + "'";
                    cB_gender.Text = "";
                }
                else if (tB_phone.Text != "")
                {
                    cmd.CommandText = "update [Törzsvásárlók] set  Telefonszám = '" + tB_phone.Text + "' where Törzsvásárlói_id = '" + tB_regCus_ID.Text  + "'";
                    tB_phone.Text = "";
                }
                else if (tB_email.Text != "")
                {
                    cmd.CommandText = "update [Törzsvásárlók] set [Email cím]= '" + tB_email.Text + "' where Törzsvásárlói_id = '" + tB_regCus_ID.Text + "'";
                    tB_email.Text = "";
                }
                else
                {
                    MessageBox.Show("Hiányzó adat!");
                    cmd.CommandText = "select * from [Könyvek]";
                }
                tB_regCus_ID.Text = "";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data();
            }
            else
            {
                MessageBox.Show("Nincs meg adva ID!");
            }
        }
    }

}
