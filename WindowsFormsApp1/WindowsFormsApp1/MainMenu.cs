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

    public partial class MainMenu : Form
    {
        public class Customer
        {
            public string email { get; set; }
            public float previous_points { get; set; }
        }

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\SULI\SZAKDOLGOZAT\WINDOWSFORMSAPP1\WINDOWSFORMSAPP1\ANTIQUEDB.MDF;Integrated Security = True");
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public MainMenu()
        {
            InitializeComponent();
            display_data();
            update_points();
            points_mail();
        }

        //Menü

        private void saleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaleForm sale = new SaleForm();
            sale.Show();
            this.Hide();
        }

        private void regularCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        //Gombok

        private void sale_Click(object sender, EventArgs e)
        {
            SaleForm sale = new SaleForm();
            sale.Show();
            this.Hide();
        }

        private void regular_customer_Click(object sender, EventArgs e)
        {
            RegularCustomerForm regCust = new RegularCustomerForm();
            regCust.Show();
            this.Hide();
        }

        private void book_manager_Click(object sender, EventArgs e)
        {
            BookManagerForm bookMan = new BookManagerForm();
            bookMan.Show();
            this.Hide();
        }

        private void wish_list_Click(object sender, EventArgs e)
        {
            WishListForm wishList = new WishListForm();
            wishList.Show();
            this.Hide();
        }

        private void statments_Click(object sender, EventArgs e)
        {
            StatementsForm state = new StatementsForm();
            state.Show();
            this.Hide();
        }

        //Adatbázis műveletek

        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [ISBN], [Author] as [Szerző], [Title] as [Cím], [Release_Year] as [Kiadás], [Genre] as [Műfaj], [Publisher] as [Kiadó], [Pagenumber] as [Oldal-\nszám], [Condition] as [Állapot]" +
                ", [Binding] as [Kötés], [Purchase_Price] as [Beszer. ár], [Selling_Price] as [Elad. ár] from [Books]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView.DataSource = dta;
            connection.Close();
            dataGridView.AutoResizeColumns(); 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void update_points()
        {
            string format = "MM.dd";
            DateTime today = DateTime.Parse(DateTime.UtcNow.ToString(format));
            DateTime update_date = DateTime.Parse( new DateTime(2022, 01, 01).ToString(format));
            DateTime clear_date = DateTime.Parse(new DateTime(2022, 04, 30).ToString(format));
            connection.Open();
            SqlCommand cmd_previous_points = connection.CreateCommand();
            SqlDataReader read = (null);
            cmd_previous_points.CommandText = ("select SUM(Previous_Year_Points) as sum from Regular_Customers");
            cmd_previous_points.ExecuteNonQuery();
            read = cmd_previous_points.ExecuteReader();
            read.Read();
            float previous_points = float.Parse(read["sum"].ToString());
            read.Close();
            if (previous_points == 0)
            {
                if (today >= update_date && today < clear_date )
                {
                    SqlCommand cmd_previous_points_update = connection.CreateCommand();
                    cmd_previous_points_update.CommandType = CommandType.Text;
                    cmd_previous_points_update.CommandText = "update [Regular_Customers] set [Previous_Year_Points] = [Current_Points]";
                    cmd_previous_points_update.ExecuteNonQuery();
                    SqlCommand cmd_current_points_update = connection.CreateCommand();
                    cmd_current_points_update.CommandType = CommandType.Text;
                    cmd_current_points_update.CommandText = "update [Regular_Customers] set [Current_Points] = 0";
                    cmd_current_points_update.ExecuteNonQuery();
                }
            } else if (previous_points > 0)
            {
                if (today >= clear_date)
                {
                    SqlCommand cmd_previous_points_update = connection.CreateCommand();
                    cmd_previous_points_update.CommandType = CommandType.Text;
                    cmd_previous_points_update.CommandText = "update [Regular_Customers] set [Previous_Year_Points] = 0";
                    cmd_previous_points_update.ExecuteNonQuery();

                }
            }
            connection.Close();
        }

        //email küldések

        public void points_mail()
        {
            List<Customer> customers = new List<Customer>();
            connection.Open();
            SqlCommand cmd_customers = connection.CreateCommand();
            SqlDataReader reader = (null);
            cmd_customers.CommandType = CommandType.Text;
            cmd_customers.CommandText = "select * from [Regular_Customers] where [Previous_Year_Points] > 0";
            cmd_customers.ExecuteNonQuery();
            reader = cmd_customers.ExecuteReader();
            while(reader.Read())
            {
                Customer c = new Customer();
                c.email = reader["Email_Address"].ToString();
                c.previous_points = float.Parse(reader["Previous_Year_Points"].ToString());
                customers.Add(c);
            }
            reader.Close();
            connection.Close();
            string format = "MM.dd";
            DateTime today = DateTime.Parse(DateTime.UtcNow.ToString(format));
            DateTime mail_date_start = DateTime.Parse(new DateTime(2022, 03, 01).ToString(format));
            DateTime mail_date_finish = DateTime.Parse(new DateTime(2022, 03, 07).ToString(format));
            if (today >= mail_date_start && today < mail_date_finish)
            {
                foreach(Customer c in customers)
                {
                    send_mail(c.email, c.previous_points);
                }
            }
            customers.Clear();
        }

        public void send_mail(string e_mail, float points)
        {
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
                string message = "Tisztelt Vásárló!<br /><br />Önnek " + points.ToString() + 
                    " pontja maradt az előző évről. Ezeket Március 31.-ig tudja felhasználni. Megértését köszönjük." +
                    "<br /><br />Ez egy automatikus email kérem ne válaszoljon rá.<br /><br />Üdvözlettel:Antikvár könyves bolt";
                message = message.Replace("/n", Environment.NewLine);
                msg.Body = message;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                string userstate = "Sending...";
                client.SendAsync(msg, userstate);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Sikertelen küldés!" + ex.ToString());
            }
        }


        private void button_help_click(object sender, EventArgs e)
        {
            MessageBox.Show("A fő menűből a az oldalsó gombok lenyomásával léphetünk tovább a többi ablak segytségével.");
        }
    }
}
