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
                "-> Az utolsó két karakter a vezeték név és a keresztnév kezdő betűi nagy betűvel írva.\n" +
                "-> Péládul Kis Pista törzsvásárlói kódja aki 1975. Március 05. született: 1975032KP.\n" +
                "-> Abban az esetben, ha már létezne hasonló kód az adatbázisban, akkor a születési dátum első számjegyét eggyel meg kell növelnünk.\n");
        }

        private void new_regcust_Click(object sender, EventArgs e)
        {

        }
    }

}
