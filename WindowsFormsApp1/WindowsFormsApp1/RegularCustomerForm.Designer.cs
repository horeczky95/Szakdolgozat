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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tB_regcust_ID = new System.Windows.Forms.TextBox();
            this.cB_gender = new System.Windows.Forms.ComboBox();
            this.display_button = new System.Windows.Forms.Button();
            this.new_regcust_add_button = new System.Windows.Forms.Button();
            this.regcust_modification_button = new System.Windows.Forms.Button();
            this.regcust_delete_button = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.törzsvásárlókBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.antiqueDBDataSet = new WindowsFormsApp1.AntiqueDBDataSet();
            this.törzsvásárlókTableAdapter = new WindowsFormsApp1.AntiqueDBDataSetTableAdapters.TörzsvásárlókTableAdapter();
            this.dtP_born_date = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.törzsvásárlókBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.bookManagerToolStripMenuItem,
            this.wishListToolStripMenuItem,
            this.statementsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "Fájl";
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.helpToolStripMenuItem.Text = "Súgó";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Name.Location = new System.Drawing.Point(12, 197);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(41, 23);
            this.label_Name.TabIndex = 15;
            this.label_Name.Text = "Név";
            // 
            // label_Born_date
            // 
            this.label_Born_date.AutoSize = true;
            this.label_Born_date.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Born_date.Location = new System.Drawing.Point(12, 239);
            this.label_Born_date.Name = "label_Born_date";
            this.label_Born_date.Size = new System.Drawing.Size(132, 23);
            this.label_Born_date.TabIndex = 16;
            this.label_Born_date.Text = "Születési dátum";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Gender.Location = new System.Drawing.Point(12, 281);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(47, 23);
            this.label_Gender.TabIndex = 17;
            this.label_Gender.Text = "Nem";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Address.Location = new System.Drawing.Point(12, 323);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(42, 23);
            this.label_Address.TabIndex = 18;
            this.label_Address.Text = "Cím";
            // 
            // label_Phone_number
            // 
            this.label_Phone_number.AutoSize = true;
            this.label_Phone_number.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Phone_number.Location = new System.Drawing.Point(12, 365);
            this.label_Phone_number.Name = "label_Phone_number";
            this.label_Phone_number.Size = new System.Drawing.Size(106, 23);
            this.label_Phone_number.TabIndex = 19;
            this.label_Phone_number.Text = "Telefonszám";
            // 
            // label_Email_address
            // 
            this.label_Email_address.AutoSize = true;
            this.label_Email_address.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Email_address.Location = new System.Drawing.Point(12, 407);
            this.label_Email_address.Name = "label_Email_address";
            this.label_Email_address.Size = new System.Drawing.Size(86, 23);
            this.label_Email_address.TabIndex = 20;
            this.label_Email_address.Text = "Email cím";
            // 
            // label_RegCust_ID
            // 
            this.label_RegCust_ID.AutoSize = true;
            this.label_RegCust_ID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_RegCust_ID.Location = new System.Drawing.Point(12, 70);
            this.label_RegCust_ID.Name = "label_RegCust_ID";
            this.label_RegCust_ID.Size = new System.Drawing.Size(146, 23);
            this.label_RegCust_ID.TabIndex = 14;
            this.label_RegCust_ID.Text = "Törzsvásrálói kód";
            // 
            // tB_name
            // 
            this.tB_name.BackColor = System.Drawing.SystemColors.Window;
            this.tB_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_name.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_name.ForeColor = System.Drawing.Color.Gray;
            this.tB_name.Location = new System.Drawing.Point(180, 197);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(240, 25);
            this.tB_name.TabIndex = 2;
            this.tB_name.Text = "Teljes név";
            this.tB_name.Enter += new System.EventHandler(this.tB_name_Enter);
            this.tB_name.Leave += new System.EventHandler(this.tB_name_Leave);
            // 
            // tB_address
            // 
            this.tB_address.BackColor = System.Drawing.SystemColors.Window;
            this.tB_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_address.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_address.ForeColor = System.Drawing.Color.Gray;
            this.tB_address.Location = new System.Drawing.Point(180, 323);
            this.tB_address.Name = "tB_address";
            this.tB_address.Size = new System.Drawing.Size(240, 25);
            this.tB_address.TabIndex = 5;
            this.tB_address.Text = "Lakcím";
            this.tB_address.Enter += new System.EventHandler(this.tB_address_Enter);
            this.tB_address.Leave += new System.EventHandler(this.tB_address_Leave);
            // 
            // tB_phone
            // 
            this.tB_phone.BackColor = System.Drawing.SystemColors.Window;
            this.tB_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_phone.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_phone.ForeColor = System.Drawing.Color.Gray;
            this.tB_phone.Location = new System.Drawing.Point(180, 365);
            this.tB_phone.Name = "tB_phone";
            this.tB_phone.Size = new System.Drawing.Size(240, 25);
            this.tB_phone.TabIndex = 6;
            this.tB_phone.Text = "Telefonszám";
            this.tB_phone.Enter += new System.EventHandler(this.tB_phone_Enter);
            this.tB_phone.Leave += new System.EventHandler(this.tB_phone_Leave);
            // 
            // tB_email
            // 
            this.tB_email.BackColor = System.Drawing.SystemColors.Window;
            this.tB_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_email.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_email.ForeColor = System.Drawing.Color.Gray;
            this.tB_email.Location = new System.Drawing.Point(180, 407);
            this.tB_email.Name = "tB_email";
            this.tB_email.Size = new System.Drawing.Size(240, 25);
            this.tB_email.TabIndex = 7;
            this.tB_email.Text = "Email cím";
            this.tB_email.Enter += new System.EventHandler(this.tB_email_Enter);
            this.tB_email.Leave += new System.EventHandler(this.tB_email_Leave);
            // 
            // tB_regcust_ID
            // 
            this.tB_regcust_ID.BackColor = System.Drawing.SystemColors.Window;
            this.tB_regcust_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_regcust_ID.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_regcust_ID.ForeColor = System.Drawing.Color.Gray;
            this.tB_regcust_ID.Location = new System.Drawing.Point(180, 70);
            this.tB_regcust_ID.Name = "tB_regcust_ID";
            this.tB_regcust_ID.Size = new System.Drawing.Size(240, 25);
            this.tB_regcust_ID.TabIndex = 1;
            this.tB_regcust_ID.Text = "Törzsvásárlói kód";
            this.tB_regcust_ID.Enter += new System.EventHandler(this.tB_regcust_ID_Enter);
            this.tB_regcust_ID.Leave += new System.EventHandler(this.tB_regcust_ID_Leave);
            // 
            // cB_gender
            // 
            this.cB_gender.BackColor = System.Drawing.SystemColors.Window;
            this.cB_gender.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cB_gender.ForeColor = System.Drawing.Color.Gray;
            this.cB_gender.FormattingEnabled = true;
            this.cB_gender.Items.AddRange(new object[] {
            "Nő",
            "Férfi"});
            this.cB_gender.Location = new System.Drawing.Point(180, 281);
            this.cB_gender.Name = "cB_gender";
            this.cB_gender.Size = new System.Drawing.Size(240, 26);
            this.cB_gender.TabIndex = 4;
            this.cB_gender.Text = "Nem";
            this.cB_gender.Enter += new System.EventHandler(this.cB_gender_Enter);
            this.cB_gender.Leave += new System.EventHandler(this.cB_gender_Leave);
            // 
            // display_button
            // 
            this.display_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.display_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.display_button.FlatAppearance.BorderSize = 0;
            this.display_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display_button.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.display_button.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.display_button.Location = new System.Drawing.Point(88, 121);
            this.display_button.Name = "display_button";
            this.display_button.Size = new System.Drawing.Size(260, 50);
            this.display_button.TabIndex = 8;
            this.display_button.Text = "Megjelenítés";
            this.display_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.display_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.display_button.UseVisualStyleBackColor = false;
            this.display_button.Click += new System.EventHandler(this.regcus_display_Click);
            // 
            // new_regcust_add_button
            // 
            this.new_regcust_add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.new_regcust_add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_regcust_add_button.FlatAppearance.BorderSize = 0;
            this.new_regcust_add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_regcust_add_button.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_regcust_add_button.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.new_regcust_add_button.Location = new System.Drawing.Point(88, 464);
            this.new_regcust_add_button.Name = "new_regcust_add_button";
            this.new_regcust_add_button.Size = new System.Drawing.Size(260, 50);
            this.new_regcust_add_button.TabIndex = 9;
            this.new_regcust_add_button.Text = "Új törzsvásárló regisztrálása";
            this.new_regcust_add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.new_regcust_add_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.new_regcust_add_button.UseVisualStyleBackColor = false;
            this.new_regcust_add_button.Click += new System.EventHandler(this.new_regcust_Click);
            // 
            // regcust_modification_button
            // 
            this.regcust_modification_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.regcust_modification_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regcust_modification_button.FlatAppearance.BorderSize = 0;
            this.regcust_modification_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regcust_modification_button.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regcust_modification_button.Image = global::WindowsFormsApp1.Properties.Resources.modification;
            this.regcust_modification_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regcust_modification_button.Location = new System.Drawing.Point(88, 549);
            this.regcust_modification_button.Name = "regcust_modification_button";
            this.regcust_modification_button.Size = new System.Drawing.Size(260, 50);
            this.regcust_modification_button.TabIndex = 10;
            this.regcust_modification_button.Text = "Törzsvásárlói adatok módosítása";
            this.regcust_modification_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.regcust_modification_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.regcust_modification_button.UseVisualStyleBackColor = false;
            this.regcust_modification_button.Click += new System.EventHandler(this.regcus_modification_Click);
            // 
            // regcust_delete_button
            // 
            this.regcust_delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.regcust_delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regcust_delete_button.FlatAppearance.BorderSize = 0;
            this.regcust_delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regcust_delete_button.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regcust_delete_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.regcust_delete_button.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.regcust_delete_button.Location = new System.Drawing.Point(88, 634);
            this.regcust_delete_button.Name = "regcust_delete_button";
            this.regcust_delete_button.Size = new System.Drawing.Size(260, 50);
            this.regcust_delete_button.TabIndex = 11;
            this.regcust_delete_button.Text = "Törzsvásárló törlése";
            this.regcust_delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.regcust_delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.regcust_delete_button.UseVisualStyleBackColor = false;
            this.regcust_delete_button.Click += new System.EventHandler(this.delete_regcus_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(472, 28);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(998, 763);
            this.dataGridView.TabIndex = 12;
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
            // dtP_born_date
            // 
            this.dtP_born_date.Location = new System.Drawing.Point(180, 239);
            this.dtP_born_date.Name = "dtP_born_date";
            this.dtP_born_date.Size = new System.Drawing.Size(240, 22);
            this.dtP_born_date.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_RegCust_ID);
            this.panel1.Controls.Add(this.dtP_born_date);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.label_Born_date);
            this.panel1.Controls.Add(this.regcust_delete_button);
            this.panel1.Controls.Add(this.label_Gender);
            this.panel1.Controls.Add(this.regcust_modification_button);
            this.panel1.Controls.Add(this.label_Address);
            this.panel1.Controls.Add(this.new_regcust_add_button);
            this.panel1.Controls.Add(this.label_Phone_number);
            this.panel1.Controls.Add(this.display_button);
            this.panel1.Controls.Add(this.label_Email_address);
            this.panel1.Controls.Add(this.cB_gender);
            this.panel1.Controls.Add(this.tB_name);
            this.panel1.Controls.Add(this.tB_regcust_ID);
            this.panel1.Controls.Add(this.tB_email);
            this.panel1.Controls.Add(this.tB_address);
            this.panel1.Controls.Add(this.tB_phone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 775);
            this.panel1.TabIndex = 13;
            // 
            // RegularCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegularCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Törzsvásárlók";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_Close_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.törzsvásárlókBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wishListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
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
        private System.Windows.Forms.TextBox tB_regcust_ID;
        private System.Windows.Forms.ComboBox cB_gender;
        private System.Windows.Forms.Button display_button;
        private System.Windows.Forms.Button new_regcust_add_button;
        private System.Windows.Forms.Button regcust_modification_button;
        private System.Windows.Forms.Button regcust_delete_button;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridView dataGridView;
        private AntiqueDBDataSet antiqueDBDataSet;
        private System.Windows.Forms.BindingSource törzsvásárlókBindingSource;
        private AntiqueDBDataSetTableAdapters.TörzsvásárlókTableAdapter törzsvásárlókTableAdapter;
        private System.Windows.Forms.DateTimePicker dtP_born_date;
        private System.Windows.Forms.Panel panel1;
    }
}