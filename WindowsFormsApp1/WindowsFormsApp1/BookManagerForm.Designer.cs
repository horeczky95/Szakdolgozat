namespace WindowsFormsApp1
{
    partial class BookManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.antiqueDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.textBox_pagenumber = new System.Windows.Forms.TextBox();
            this.textBox_purchase_price = new System.Windows.Forms.TextBox();
            this.textBox_selling_price = new System.Windows.Forms.TextBox();
            this.display_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_ = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.súgóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.regularCustomerToolStripMenuItem,
            this.wishListToolStripMenuItem,
            this.statementsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(45, 26);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mainMenuToolStripMenuItem.Text = "Főmenü";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saleToolStripMenuItem.Text = "Eladás";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // regularCustomerToolStripMenuItem
            // 
            this.regularCustomerToolStripMenuItem.Name = "regularCustomerToolStripMenuItem";
            this.regularCustomerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.regularCustomerToolStripMenuItem.Text = "Törzsvásárlók";
            this.regularCustomerToolStripMenuItem.Click += new System.EventHandler(this.regularCustomerToolStripMenuItem_Click);
            // 
            // wishListToolStripMenuItem
            // 
            this.wishListToolStripMenuItem.Name = "wishListToolStripMenuItem";
            this.wishListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.wishListToolStripMenuItem.Text = "Kívánság lista";
            this.wishListToolStripMenuItem.Click += new System.EventHandler(this.wishListToolStripMenuItem_Click);
            // 
            // statementsToolStripMenuItem
            // 
            this.statementsToolStripMenuItem.Name = "statementsToolStripMenuItem";
            this.statementsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.statementsToolStripMenuItem.Text = "Kimutatások";
            this.statementsToolStripMenuItem.Click += new System.EventHandler(this.statementsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Kilépés";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.súgóToolStripMenuItem.Text = "Súgó";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.antiqueDBDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 360);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN szám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Szerző";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(50, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cím";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(50, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Műfaj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(50, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Oldalszám";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(50, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Beszerzési ár";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(50, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Eladási ár";
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Location = new System.Drawing.Point(200, 40);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(240, 22);
            this.textBox_ISBN.TabIndex = 10;
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(200, 70);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(240, 22);
            this.textBox_author.TabIndex = 11;
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(200, 100);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(240, 22);
            this.textBox_title.TabIndex = 12;
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(200, 130);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(240, 22);
            this.textBox_year.TabIndex = 13;
            // 
            // textBox_genre
            // 
            this.textBox_genre.Location = new System.Drawing.Point(200, 158);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.Size = new System.Drawing.Size(240, 22);
            this.textBox_genre.TabIndex = 14;
            // 
            // textBox_pagenumber
            // 
            this.textBox_pagenumber.Location = new System.Drawing.Point(200, 190);
            this.textBox_pagenumber.Name = "textBox_pagenumber";
            this.textBox_pagenumber.Size = new System.Drawing.Size(240, 22);
            this.textBox_pagenumber.TabIndex = 15;
            // 
            // textBox_purchase_price
            // 
            this.textBox_purchase_price.Location = new System.Drawing.Point(200, 220);
            this.textBox_purchase_price.Name = "textBox_purchase_price";
            this.textBox_purchase_price.Size = new System.Drawing.Size(240, 22);
            this.textBox_purchase_price.TabIndex = 16;
            // 
            // textBox_selling_price
            // 
            this.textBox_selling_price.Location = new System.Drawing.Point(200, 250);
            this.textBox_selling_price.Name = "textBox_selling_price";
            this.textBox_selling_price.Size = new System.Drawing.Size(240, 22);
            this.textBox_selling_price.TabIndex = 17;
            // 
            // display_button
            // 
            this.display_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.display_button.Location = new System.Drawing.Point(500, 40);
            this.display_button.Name = "display_button";
            this.display_button.Size = new System.Drawing.Size(174, 50);
            this.display_button.TabIndex = 18;
            this.display_button.Text = "Megjelenítés";
            this.display_button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(500, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Új könyv hozzáadása";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(500, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "Könyv módosítása";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_
            // 
            this.button_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_.Location = new System.Drawing.Point(500, 220);
            this.button_.Name = "button_";
            this.button_.Size = new System.Drawing.Size(174, 50);
            this.button_.TabIndex = 21;
            this.button_.Text = "Könyv módosítása";
            this.button_.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(50, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kiadás éve";
            // 
            // BookManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1006, 653);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display_button);
            this.Controls.Add(this.textBox_selling_price);
            this.Controls.Add(this.textBox_purchase_price);
            this.Controls.Add(this.textBox_pagenumber);
            this.Controls.Add(this.textBox_genre);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.textBox_ISBN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Könyv kezelő";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wishListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource antiqueDBDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ISBN;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.TextBox textBox_genre;
        private System.Windows.Forms.TextBox textBox_pagenumber;
        private System.Windows.Forms.TextBox textBox_purchase_price;
        private System.Windows.Forms.TextBox textBox_selling_price;
        private System.Windows.Forms.Button display_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_;
        private System.Windows.Forms.Label label6;
    }
}