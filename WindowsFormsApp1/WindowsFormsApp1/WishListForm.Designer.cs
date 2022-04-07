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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_wishlist = new System.Windows.Forms.DataGridView();
            this.kívánságlistaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.antiqueDBDataSet = new WindowsFormsApp1.AntiqueDBDataSet();
            this.kívánságlistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_ISBN = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_regcust_ID = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.tB_ISBN = new System.Windows.Forms.TextBox();
            this.tB_author = new System.Windows.Forms.TextBox();
            this.tB_title = new System.Windows.Forms.TextBox();
            this.tB_regcust_ID = new System.Windows.Forms.TextBox();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.tB_address = new System.Windows.Forms.TextBox();
            this.tB_phone = new System.Windows.Forms.TextBox();
            this.tB_email = new System.Windows.Forms.TextBox();
            this.new_wish_add_button = new System.Windows.Forms.Button();
            this.wishlist_display_button = new System.Windows.Forms.Button();
            this.wish_delete_button = new System.Windows.Forms.Button();
            this.wish_modification_button = new System.Windows.Forms.Button();
            this.kívánságlistaTableAdapter = new WindowsFormsApp1.AntiqueDBDataSetTableAdapters.KívánságlistaTableAdapter();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.label_wish_ID = new System.Windows.Forms.Label();
            this.dataGridView_regcust = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wishlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kívánságlistaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kívánságlistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_regcust)).BeginInit();
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
            this.regularCustomerToolStripMenuItem,
            this.bookManagerToolStripMenuItem,
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
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.mainMenuToolStripMenuItem.Text = "Főmenü";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.saleToolStripMenuItem.Text = "Eladás";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // regularCustomerToolStripMenuItem
            // 
            this.regularCustomerToolStripMenuItem.Name = "regularCustomerToolStripMenuItem";
            this.regularCustomerToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.regularCustomerToolStripMenuItem.Text = "Törzsvásárlók";
            this.regularCustomerToolStripMenuItem.Click += new System.EventHandler(this.regularCustomerToolStripMenuItem_Click);
            // 
            // bookManagerToolStripMenuItem
            // 
            this.bookManagerToolStripMenuItem.Name = "bookManagerToolStripMenuItem";
            this.bookManagerToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.bookManagerToolStripMenuItem.Text = "Könyv kezelő";
            this.bookManagerToolStripMenuItem.Click += new System.EventHandler(this.bookManagerToolStripMenuItem_Click);
            // 
            // statementsToolStripMenuItem
            // 
            this.statementsToolStripMenuItem.Name = "statementsToolStripMenuItem";
            this.statementsToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.statementsToolStripMenuItem.Text = "Kimutatások";
            this.statementsToolStripMenuItem.Click += new System.EventHandler(this.statementsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
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
            // dataGridView_wishlist
            // 
            this.dataGridView_wishlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_wishlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_wishlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_wishlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_wishlist.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_wishlist.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_wishlist.GridColor = System.Drawing.Color.Black;
            this.dataGridView_wishlist.Location = new System.Drawing.Point(537, 28);
            this.dataGridView_wishlist.Name = "dataGridView_wishlist";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_wishlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_wishlist.RowHeadersWidth = 51;
            this.dataGridView_wishlist.RowTemplate.Height = 24;
            this.dataGridView_wishlist.Size = new System.Drawing.Size(933, 763);
            this.dataGridView_wishlist.TabIndex = 14;
            this.dataGridView_wishlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG_double_Click);
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
            this.label_ISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ISBN.Location = new System.Drawing.Point(12, 25);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(53, 23);
            this.label_ISBN.TabIndex = 16;
            this.label_ISBN.Text = "ISBN ";
            // 
            // label_author
            // 
            this.label_author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_author.Location = new System.Drawing.Point(12, 55);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(60, 23);
            this.label_author.TabIndex = 17;
            this.label_author.Text = "Szerző";
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.Location = new System.Drawing.Point(12, 85);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(42, 23);
            this.label_title.TabIndex = 18;
            this.label_title.Text = "Cím";
            // 
            // label_regcust_ID
            // 
            this.label_regcust_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_regcust_ID.AutoSize = true;
            this.label_regcust_ID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_regcust_ID.Location = new System.Drawing.Point(12, 115);
            this.label_regcust_ID.Name = "label_regcust_ID";
            this.label_regcust_ID.Size = new System.Drawing.Size(213, 23);
            this.label_regcust_ID.TabIndex = 19;
            this.label_regcust_ID.Text = "Törzsvásárlói kód (ha van)";
            // 
            // label_name
            // 
            this.label_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.Location = new System.Drawing.Point(12, 145);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(109, 23);
            this.label_name.TabIndex = 20;
            this.label_name.Text = "Vásárló neve";
            // 
            // label_address
            // 
            this.label_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_address.Location = new System.Drawing.Point(12, 175);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(110, 23);
            this.label_address.TabIndex = 21;
            this.label_address.Text = "Vásárló címe";
            // 
            // label_phone
            // 
            this.label_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_phone.Location = new System.Drawing.Point(12, 205);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(175, 23);
            this.label_phone.TabIndex = 22;
            this.label_phone.Text = "Vásárló telefonszáma";
            // 
            // label_email
            // 
            this.label_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_email.Location = new System.Drawing.Point(12, 235);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(156, 23);
            this.label_email.TabIndex = 23;
            this.label_email.Text = "Vásárló email címe";
            // 
            // tB_ISBN
            // 
            this.tB_ISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_ISBN.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_ISBN.ForeColor = System.Drawing.Color.Gray;
            this.tB_ISBN.Location = new System.Drawing.Point(260, 25);
            this.tB_ISBN.Name = "tB_ISBN";
            this.tB_ISBN.Size = new System.Drawing.Size(250, 25);
            this.tB_ISBN.TabIndex = 1;
            this.tB_ISBN.Text = "ISBN";
            this.tB_ISBN.Enter += new System.EventHandler(this.tB_ISBN_Enter);
            this.tB_ISBN.Leave += new System.EventHandler(this.tB_ISBN_Leave);
            // 
            // tB_author
            // 
            this.tB_author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_author.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_author.ForeColor = System.Drawing.Color.Gray;
            this.tB_author.Location = new System.Drawing.Point(260, 55);
            this.tB_author.Name = "tB_author";
            this.tB_author.Size = new System.Drawing.Size(250, 25);
            this.tB_author.TabIndex = 2;
            this.tB_author.Text = "Szerző";
            this.tB_author.Enter += new System.EventHandler(this.tB_author_Enter);
            this.tB_author.Leave += new System.EventHandler(this.tB_author_Leave);
            // 
            // tB_title
            // 
            this.tB_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_title.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_title.ForeColor = System.Drawing.Color.Gray;
            this.tB_title.Location = new System.Drawing.Point(260, 85);
            this.tB_title.Name = "tB_title";
            this.tB_title.Size = new System.Drawing.Size(250, 25);
            this.tB_title.TabIndex = 3;
            this.tB_title.Text = "Cím";
            this.tB_title.Enter += new System.EventHandler(this.tB_title_Enter);
            this.tB_title.Leave += new System.EventHandler(this.tB_title_Leave);
            // 
            // tB_regcust_ID
            // 
            this.tB_regcust_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_regcust_ID.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_regcust_ID.ForeColor = System.Drawing.Color.Gray;
            this.tB_regcust_ID.Location = new System.Drawing.Point(260, 115);
            this.tB_regcust_ID.Name = "tB_regcust_ID";
            this.tB_regcust_ID.Size = new System.Drawing.Size(250, 25);
            this.tB_regcust_ID.TabIndex = 4;
            this.tB_regcust_ID.Text = "Törzsvásárlói kód";
            this.tB_regcust_ID.Enter += new System.EventHandler(this.tB_regcust_ID_Enter);
            this.tB_regcust_ID.Leave += new System.EventHandler(this.tB_regcust_ID_Leave);
            // 
            // tB_name
            // 
            this.tB_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_name.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_name.ForeColor = System.Drawing.Color.Gray;
            this.tB_name.Location = new System.Drawing.Point(260, 145);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(250, 25);
            this.tB_name.TabIndex = 5;
            this.tB_name.Text = "Teljes név";
            this.tB_name.Enter += new System.EventHandler(this.tB_name_Enter);
            this.tB_name.Leave += new System.EventHandler(this.tB_name_Leave);
            // 
            // tB_address
            // 
            this.tB_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_address.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_address.ForeColor = System.Drawing.Color.Gray;
            this.tB_address.Location = new System.Drawing.Point(260, 175);
            this.tB_address.Name = "tB_address";
            this.tB_address.Size = new System.Drawing.Size(250, 25);
            this.tB_address.TabIndex = 6;
            this.tB_address.Text = "Lakcím";
            this.tB_address.Enter += new System.EventHandler(this.tB_address_Enter);
            this.tB_address.Leave += new System.EventHandler(this.tB_address_Leave);
            // 
            // tB_phone
            // 
            this.tB_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_phone.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_phone.ForeColor = System.Drawing.Color.Gray;
            this.tB_phone.Location = new System.Drawing.Point(260, 205);
            this.tB_phone.Name = "tB_phone";
            this.tB_phone.Size = new System.Drawing.Size(250, 25);
            this.tB_phone.TabIndex = 7;
            this.tB_phone.Text = "Telefonszám";
            this.tB_phone.Enter += new System.EventHandler(this.tB_phone_Enter);
            this.tB_phone.Leave += new System.EventHandler(this.tB_phone_Leave);
            // 
            // tB_email
            // 
            this.tB_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_email.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_email.ForeColor = System.Drawing.Color.Gray;
            this.tB_email.Location = new System.Drawing.Point(260, 235);
            this.tB_email.Name = "tB_email";
            this.tB_email.Size = new System.Drawing.Size(250, 25);
            this.tB_email.TabIndex = 8;
            this.tB_email.Text = "Email cím";
            this.tB_email.Enter += new System.EventHandler(this.tB_email_Enter);
            this.tB_email.Leave += new System.EventHandler(this.tB_email_Leave);
            // 
            // new_wish_add_button
            // 
            this.new_wish_add_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.new_wish_add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.new_wish_add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_wish_add_button.FlatAppearance.BorderSize = 0;
            this.new_wish_add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_wish_add_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_wish_add_button.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.new_wish_add_button.Location = new System.Drawing.Point(12, 280);
            this.new_wish_add_button.Name = "new_wish_add_button";
            this.new_wish_add_button.Size = new System.Drawing.Size(200, 60);
            this.new_wish_add_button.TabIndex = 9;
            this.new_wish_add_button.Text = "Új kivánság hozzáadása";
            this.new_wish_add_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.new_wish_add_button.UseVisualStyleBackColor = false;
            this.new_wish_add_button.Click += new System.EventHandler(this.new_wish_add_click);
            // 
            // wishlist_display_button
            // 
            this.wishlist_display_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wishlist_display_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.wishlist_display_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wishlist_display_button.FlatAppearance.BorderSize = 0;
            this.wishlist_display_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wishlist_display_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wishlist_display_button.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.wishlist_display_button.Location = new System.Drawing.Point(310, 280);
            this.wishlist_display_button.Name = "wishlist_display_button";
            this.wishlist_display_button.Size = new System.Drawing.Size(200, 60);
            this.wishlist_display_button.TabIndex = 10;
            this.wishlist_display_button.Text = "Kívánságok megjelenítés";
            this.wishlist_display_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.wishlist_display_button.UseVisualStyleBackColor = false;
            this.wishlist_display_button.Click += new System.EventHandler(this.wishlist_display_click);
            // 
            // wish_delete_button
            // 
            this.wish_delete_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wish_delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.wish_delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wish_delete_button.FlatAppearance.BorderSize = 0;
            this.wish_delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wish_delete_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wish_delete_button.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.wish_delete_button.Location = new System.Drawing.Point(310, 360);
            this.wish_delete_button.Name = "wish_delete_button";
            this.wish_delete_button.Size = new System.Drawing.Size(200, 60);
            this.wish_delete_button.TabIndex = 12;
            this.wish_delete_button.Text = "Kívánság törlése";
            this.wish_delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.wish_delete_button.UseVisualStyleBackColor = false;
            this.wish_delete_button.Click += new System.EventHandler(this.wish_delete_Click);
            // 
            // wish_modification_button
            // 
            this.wish_modification_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wish_modification_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.wish_modification_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wish_modification_button.FlatAppearance.BorderSize = 0;
            this.wish_modification_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wish_modification_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wish_modification_button.Image = global::WindowsFormsApp1.Properties.Resources.modification;
            this.wish_modification_button.Location = new System.Drawing.Point(12, 360);
            this.wish_modification_button.Name = "wish_modification_button";
            this.wish_modification_button.Size = new System.Drawing.Size(200, 60);
            this.wish_modification_button.TabIndex = 11;
            this.wish_modification_button.Text = "Kívánság módosítása";
            this.wish_modification_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.wish_modification_button.UseVisualStyleBackColor = false;
            this.wish_modification_button.Click += new System.EventHandler(this.wish_modification_Click);
            // 
            // kívánságlistaTableAdapter
            // 
            this.kívánságlistaTableAdapter.ClearBeforeFill = true;
            // 
            // tB_ID
            // 
            this.tB_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_ID.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_ID.ForeColor = System.Drawing.Color.Gray;
            this.tB_ID.Location = new System.Drawing.Point(260, 440);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.Size = new System.Drawing.Size(250, 25);
            this.tB_ID.TabIndex = 13;
            this.tB_ID.Text = "Kívánság ID";
            this.tB_ID.Enter += new System.EventHandler(this.tB_ID_Enter);
            this.tB_ID.Leave += new System.EventHandler(this.tB_ID_Leave);
            // 
            // label_wish_ID
            // 
            this.label_wish_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_wish_ID.AutoSize = true;
            this.label_wish_ID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wish_ID.Location = new System.Drawing.Point(12, 440);
            this.label_wish_ID.Name = "label_wish_ID";
            this.label_wish_ID.Size = new System.Drawing.Size(158, 23);
            this.label_wish_ID.TabIndex = 24;
            this.label_wish_ID.Text = "Kívánság azonosító";
            // 
            // dataGridView_regcust
            // 
            this.dataGridView_regcust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_regcust.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_regcust.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_regcust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_regcust.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_regcust.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_regcust.GridColor = System.Drawing.Color.Black;
            this.dataGridView_regcust.Location = new System.Drawing.Point(12, 480);
            this.dataGridView_regcust.Name = "dataGridView_regcust";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_regcust.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_regcust.RowHeadersWidth = 51;
            this.dataGridView_regcust.RowTemplate.Height = 24;
            this.dataGridView_regcust.Size = new System.Drawing.Size(498, 283);
            this.dataGridView_regcust.TabIndex = 15;
            this.dataGridView_regcust.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reg_cust_db_double_click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_regcust);
            this.panel1.Controls.Add(this.label_ISBN);
            this.panel1.Controls.Add(this.label_wish_ID);
            this.panel1.Controls.Add(this.label_author);
            this.panel1.Controls.Add(this.tB_ID);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Controls.Add(this.wish_modification_button);
            this.panel1.Controls.Add(this.label_regcust_ID);
            this.panel1.Controls.Add(this.wish_delete_button);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.wishlist_display_button);
            this.panel1.Controls.Add(this.label_address);
            this.panel1.Controls.Add(this.new_wish_add_button);
            this.panel1.Controls.Add(this.label_phone);
            this.panel1.Controls.Add(this.tB_email);
            this.panel1.Controls.Add(this.label_email);
            this.panel1.Controls.Add(this.tB_phone);
            this.panel1.Controls.Add(this.tB_ISBN);
            this.panel1.Controls.Add(this.tB_address);
            this.panel1.Controls.Add(this.tB_author);
            this.panel1.Controls.Add(this.tB_name);
            this.panel1.Controls.Add(this.tB_title);
            this.panel1.Controls.Add(this.tB_regcust_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 775);
            this.panel1.TabIndex = 25;
            // 
            // WishListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_wishlist);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WishListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kívánság lista";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_Close_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wishlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kívánságlistaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kívánságlistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_regcust)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem regularCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_wishlist;
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_regcust_ID;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox tB_ISBN;
        private System.Windows.Forms.TextBox tB_author;
        private System.Windows.Forms.TextBox tB_title;
        private System.Windows.Forms.TextBox tB_regcust_ID;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.TextBox tB_address;
        private System.Windows.Forms.TextBox tB_phone;
        private System.Windows.Forms.TextBox tB_email;
        private System.Windows.Forms.Button new_wish_add_button;
        private System.Windows.Forms.Button wishlist_display_button;
        private System.Windows.Forms.Button wish_delete_button;
        private System.Windows.Forms.Button wish_modification_button;
        private AntiqueDBDataSet antiqueDBDataSet;
        private System.Windows.Forms.BindingSource kívánságlistaBindingSource;
        private AntiqueDBDataSetTableAdapters.KívánságlistaTableAdapter kívánságlistaTableAdapter;
        private System.Windows.Forms.BindingSource kívánságlistaBindingSource1;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.Label label_wish_ID;
        private System.Windows.Forms.DataGridView dataGridView_regcust;
        private System.Windows.Forms.Panel panel1;
    }
}