namespace WindowsFormsApp1
{
    partial class WishListForm
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
            this.bookManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kívánságlistaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.antiqueDBDataSet = new WindowsFormsApp1.AntiqueDBDataSet();
            this.kívánságlistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_ISBN = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_RegCust_ID = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Phone_number = new System.Windows.Forms.Label();
            this.label_Email_address = new System.Windows.Forms.Label();
            this.tB_ISBN = new System.Windows.Forms.TextBox();
            this.tB_author = new System.Windows.Forms.TextBox();
            this.tB_title = new System.Windows.Forms.TextBox();
            this.tB_RegCust = new System.Windows.Forms.TextBox();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.tB_add = new System.Windows.Forms.TextBox();
            this.tB_phone = new System.Windows.Forms.TextBox();
            this.tB_email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.kívánságlistaTableAdapter = new WindowsFormsApp1.AntiqueDBDataSetTableAdapters.KívánságlistaTableAdapter();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.label_Wish_ID = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kívánságlistaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kívánságlistaBindingSource)).BeginInit();
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
            this.bookManagerToolStripMenuItem,
            this.statementsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(45, 26);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.mainMenuToolStripMenuItem.Text = "Főmenü";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.saleToolStripMenuItem.Text = "Eladás";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // regularCustomerToolStripMenuItem
            // 
            this.regularCustomerToolStripMenuItem.Name = "regularCustomerToolStripMenuItem";
            this.regularCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.regularCustomerToolStripMenuItem.Text = "Törzsvásárlók";
            this.regularCustomerToolStripMenuItem.Click += new System.EventHandler(this.regularCustomerToolStripMenuItem_Click);
            // 
            // bookManagerToolStripMenuItem
            // 
            this.bookManagerToolStripMenuItem.Name = "bookManagerToolStripMenuItem";
            this.bookManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.bookManagerToolStripMenuItem.Text = "Könyv kezelő";
            this.bookManagerToolStripMenuItem.Click += new System.EventHandler(this.bookManagerToolStripMenuItem_Click);
            // 
            // statementsToolStripMenuItem
            // 
            this.statementsToolStripMenuItem.Name = "statementsToolStripMenuItem";
            this.statementsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.statementsToolStripMenuItem.Text = "Kimutatások";
            this.statementsToolStripMenuItem.Click += new System.EventHandler(this.statementsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 330);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG_double_Click);
            // 
            // kívánságlistaBindingSource1
            // 
            this.kívánságlistaBindingSource1.DataMember = "Kívánságlista";
            this.kívánságlistaBindingSource1.DataSource = this.antiqueDBDataSet;
            // 
            // antiqueDBDataSet
            // 
            this.antiqueDBDataSet.DataSetName = "AntiqueDBDataSet";
            this.antiqueDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kívánságlistaBindingSource
            // 
            this.kívánságlistaBindingSource.DataMember = "Kívánságlista";
            this.kívánságlistaBindingSource.DataSource = this.antiqueDBDataSet;
            // 
            // label_ISBN
            // 
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ISBN.Location = new System.Drawing.Point(40, 50);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(53, 20);
            this.label_ISBN.TabIndex = 9;
            this.label_ISBN.Text = "ISBN ";
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Author.Location = new System.Drawing.Point(40, 80);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(62, 20);
            this.label_Author.TabIndex = 10;
            this.label_Author.Text = "Szerző";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Title.Location = new System.Drawing.Point(40, 110);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(39, 20);
            this.label_Title.TabIndex = 11;
            this.label_Title.Text = "Cím";
            // 
            // label_RegCust_ID
            // 
            this.label_RegCust_ID.AutoSize = true;
            this.label_RegCust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_RegCust_ID.Location = new System.Drawing.Point(40, 140);
            this.label_RegCust_ID.Name = "label_RegCust_ID";
            this.label_RegCust_ID.Size = new System.Drawing.Size(207, 20);
            this.label_RegCust_ID.TabIndex = 12;
            this.label_RegCust_ID.Text = "Törzsvásárlói kód (ha van)";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Name.Location = new System.Drawing.Point(40, 170);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(106, 20);
            this.label_Name.TabIndex = 13;
            this.label_Name.Text = "Vásárló neve";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Address.Location = new System.Drawing.Point(40, 200);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(107, 20);
            this.label_Address.TabIndex = 14;
            this.label_Address.Text = "Vásárló címe";
            // 
            // label_Phone_number
            // 
            this.label_Phone_number.AutoSize = true;
            this.label_Phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Phone_number.Location = new System.Drawing.Point(40, 230);
            this.label_Phone_number.Name = "label_Phone_number";
            this.label_Phone_number.Size = new System.Drawing.Size(171, 20);
            this.label_Phone_number.TabIndex = 15;
            this.label_Phone_number.Text = "Vásárló telefonszáma";
            // 
            // label_Email_address
            // 
            this.label_Email_address.AutoSize = true;
            this.label_Email_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Email_address.Location = new System.Drawing.Point(40, 260);
            this.label_Email_address.Name = "label_Email_address";
            this.label_Email_address.Size = new System.Drawing.Size(152, 20);
            this.label_Email_address.TabIndex = 16;
            this.label_Email_address.Text = "Vásárló email címe";
            // 
            // tB_ISBN
            // 
            this.tB_ISBN.Location = new System.Drawing.Point(270, 50);
            this.tB_ISBN.Name = "tB_ISBN";
            this.tB_ISBN.Size = new System.Drawing.Size(250, 22);
            this.tB_ISBN.TabIndex = 1;
            // 
            // tB_author
            // 
            this.tB_author.Location = new System.Drawing.Point(270, 80);
            this.tB_author.Name = "tB_author";
            this.tB_author.Size = new System.Drawing.Size(250, 22);
            this.tB_author.TabIndex = 2;
            // 
            // tB_title
            // 
            this.tB_title.Location = new System.Drawing.Point(270, 110);
            this.tB_title.Name = "tB_title";
            this.tB_title.Size = new System.Drawing.Size(250, 22);
            this.tB_title.TabIndex = 3;
            // 
            // tB_RegCust
            // 
            this.tB_RegCust.Location = new System.Drawing.Point(270, 140);
            this.tB_RegCust.Name = "tB_RegCust";
            this.tB_RegCust.Size = new System.Drawing.Size(250, 22);
            this.tB_RegCust.TabIndex = 4;
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(270, 170);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(250, 22);
            this.tB_name.TabIndex = 5;
            // 
            // tB_add
            // 
            this.tB_add.Location = new System.Drawing.Point(270, 200);
            this.tB_add.Name = "tB_add";
            this.tB_add.Size = new System.Drawing.Size(250, 22);
            this.tB_add.TabIndex = 6;
            // 
            // tB_phone
            // 
            this.tB_phone.Location = new System.Drawing.Point(270, 232);
            this.tB_phone.Name = "tB_phone";
            this.tB_phone.Size = new System.Drawing.Size(250, 22);
            this.tB_phone.TabIndex = 7;
            // 
            // tB_email
            // 
            this.tB_email.Location = new System.Drawing.Point(270, 260);
            this.tB_email.Name = "tB_email";
            this.tB_email.Size = new System.Drawing.Size(250, 22);
            this.tB_email.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(570, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "Új kivánság hozzáadása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.new_wish_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button2.Location = new System.Drawing.Point(570, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 50);
            this.button2.TabIndex = 18;
            this.button2.Text = "Kívánságok megjelenítés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.wishList_display_click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(570, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 50);
            this.button3.TabIndex = 20;
            this.button3.Text = "Kívánság törlése";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.wish_delete_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(570, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 50);
            this.button4.TabIndex = 19;
            this.button4.Text = "Kívánság módosítása";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.wish_modification_Click);
            // 
            // kívánságlistaTableAdapter
            // 
            this.kívánságlistaTableAdapter.ClearBeforeFill = true;
            // 
            // tB_ID
            // 
            this.tB_ID.Location = new System.Drawing.Point(890, 258);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.Size = new System.Drawing.Size(63, 22);
            this.tB_ID.TabIndex = 22;
            // 
            // label_Wish_ID
            // 
            this.label_Wish_ID.AutoSize = true;
            this.label_Wish_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Wish_ID.Location = new System.Drawing.Point(765, 260);
            this.label_Wish_ID.Name = "label_Wish_ID";
            this.label_Wish_ID.Size = new System.Drawing.Size(99, 20);
            this.label_Wish_ID.TabIndex = 23;
            this.label_Wish_ID.Text = "Kívánság ID";
            // 
            // WishListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 653);
            this.Controls.Add(this.label_Wish_ID);
            this.Controls.Add(this.tB_ID);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tB_email);
            this.Controls.Add(this.tB_phone);
            this.Controls.Add(this.tB_add);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.tB_RegCust);
            this.Controls.Add(this.tB_title);
            this.Controls.Add(this.tB_author);
            this.Controls.Add(this.tB_ISBN);
            this.Controls.Add(this.label_Email_address);
            this.Controls.Add(this.label_Phone_number);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_RegCust_ID);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.label_ISBN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WishListForm";
            this.Text = "Kívánság lista";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kívánságlistaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kívánságlistaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_RegCust_ID;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Phone_number;
        private System.Windows.Forms.Label label_Email_address;
        private System.Windows.Forms.TextBox tB_ISBN;
        private System.Windows.Forms.TextBox tB_author;
        private System.Windows.Forms.TextBox tB_title;
        private System.Windows.Forms.TextBox tB_RegCust;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.TextBox tB_add;
        private System.Windows.Forms.TextBox tB_phone;
        private System.Windows.Forms.TextBox tB_email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private AntiqueDBDataSet antiqueDBDataSet;
        private System.Windows.Forms.BindingSource kívánságlistaBindingSource;
        private AntiqueDBDataSetTableAdapters.KívánságlistaTableAdapter kívánságlistaTableAdapter;
        private System.Windows.Forms.BindingSource kívánságlistaBindingSource1;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.Label label_Wish_ID;
    }
}