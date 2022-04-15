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
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class RegularCustomerForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Szakdolgozat\WindowsFormsApp1\WindowsFormsApp1\AntiqueDB.mdf;Integrated Security = True");
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

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
            cmd.CommandText = "select [Regular_Customer_ID] as [Törzsvásárlói kód], [Name] as Név, [Address] as Cím, [Born date] as [Születési idő], [Gender] as [Nem], [Phone_number] as [Telefon], " +
                "[Email_Address] as [Email cím], [Current_Points] as [Aktuális pontok], [Previous_Year_Points] as [Előző éves pontok] from [Regular_Customers]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView.DataSource = dta;
            connection.Close();
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void regcus_display_Click(object sender, EventArgs e)
        {
            if(tB_regcust_ID.Text != "" && tB_regcust_ID.Text != "Törzsvásárlói kód")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select [Regular_Customer_ID] as [Törzsvásárlói kód], [Name] as Név, [Address] as Cím, [Born date] as [Születési idő], [Gender] as [Nem], [Phone_number] as Telefonszám, " +
                    "[Email_Address] as [Email cím], [Current_Points] as [Aktuális pontok], [Previous_Year_Points] as [Előző éves pontok] from [Regular_Customers] where [Regular_Customer_ID] = '" + tB_regcust_ID.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView.DataSource = dta;
                connection.Close();
            } else
            {
                display_data();
            }
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void new_regcust_Click(object sender, EventArgs e)
        {
            

            if ( tB_name.Text != "" && tB_name.Text != "Teljes név" && tB_address.Text != "" && tB_address.Text != "Lakcím" 
                && cB_gender.Text != "" && cB_gender.Text != "Nem" && tB_phone.Text != "" && tB_phone.Text != "Telefonszám"
                && tB_email.Text != "" && tB_email.Text != "Email cím")
            {
                string format = "yyyy. MM. dd";
                DateTime born_date = dtP_born_date.Value;
                string born_date_string = born_date.ToString(format);
                string date = null;
                date += born_date_string[0].ToString()+ born_date_string[1].ToString() + born_date_string[2].ToString() + born_date_string[3].ToString() + born_date_string[6].ToString() + born_date_string[7].ToString();
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
                SqlDataReader reader = (null);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Count(Name) as count from [Regular_Customers] where [Regular_Customer_ID] = '" + reg_cust.ToString() + "'";
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                reader.Read();
                int count = int.Parse(reader["count"].ToString());
                reader.Close();
                if (count == 0)
                {
                    cmd.CommandText = "insert into [Regular_Customers] (Regular_Customer_ID, Name, Address, [Born date], Gender, [Phone_Number], [Email_Address], [Current_Points], [Previous_Year_Points]) " +
                        "values ('" + reg_cust.ToString() + "', '" + tB_name.Text + "', '" + tB_address.Text + "','" + born_date.ToString(format) + "', " +
                        "'" + gender.ToString() + "', '" + tB_phone.Text + "', '" + tB_email.Text + "', '" + 0 + "', " + "'" + 0 + "')";
                    cmd.ExecuteNonQuery();
                } else
                {
                    reg_cust = reg_cust.Remove(0, 1);
                    int first_char = int.Parse(born_date_string[0].ToString());
                    first_char += 1;
                    reg_cust = first_char.ToString() + reg_cust;
                    cmd.CommandText = "insert into [Regular_Customers] (Regular_Customer_ID, Name, Address, [Born date], Gender, [Phone_Number], [Email_Address], [Current_Points], [Previous_Year_Points]) " +
                        "values ('" + reg_cust.ToString() + "', '" + tB_name.Text + "', '" + tB_address.Text + "','" + born_date.ToString(format) + "', " +
                        "'" + gender.ToString() + "', '" + tB_phone.Text + "', '" + tB_email.Text + "', '" + 0 + "', " + "'" + 0 + "')";
                    cmd.ExecuteNonQuery();
                }

                send_mail(tB_email.Text.ToString(), reg_cust.ToString());
                connection.Close();
                tB_name.ForeColor = Color.Gray;
                tB_name.Text = "Teljes név";
                tB_address.ForeColor = Color.Gray;
                tB_address.Text = "Lakcím";
                cB_gender.ForeColor = Color.Gray;
                cB_gender.Text = "Nem";
                tB_phone.ForeColor = Color.Gray;
                tB_phone.Text = "Telefonszám";
                tB_email.ForeColor = Color.Gray;
                tB_email.Text = "Email cím";
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
            cmd.CommandText = "delete from [Regular_Customers] where Regular_Customer_ID = '" + tB_regcust_ID.Text +"'";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data();
            tB_regcust_ID.ForeColor = Color.Gray;
            tB_regcust_ID.Text = "Törzsvásárlói kód";
        }

        private void regcus_modification_Click(object sender, EventArgs e)
        {
            if (tB_regcust_ID.Text != "" && tB_regcust_ID.Text != "Törzsvásárlói kód")
            {
                string format = "yyyy. MM. dd";
                DateTime date = new DateTime();
                DateTime new_date = dtP_born_date.Value;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                SqlDataReader reader = (null);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Regular_Customers] where Regular_Customer_ID = '" + tB_regcust_ID.Text + "'";
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                reader.Read();
                date = DateTime.Parse(reader["Born date"].ToString());
                reader.Close();
                if (tB_name.Text != "" && tB_name.Text != "Teljes név")
                {
                    cmd.CommandText = "update [Regular_Customers] set Name = '" + tB_name.Text + "' where Regular_Customer_ID = '" + tB_regcust_ID.Text + "'";
                    tB_name.ForeColor = Color.Gray;
                    tB_name.Text = "Teljes név";                    
                }
                else if (tB_address.Text != "" && tB_address.Text != "Lakcím")
                {
                    cmd.CommandText = "update [Regular_Customers] set Address = '" + tB_address.Text + "' where Regular_Customer_ID = '" + tB_regcust_ID.Text + "'";
                    tB_address.ForeColor = Color.Gray;
                    tB_address.Text = "Lakcím";
                }
                else if (dtP_born_date.Value.ToString() != "" && dtP_born_date.Value.ToString(format) != date.ToString(format))
                {
                    cmd.CommandText = "update [Regular_Customers] set [Born date] = '" + new_date.ToString(format) + "' where Regular_Customer_ID = '" + tB_regcust_ID.Text + "'";
                }
                else if (cB_gender.Text != "" && cB_gender.Text != "Nem")
                {
                    cmd.CommandText = "update [Regular_Customers] set Gender = '" + cB_gender.Text + "' where Regular_Customer_ID = '" + tB_regcust_ID.Text + "'";
                    cB_gender.ForeColor = Color.Gray;
                    cB_gender.Text = "Nem";                    
                }
                else if (tB_phone.Text != "" && tB_phone.Text != "Telefonszám")
                {
                    cmd.CommandText = "update [Regular_Customers] set  [Phone_Number] = '" + tB_phone.Text + "' where Regular_Customer_ID = '" + tB_regcust_ID.Text  + "'";
                    tB_phone.ForeColor = Color.Gray;
                    tB_phone.Text = "Telefonszám";                    
                }
                else if (tB_email.Text != "" && tB_email.Text != "Email cím")
                {
                    cmd.CommandText = "update [Regular_Customers] set [Email_Address]= '" + tB_email.Text + "' where Regular_Customer_ID = '" + tB_regcust_ID.Text + "'";
                    tB_email.ForeColor = Color.Gray;
                    tB_email.Text = "Email cím";
                }
                else
                {
                    MessageBox.Show("Hiányzó adat!");
                    cmd.CommandText = "select * from [Books]";
                }
                tB_regcust_ID.ForeColor = Color.Gray;
                tB_regcust_ID.Text = "Törzsvásárló kód";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data();
            }
            else
            {
                MessageBox.Show("Nincs meg adva ID!");
            }
        }

        private void dG_double_Click(object sender, DataGridViewCellEventArgs e)
        {
            tB_regcust_ID.ForeColor = Color.Black;
            tB_regcust_ID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        //Email

        public void send_mail(string e_mail, string regcust_id)
        {
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
                msg.Body = "Tisztelt Vásárló!<br /><br />" +
                    "A mai nap folyamán Önt, mint törzsvásárló regisztráltuk rendszerünkbe.<br /><br />" +
                    "Az Ön új törzsvásárlói kódja: " + regcust_id +
                    ". Üdvözöljük törzsvásárlóink között. Reméljük mihamarabb vissza tér üzletünkbe.<br /><br />" +
                    "Üdvözlettel: <br />Antikvár könyves bolt";
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

        //Formázás
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

        private void tB_name_Enter(object sender, EventArgs e)
        {
            if (tB_name.Text == "Teljes név")
            {
                tB_name.Text = "";
                tB_name.ForeColor = Color.Black;
            }
        }

        private void tB_name_Leave(object sender, EventArgs e)
        {
            if (tB_name.Text == "")
            {
                tB_name.Text = "Teljes név";
                tB_name.ForeColor = Color.Gray;
            }
        }

        private void cB_gender_Enter(object sender, EventArgs e)
        {
            if (cB_gender.Text == "Nem")
            {
                cB_gender.Text = "";
                cB_gender.ForeColor = Color.Black;
            }
        }

        private void cB_gender_Leave(object sender, EventArgs e)
        {
            if (cB_gender.Text == "")
            {
                cB_gender.Text = "Nem";
                cB_gender.ForeColor = Color.Gray;
            }
        }

        private void tB_address_Enter(object sender, EventArgs e)
        {
            if (tB_address.Text == "Lakcím")
            {
                tB_address.Text = "";
                tB_address.ForeColor = Color.Black;
            }
        }

        private void tB_address_Leave(object sender, EventArgs e)
        {
            if (tB_address.Text == "")
            {
                tB_address.Text = "Lakcím";
                tB_address.ForeColor = Color.Gray;
            }
        }

        private void tB_phone_Enter(object sender, EventArgs e)
        {
            if (tB_phone.Text == "Telefonszám")
            {
                tB_phone.Text = "";
                tB_phone.ForeColor = Color.Black;
            }
        }

        private void tB_phone_Leave(object sender, EventArgs e)
        {
            if (tB_phone.Text == "")
            {
                tB_phone.Text = "Telefonszám";
                tB_phone.ForeColor = Color.Gray;
            }
        }

        private void tB_email_Enter(object sender, EventArgs e)
        {
            if (tB_email.Text == "Email cím")
            {
                tB_email.Text = "";
                tB_email.ForeColor = Color.Black;
            }
        }

        private void tB_email_Leave(object sender, EventArgs e)
        {
            if (tB_email.Text == "")
            {
                tB_email.Text = "Email cím";
                tB_email.ForeColor = Color.Gray;
            }
        }

        private void form_Close_Click(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
