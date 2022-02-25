using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

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

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'antiqueDBDataSet.Könyvek' table. You can move, or remove it, as needed.
            this.könyvekTableAdapter.Fill(this.antiqueDBDataSet.Könyvek);

        }
    }
}
