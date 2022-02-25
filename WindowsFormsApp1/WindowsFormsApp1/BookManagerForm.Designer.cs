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
            this.button_display = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.button_modification = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.antiqueDBDataSet = new WindowsFormsApp1.AntiqueDBDataSet();
            this.könyvekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.könyvekTableAdapter = new WindowsFormsApp1.AntiqueDBDataSetTableAdapters.KönyvekTableAdapter();
            this.könyvidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szerzőDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.címDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiadásÉveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.műfajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiadóDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.állapotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kötésDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldalszámDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beszerzésiÁrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eladásiÁrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.könyvekBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
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
            // regularCustomerToolStripMenuItem
            // 
            this.regularCustomerToolStripMenuItem.Name = "regularCustomerToolStripMenuItem";
            this.regularCustomerToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.regularCustomerToolStripMenuItem.Text = "Törzsvásárlók";
            this.regularCustomerToolStripMenuItem.Click += new System.EventHandler(this.regularCustomerToolStripMenuItem_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.könyvidDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.szerzőDataGridViewTextBoxColumn,
            this.címDataGridViewTextBoxColumn,
            this.kiadásÉveDataGridViewTextBoxColumn,
            this.műfajDataGridViewTextBoxColumn,
            this.kiadóDataGridViewTextBoxColumn,
            this.állapotDataGridViewTextBoxColumn,
            this.kötésDataGridViewTextBoxColumn,
            this.oldalszámDataGridViewTextBoxColumn,
            this.beszerzésiÁrDataGridViewTextBoxColumn,
            this.eladásiÁrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.könyvekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 281);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(50, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Műfaj";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(50, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Oldalszám";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(50, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Beszerzési ár";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(50, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Eladási ár";
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ISBN.Location = new System.Drawing.Point(346, 38);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(240, 22);
            this.textBox_ISBN.TabIndex = 10;
            // 
            // textBox_author
            // 
            this.textBox_author.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_author.Location = new System.Drawing.Point(346, 68);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(240, 22);
            this.textBox_author.TabIndex = 11;
            // 
            // textBox_title
            // 
            this.textBox_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_title.Location = new System.Drawing.Point(346, 98);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(240, 22);
            this.textBox_title.TabIndex = 12;
            // 
            // textBox_year
            // 
            this.textBox_year.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_year.Location = new System.Drawing.Point(346, 128);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(240, 22);
            this.textBox_year.TabIndex = 13;
            // 
            // textBox_genre
            // 
            this.textBox_genre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_genre.Location = new System.Drawing.Point(346, 156);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.Size = new System.Drawing.Size(240, 22);
            this.textBox_genre.TabIndex = 14;
            // 
            // textBox_pagenumber
            // 
            this.textBox_pagenumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_pagenumber.Location = new System.Drawing.Point(346, 268);
            this.textBox_pagenumber.Name = "textBox_pagenumber";
            this.textBox_pagenumber.Size = new System.Drawing.Size(240, 22);
            this.textBox_pagenumber.TabIndex = 15;
            // 
            // textBox_purchase_price
            // 
            this.textBox_purchase_price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_purchase_price.Location = new System.Drawing.Point(346, 298);
            this.textBox_purchase_price.Name = "textBox_purchase_price";
            this.textBox_purchase_price.Size = new System.Drawing.Size(240, 22);
            this.textBox_purchase_price.TabIndex = 16;
            // 
            // textBox_selling_price
            // 
            this.textBox_selling_price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_selling_price.Location = new System.Drawing.Point(346, 328);
            this.textBox_selling_price.Name = "textBox_selling_price";
            this.textBox_selling_price.Size = new System.Drawing.Size(240, 22);
            this.textBox_selling_price.TabIndex = 17;
            // 
            // button_display
            // 
            this.button_display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_display.AutoSize = true;
            this.button_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_display.Location = new System.Drawing.Point(726, 40);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(210, 50);
            this.button_display.TabIndex = 18;
            this.button_display.Text = "Megjelenítés";
            this.button_display.UseVisualStyleBackColor = true;
            // 
            // button_new
            // 
            this.button_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_new.Location = new System.Drawing.Point(726, 100);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(210, 50);
            this.button_new.TabIndex = 19;
            this.button_new.Text = "Új könyv hozzáadása";
            this.button_new.UseVisualStyleBackColor = true;
            // 
            // button_modification
            // 
            this.button_modification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_modification.AutoSize = true;
            this.button_modification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_modification.Location = new System.Drawing.Point(726, 160);
            this.button_modification.Name = "button_modification";
            this.button_modification.Size = new System.Drawing.Size(210, 50);
            this.button_modification.TabIndex = 20;
            this.button_modification.Text = "Könyv módosítása";
            this.button_modification.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete.AutoSize = true;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete.Location = new System.Drawing.Point(726, 220);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(210, 50);
            this.button_delete.TabIndex = 21;
            this.button_delete.Text = "Könyv törlése";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(50, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kiadás éve";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(346, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(50, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kiadó";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(346, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 22);
            this.textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(346, 240);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 22);
            this.textBox3.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(50, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Kötés";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(50, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Állapot";
            // 
            // antiqueDBDataSet
            // 
            this.antiqueDBDataSet.DataSetName = "AntiqueDBDataSet";
            this.antiqueDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // könyvekBindingSource
            // 
            this.könyvekBindingSource.DataMember = "Könyvek";
            this.könyvekBindingSource.DataSource = this.antiqueDBDataSet;
            // 
            // könyvekTableAdapter
            // 
            this.könyvekTableAdapter.ClearBeforeFill = true;
            // 
            // könyvidDataGridViewTextBoxColumn
            // 
            this.könyvidDataGridViewTextBoxColumn.DataPropertyName = "Könyv_id";
            this.könyvidDataGridViewTextBoxColumn.HeaderText = "Könyv_id";
            this.könyvidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.könyvidDataGridViewTextBoxColumn.Name = "könyvidDataGridViewTextBoxColumn";
            this.könyvidDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // szerzőDataGridViewTextBoxColumn
            // 
            this.szerzőDataGridViewTextBoxColumn.DataPropertyName = "Szerző";
            this.szerzőDataGridViewTextBoxColumn.HeaderText = "Szerző";
            this.szerzőDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.szerzőDataGridViewTextBoxColumn.Name = "szerzőDataGridViewTextBoxColumn";
            this.szerzőDataGridViewTextBoxColumn.Width = 125;
            // 
            // címDataGridViewTextBoxColumn
            // 
            this.címDataGridViewTextBoxColumn.DataPropertyName = "Cím";
            this.címDataGridViewTextBoxColumn.HeaderText = "Cím";
            this.címDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.címDataGridViewTextBoxColumn.Name = "címDataGridViewTextBoxColumn";
            this.címDataGridViewTextBoxColumn.Width = 125;
            // 
            // kiadásÉveDataGridViewTextBoxColumn
            // 
            this.kiadásÉveDataGridViewTextBoxColumn.DataPropertyName = "Kiadás éve";
            this.kiadásÉveDataGridViewTextBoxColumn.HeaderText = "Kiadás éve";
            this.kiadásÉveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kiadásÉveDataGridViewTextBoxColumn.Name = "kiadásÉveDataGridViewTextBoxColumn";
            this.kiadásÉveDataGridViewTextBoxColumn.Width = 125;
            // 
            // műfajDataGridViewTextBoxColumn
            // 
            this.műfajDataGridViewTextBoxColumn.DataPropertyName = "Műfaj";
            this.műfajDataGridViewTextBoxColumn.HeaderText = "Műfaj";
            this.műfajDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.műfajDataGridViewTextBoxColumn.Name = "műfajDataGridViewTextBoxColumn";
            this.műfajDataGridViewTextBoxColumn.Width = 125;
            // 
            // kiadóDataGridViewTextBoxColumn
            // 
            this.kiadóDataGridViewTextBoxColumn.DataPropertyName = "Kiadó";
            this.kiadóDataGridViewTextBoxColumn.HeaderText = "Kiadó";
            this.kiadóDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kiadóDataGridViewTextBoxColumn.Name = "kiadóDataGridViewTextBoxColumn";
            this.kiadóDataGridViewTextBoxColumn.Width = 125;
            // 
            // állapotDataGridViewTextBoxColumn
            // 
            this.állapotDataGridViewTextBoxColumn.DataPropertyName = "Állapot";
            this.állapotDataGridViewTextBoxColumn.HeaderText = "Állapot";
            this.állapotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.állapotDataGridViewTextBoxColumn.Name = "állapotDataGridViewTextBoxColumn";
            this.állapotDataGridViewTextBoxColumn.Width = 125;
            // 
            // kötésDataGridViewTextBoxColumn
            // 
            this.kötésDataGridViewTextBoxColumn.DataPropertyName = "Kötés";
            this.kötésDataGridViewTextBoxColumn.HeaderText = "Kötés";
            this.kötésDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kötésDataGridViewTextBoxColumn.Name = "kötésDataGridViewTextBoxColumn";
            this.kötésDataGridViewTextBoxColumn.Width = 125;
            // 
            // oldalszámDataGridViewTextBoxColumn
            // 
            this.oldalszámDataGridViewTextBoxColumn.DataPropertyName = "Oldalszám";
            this.oldalszámDataGridViewTextBoxColumn.HeaderText = "Oldalszám";
            this.oldalszámDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oldalszámDataGridViewTextBoxColumn.Name = "oldalszámDataGridViewTextBoxColumn";
            this.oldalszámDataGridViewTextBoxColumn.Width = 125;
            // 
            // beszerzésiÁrDataGridViewTextBoxColumn
            // 
            this.beszerzésiÁrDataGridViewTextBoxColumn.DataPropertyName = "Beszerzési ár";
            this.beszerzésiÁrDataGridViewTextBoxColumn.HeaderText = "Beszerzési ár";
            this.beszerzésiÁrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.beszerzésiÁrDataGridViewTextBoxColumn.Name = "beszerzésiÁrDataGridViewTextBoxColumn";
            this.beszerzésiÁrDataGridViewTextBoxColumn.Width = 125;
            // 
            // eladásiÁrDataGridViewTextBoxColumn
            // 
            this.eladásiÁrDataGridViewTextBoxColumn.DataPropertyName = "Eladási ár";
            this.eladásiÁrDataGridViewTextBoxColumn.HeaderText = "Eladási ár";
            this.eladásiÁrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eladásiÁrDataGridViewTextBoxColumn.Name = "eladásiÁrDataGridViewTextBoxColumn";
            this.eladásiÁrDataGridViewTextBoxColumn.Width = 125;
            // 
            // BookManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1006, 653);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_modification);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_display);
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
            this.Load += new System.EventHandler(this.BookManagerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.könyvekBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button_display;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_modification;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private AntiqueDBDataSet antiqueDBDataSet;
        private System.Windows.Forms.BindingSource könyvekBindingSource;
        private AntiqueDBDataSetTableAdapters.KönyvekTableAdapter könyvekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn könyvidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szerzőDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn címDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiadásÉveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn műfajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiadóDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn állapotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kötésDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldalszámDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beszerzésiÁrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eladásiÁrDataGridViewTextBoxColumn;
    }
}