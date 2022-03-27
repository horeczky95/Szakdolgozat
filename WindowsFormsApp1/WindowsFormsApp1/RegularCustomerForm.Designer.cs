namespace WindowsFormsApp1
{
    partial class RegularCustomerForm
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
            this.bookManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Born_date = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Phone_number = new System.Windows.Forms.Label();
            this.label_Email_address = new System.Windows.Forms.Label();
            this.label_RegCust_ID = new System.Windows.Forms.Label();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.tB_address = new System.Windows.Forms.TextBox();
            this.tB_phone = new System.Windows.Forms.TextBox();
            this.tB_email = new System.Windows.Forms.TextBox();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.cB_gender = new System.Windows.Forms.ComboBox();
            this.display_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.törzsvásárlókBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.antiqueDBDataSet = new WindowsFormsApp1.AntiqueDBDataSet();
            this.törzsvásárlókTableAdapter = new WindowsFormsApp1.AntiqueDBDataSetTableAdapters.TörzsvásárlókTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_born_date = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.törzsvásárlókBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.bookManagerToolStripMenuItem,
            this.wishListToolStripMenuItem,
            this.statementsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.mainMenuToolStripMenuItem.Text = "Főmenü";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.saleToolStripMenuItem.Text = "Eladás";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // bookManagerToolStripMenuItem
            // 
            this.bookManagerToolStripMenuItem.Name = "bookManagerToolStripMenuItem";
            this.bookManagerToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.bookManagerToolStripMenuItem.Text = "Könyv kezelő";
            this.bookManagerToolStripMenuItem.Click += new System.EventHandler(this.bookManagerToolStripMenuItem_Click);
            // 
            // wishListToolStripMenuItem
            // 
            this.wishListToolStripMenuItem.Name = "wishListToolStripMenuItem";
            this.wishListToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.wishListToolStripMenuItem.Text = "Kívánság lista";
            this.wishListToolStripMenuItem.Click += new System.EventHandler(this.wishListToolStripMenuItem_Click);
            // 
            // statementsToolStripMenuItem
            // 
            this.statementsToolStripMenuItem.Name = "statementsToolStripMenuItem";
            this.statementsToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.statementsToolStripMenuItem.Text = "Kimutatások";
            this.statementsToolStripMenuItem.Click += new System.EventHandler(this.statementsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.exitToolStripMenuItem.Text = "Kilépés";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.súgóToolStripMenuItem.Text = "Súgó";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Name.Location = new System.Drawing.Point(36, 94);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(38, 20);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Név";
            // 
            // label_Born_date
            // 
            this.label_Born_date.AutoSize = true;
            this.label_Born_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Born_date.Location = new System.Drawing.Point(36, 134);
            this.label_Born_date.Name = "label_Born_date";
            this.label_Born_date.Size = new System.Drawing.Size(129, 20);
            this.label_Born_date.TabIndex = 3;
            this.label_Born_date.Text = "Születési dátum";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Gender.Location = new System.Drawing.Point(36, 174);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(44, 20);
            this.label_Gender.TabIndex = 4;
            this.label_Gender.Text = "Nem";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Address.Location = new System.Drawing.Point(36, 214);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(39, 20);
            this.label_Address.TabIndex = 5;
            this.label_Address.Text = "Cím";
            // 
            // label_Phone_number
            // 
            this.label_Phone_number.AutoSize = true;
            this.label_Phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Phone_number.Location = new System.Drawing.Point(36, 254);
            this.label_Phone_number.Name = "label_Phone_number";
            this.label_Phone_number.Size = new System.Drawing.Size(105, 20);
            this.label_Phone_number.TabIndex = 6;
            this.label_Phone_number.Text = "Telefonszám";
            // 
            // label_Email_address
            // 
            this.label_Email_address.AutoSize = true;
            this.label_Email_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Email_address.Location = new System.Drawing.Point(36, 294);
            this.label_Email_address.Name = "label_Email_address";
            this.label_Email_address.Size = new System.Drawing.Size(83, 20);
            this.label_Email_address.TabIndex = 7;
            this.label_Email_address.Text = "Email cím";
            // 
            // label_RegCust_ID
            // 
            this.label_RegCust_ID.AutoSize = true;
            this.label_RegCust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_RegCust_ID.Location = new System.Drawing.Point(36, 49);
            this.label_RegCust_ID.Name = "label_RegCust_ID";
            this.label_RegCust_ID.Size = new System.Drawing.Size(141, 20);
            this.label_RegCust_ID.TabIndex = 8;
            this.label_RegCust_ID.Text = "Törzsvásrálói kód";
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(201, 92);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(240, 22);
            this.tB_name.TabIndex = 9;
            // 
            // tB_address
            // 
            this.tB_address.Location = new System.Drawing.Point(201, 212);
            this.tB_address.Name = "tB_address";
            this.tB_address.Size = new System.Drawing.Size(240, 22);
            this.tB_address.TabIndex = 12;
            // 
            // tB_phone
            // 
            this.tB_phone.Location = new System.Drawing.Point(201, 252);
            this.tB_phone.Name = "tB_phone";
            this.tB_phone.Size = new System.Drawing.Size(240, 22);
            this.tB_phone.TabIndex = 13;
            // 
            // tB_email
            // 
            this.tB_email.Location = new System.Drawing.Point(201, 292);
            this.tB_email.Name = "tB_email";
            this.tB_email.Size = new System.Drawing.Size(240, 22);
            this.tB_email.TabIndex = 14;
            // 
            // tB_ID
            // 
            this.tB_ID.Location = new System.Drawing.Point(201, 49);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.Size = new System.Drawing.Size(240, 22);
            this.tB_ID.TabIndex = 15;
            // 
            // cB_gender
            // 
            this.cB_gender.FormattingEnabled = true;
            this.cB_gender.Items.AddRange(new object[] {
            "Nő",
            "Férfi"});
            this.cB_gender.Location = new System.Drawing.Point(201, 172);
            this.cB_gender.Name = "cB_gender";
            this.cB_gender.Size = new System.Drawing.Size(240, 24);
            this.cB_gender.TabIndex = 16;
            // 
            // display_button
            // 
            this.display_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.display_button.Location = new System.Drawing.Point(485, 34);
            this.display_button.Name = "display_button";
            this.display_button.Size = new System.Drawing.Size(174, 50);
            this.display_button.TabIndex = 19;
            this.display_button.Text = "Megjelenítés";
            this.display_button.UseVisualStyleBackColor = true;
            this.display_button.Click += new System.EventHandler(this.regcus_display_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(485, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "Új törzsvásárló regisztrálása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.new_regcust_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(485, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 50);
            this.button2.TabIndex = 21;
            this.button2.Text = "Törzsvásárlói adatok módosítása";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.regcus_modification_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(485, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 50);
            this.button3.TabIndex = 22;
            this.button3.Text = "Törzsvásárló törlése";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.delete_regcus_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 349);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1458, 442);
            this.dataGridView.TabIndex = 23;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG_double_Click);
            // 
            // törzsvásárlókBindingSource
            // 
            this.törzsvásárlókBindingSource.DataMember = "Törzsvásárlók";
            this.törzsvásárlókBindingSource.DataSource = this.antiqueDBDataSet;
            // 
            // antiqueDBDataSet
            // 
            this.antiqueDBDataSet.DataSetName = "AntiqueDBDataSet";
            this.antiqueDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // törzsvásárlókTableAdapter
            // 
            this.törzsvásárlókTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // tB_born_date
            // 
            this.tB_born_date.Location = new System.Drawing.Point(201, 132);
            this.tB_born_date.Name = "tB_born_date";
            this.tB_born_date.Size = new System.Drawing.Size(240, 22);
            this.tB_born_date.TabIndex = 10;
            // 
            // RegularCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display_button);
            this.Controls.Add(this.cB_gender);
            this.Controls.Add(this.tB_ID);
            this.Controls.Add(this.tB_email);
            this.Controls.Add(this.tB_phone);
            this.Controls.Add(this.tB_address);
            this.Controls.Add(this.tB_born_date);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.label_RegCust_ID);
            this.Controls.Add(this.label_Email_address);
            this.Controls.Add(this.label_Phone_number);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_Born_date);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegularCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Törzsvásárlók";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.törzsvásárlókBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wishListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Born_date;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Phone_number;
        private System.Windows.Forms.Label label_Email_address;
        private System.Windows.Forms.Label label_RegCust_ID;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.TextBox tB_address;
        private System.Windows.Forms.TextBox tB_phone;
        private System.Windows.Forms.TextBox tB_email;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.ComboBox cB_gender;
        private System.Windows.Forms.Button display_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridView dataGridView;
        private AntiqueDBDataSet antiqueDBDataSet;
        private System.Windows.Forms.BindingSource törzsvásárlókBindingSource;
        private AntiqueDBDataSetTableAdapters.TörzsvásárlókTableAdapter törzsvásárlókTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_born_date;
    }
}