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
    public partial class RegularCustomerForm : Form
    {
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
    }
}
