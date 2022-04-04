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
            this.könyvekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.antiqueDBDataSet = new WindowsFormsApp1.AntiqueDBDataSet();
            this.antiqueDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_ISBN = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Genre = new System.Windows.Forms.Label();
            this.label_Pagenumber = new System.Windows.Forms.Label();
            this.label_Purchase_price = new System.Windows.Forms.Label();
            this.tB_ISBN = new System.Windows.Forms.TextBox();
            this.tB_author = new System.Windows.Forms.TextBox();
            this.tB_title = new System.Windows.Forms.TextBox();
            this.tB_year = new System.Windows.Forms.TextBox();
            this.tB_genre = new System.Windows.Forms.TextBox();
            this.tB_pagenumber = new System.Windows.Forms.TextBox();
            this.tB_purchase_price = new System.Windows.Forms.TextBox();
            this.button_display = new System.Windows.Forms.Button();
            this.button_new_book = new System.Windows.Forms.Button();
            this.button_book_modification = new System.Windows.Forms.Button();
            this.button_book_delete = new System.Windows.Forms.Button();
            this.label_Year = new System.Windows.Forms.Label();
            this.tB_publisher = new System.Windows.Forms.TextBox();
            this.label_Publisher = new System.Windows.Forms.Label();
            this.tB_condition = new System.Windows.Forms.TextBox();
            this.tB_binding = new System.Windows.Forms.TextBox();
            this.label_Binding = new System.Windows.Forms.Label();
            this.label_Condition = new System.Windows.Forms.Label();
            this.könyvekTableAdapter = new WindowsFormsApp1.AntiqueDBDataSetTableAdapters.KönyvekTableAdapter();
            this.könyvekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.label_BookID = new System.Windows.Forms.Label();
            this.label_Selling_price = new System.Windows.Forms.Label();
            this.tB_selling_price = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.könyvekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.könyvekBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.dataGridView1.Location = new System.Drawing.Point(463, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 751);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG_double_Click);
            // 
            // könyvekBindingSource
            // 
            this.könyvekBindingSource.DataMember = "Könyvek";
            this.könyvekBindingSource.DataSource = this.antiqueDBDataSet;
            // 
            // antiqueDBDataSet
            // 
            this.antiqueDBDataSet.DataSetName = "AntiqueDBDataSet";
            this.antiqueDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_ISBN
            // 
            this.label_ISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ISBN.Location = new System.Drawing.Point(12, 50);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(94, 20);
            this.label_ISBN.TabIndex = 16;
            this.label_ISBN.Text = "ISBN szám";
            // 
            // label_Author
            // 
            this.label_Author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Author.AutoSize = true;
            this.label_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Author.Location = new System.Drawing.Point(12, 82);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(62, 20);
            this.label_Author.TabIndex = 17;
            this.label_Author.Text = "Szerző";
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Title.Location = new System.Drawing.Point(12, 114);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(39, 20);
            this.label_Title.TabIndex = 18;
            this.label_Title.Text = "Cím";
            // 
            // label_Genre
            // 
            this.label_Genre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Genre.AutoSize = true;
            this.label_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Genre.Location = new System.Drawing.Point(12, 178);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(50, 20);
            this.label_Genre.TabIndex = 20;
            this.label_Genre.Text = "Műfaj";
            // 
            // label_Pagenumber
            // 
            this.label_Pagenumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Pagenumber.AutoSize = true;
            this.label_Pagenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Pagenumber.Location = new System.Drawing.Point(12, 306);
            this.label_Pagenumber.Name = "label_Pagenumber";
            this.label_Pagenumber.Size = new System.Drawing.Size(89, 20);
            this.label_Pagenumber.TabIndex = 24;
            this.label_Pagenumber.Text = "Oldalszám";
            // 
            // label_Purchase_price
            // 
            this.label_Purchase_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Purchase_price.AutoSize = true;
            this.label_Purchase_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Purchase_price.Location = new System.Drawing.Point(12, 338);
            this.label_Purchase_price.Name = "label_Purchase_price";
            this.label_Purchase_price.Size = new System.Drawing.Size(114, 20);
            this.label_Purchase_price.TabIndex = 25;
            this.label_Purchase_price.Text = "Beszerzési ár";
            // 
            // tB_ISBN
            // 
            this.tB_ISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_ISBN.BackColor = System.Drawing.SystemColors.Window;
            this.tB_ISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_ISBN.Location = new System.Drawing.Point(164, 50);
            this.tB_ISBN.Name = "tB_ISBN";
            this.tB_ISBN.Size = new System.Drawing.Size(251, 22);
            this.tB_ISBN.TabIndex = 1;
            // 
            // tB_author
            // 
            this.tB_author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_author.BackColor = System.Drawing.SystemColors.Window;
            this.tB_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_author.Location = new System.Drawing.Point(164, 82);
            this.tB_author.Name = "tB_author";
            this.tB_author.Size = new System.Drawing.Size(251, 22);
            this.tB_author.TabIndex = 2;
            // 
            // tB_title
            // 
            this.tB_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_title.BackColor = System.Drawing.SystemColors.Window;
            this.tB_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_title.Location = new System.Drawing.Point(164, 114);
            this.tB_title.Name = "tB_title";
            this.tB_title.Size = new System.Drawing.Size(251, 22);
            this.tB_title.TabIndex = 3;
            // 
            // tB_year
            // 
            this.tB_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_year.BackColor = System.Drawing.SystemColors.Window;
            this.tB_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_year.Location = new System.Drawing.Point(164, 146);
            this.tB_year.Name = "tB_year";
            this.tB_year.Size = new System.Drawing.Size(251, 22);
            this.tB_year.TabIndex = 4;
            // 
            // tB_genre
            // 
            this.tB_genre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_genre.BackColor = System.Drawing.SystemColors.Window;
            this.tB_genre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_genre.Location = new System.Drawing.Point(164, 178);
            this.tB_genre.Name = "tB_genre";
            this.tB_genre.Size = new System.Drawing.Size(251, 22);
            this.tB_genre.TabIndex = 5;
            // 
            // tB_pagenumber
            // 
            this.tB_pagenumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_pagenumber.BackColor = System.Drawing.SystemColors.Window;
            this.tB_pagenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_pagenumber.Location = new System.Drawing.Point(164, 306);
            this.tB_pagenumber.Name = "tB_pagenumber";
            this.tB_pagenumber.Size = new System.Drawing.Size(251, 22);
            this.tB_pagenumber.TabIndex = 9;
            // 
            // tB_purchase_price
            // 
            this.tB_purchase_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_purchase_price.BackColor = System.Drawing.SystemColors.Window;
            this.tB_purchase_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_purchase_price.Location = new System.Drawing.Point(164, 338);
            this.tB_purchase_price.Name = "tB_purchase_price";
            this.tB_purchase_price.Size = new System.Drawing.Size(251, 22);
            this.tB_purchase_price.TabIndex = 10;
            // 
            // button_display
            // 
            this.button_display.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_display.AutoSize = true;
            this.button_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.button_display.FlatAppearance.BorderSize = 0;
            this.button_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_display.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.button_display.Location = new System.Drawing.Point(93, 539);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(240, 50);
            this.button_display.TabIndex = 12;
            this.button_display.Text = "Könyv keresés";
            this.button_display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_display.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_display.UseVisualStyleBackColor = false;
            this.button_display.Click += new System.EventHandler(this.books_display_Click);
            // 
            // button_new_book
            // 
            this.button_new_book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_new_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.button_new_book.FlatAppearance.BorderSize = 0;
            this.button_new_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_new_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_new_book.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.button_new_book.Location = new System.Drawing.Point(93, 417);
            this.button_new_book.Name = "button_new_book";
            this.button_new_book.Size = new System.Drawing.Size(240, 50);
            this.button_new_book.TabIndex = 13;
            this.button_new_book.Text = "Új könyv hozzáadása";
            this.button_new_book.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_new_book.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_new_book.UseVisualStyleBackColor = false;
            this.button_new_book.Click += new System.EventHandler(this.button_new_book_Click);
            // 
            // button_book_modification
            // 
            this.button_book_modification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_book_modification.AutoSize = true;
            this.button_book_modification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.button_book_modification.FlatAppearance.BorderSize = 0;
            this.button_book_modification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_book_modification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_book_modification.Image = global::WindowsFormsApp1.Properties.Resources.modification;
            this.button_book_modification.Location = new System.Drawing.Point(93, 689);
            this.button_book_modification.Name = "button_book_modification";
            this.button_book_modification.Size = new System.Drawing.Size(240, 50);
            this.button_book_modification.TabIndex = 14;
            this.button_book_modification.Text = "Könyv módosítása";
            this.button_book_modification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_book_modification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_book_modification.UseVisualStyleBackColor = false;
            this.button_book_modification.Click += new System.EventHandler(this.button_book_modification_Click);
            // 
            // button_book_delete
            // 
            this.button_book_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_book_delete.AutoSize = true;
            this.button_book_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.button_book_delete.FlatAppearance.BorderSize = 0;
            this.button_book_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_book_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_book_delete.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.button_book_delete.Location = new System.Drawing.Point(93, 614);
            this.button_book_delete.Name = "button_book_delete";
            this.button_book_delete.Size = new System.Drawing.Size(240, 50);
            this.button_book_delete.TabIndex = 15;
            this.button_book_delete.Text = "Könyv törlése";
            this.button_book_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_book_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_book_delete.UseVisualStyleBackColor = false;
            this.button_book_delete.Click += new System.EventHandler(this.button_book_delete_Click);
            // 
            // label_Year
            // 
            this.label_Year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Year.AutoSize = true;
            this.label_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Year.Location = new System.Drawing.Point(12, 146);
            this.label_Year.Name = "label_Year";
            this.label_Year.Size = new System.Drawing.Size(91, 20);
            this.label_Year.TabIndex = 19;
            this.label_Year.Text = "Kiadás éve";
            // 
            // tB_publisher
            // 
            this.tB_publisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_publisher.BackColor = System.Drawing.SystemColors.Window;
            this.tB_publisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_publisher.Location = new System.Drawing.Point(164, 210);
            this.tB_publisher.Name = "tB_publisher";
            this.tB_publisher.Size = new System.Drawing.Size(251, 22);
            this.tB_publisher.TabIndex = 6;
            // 
            // label_Publisher
            // 
            this.label_Publisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Publisher.AutoSize = true;
            this.label_Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Publisher.Location = new System.Drawing.Point(12, 210);
            this.label_Publisher.Name = "label_Publisher";
            this.label_Publisher.Size = new System.Drawing.Size(51, 20);
            this.label_Publisher.TabIndex = 21;
            this.label_Publisher.Text = "Kiadó";
            // 
            // tB_condition
            // 
            this.tB_condition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_condition.BackColor = System.Drawing.SystemColors.Window;
            this.tB_condition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_condition.Location = new System.Drawing.Point(164, 242);
            this.tB_condition.Name = "tB_condition";
            this.tB_condition.Size = new System.Drawing.Size(251, 22);
            this.tB_condition.TabIndex = 7;
            // 
            // tB_binding
            // 
            this.tB_binding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_binding.BackColor = System.Drawing.SystemColors.Window;
            this.tB_binding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_binding.Location = new System.Drawing.Point(164, 274);
            this.tB_binding.Name = "tB_binding";
            this.tB_binding.Size = new System.Drawing.Size(251, 22);
            this.tB_binding.TabIndex = 8;
            // 
            // label_Binding
            // 
            this.label_Binding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Binding.AutoSize = true;
            this.label_Binding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Binding.Location = new System.Drawing.Point(12, 274);
            this.label_Binding.Name = "label_Binding";
            this.label_Binding.Size = new System.Drawing.Size(52, 20);
            this.label_Binding.TabIndex = 23;
            this.label_Binding.Text = "Kötés";
            // 
            // label_Condition
            // 
            this.label_Condition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Condition.AutoSize = true;
            this.label_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Condition.Location = new System.Drawing.Point(12, 242);
            this.label_Condition.Name = "label_Condition";
            this.label_Condition.Size = new System.Drawing.Size(60, 20);
            this.label_Condition.TabIndex = 22;
            this.label_Condition.Text = "Állapot";
            // 
            // könyvekTableAdapter
            // 
            this.könyvekTableAdapter.ClearBeforeFill = true;
            // 
            // könyvekBindingSource1
            // 
            this.könyvekBindingSource1.DataMember = "Könyvek";
            this.könyvekBindingSource1.DataSource = this.antiqueDBDataSet;
            // 
            // tB_ID
            // 
            this.tB_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_ID.BackColor = System.Drawing.SystemColors.Window;
            this.tB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_ID.Location = new System.Drawing.Point(164, 492);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.Size = new System.Drawing.Size(251, 22);
            this.tB_ID.TabIndex = 28;
            // 
            // label_BookID
            // 
            this.label_BookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_BookID.AutoSize = true;
            this.label_BookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_BookID.Location = new System.Drawing.Point(12, 492);
            this.label_BookID.Name = "label_BookID";
            this.label_BookID.Size = new System.Drawing.Size(131, 20);
            this.label_BookID.TabIndex = 29;
            this.label_BookID.Text = "Könyv azonosító";
            // 
            // label_Selling_price
            // 
            this.label_Selling_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Selling_price.AutoSize = true;
            this.label_Selling_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Selling_price.Location = new System.Drawing.Point(12, 370);
            this.label_Selling_price.Name = "label_Selling_price";
            this.label_Selling_price.Size = new System.Drawing.Size(84, 20);
            this.label_Selling_price.TabIndex = 26;
            this.label_Selling_price.Text = "Eladási ár";
            // 
            // tB_selling_price
            // 
            this.tB_selling_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_selling_price.BackColor = System.Drawing.SystemColors.Window;
            this.tB_selling_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_selling_price.Location = new System.Drawing.Point(164, 370);
            this.tB_selling_price.Name = "tB_selling_price";
            this.tB_selling_price.Size = new System.Drawing.Size(251, 22);
            this.tB_selling_price.TabIndex = 11;
            this.tB_selling_price.Text = "Hozzáadásnál nem kell megadni!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_BookID);
            this.panel1.Controls.Add(this.label_ISBN);
            this.panel1.Controls.Add(this.tB_ID);
            this.panel1.Controls.Add(this.label_Author);
            this.panel1.Controls.Add(this.label_Condition);
            this.panel1.Controls.Add(this.label_Title);
            this.panel1.Controls.Add(this.label_Binding);
            this.panel1.Controls.Add(this.label_Genre);
            this.panel1.Controls.Add(this.tB_binding);
            this.panel1.Controls.Add(this.label_Pagenumber);
            this.panel1.Controls.Add(this.tB_condition);
            this.panel1.Controls.Add(this.label_Purchase_price);
            this.panel1.Controls.Add(this.label_Publisher);
            this.panel1.Controls.Add(this.label_Selling_price);
            this.panel1.Controls.Add(this.tB_publisher);
            this.panel1.Controls.Add(this.tB_ISBN);
            this.panel1.Controls.Add(this.label_Year);
            this.panel1.Controls.Add(this.tB_author);
            this.panel1.Controls.Add(this.button_book_delete);
            this.panel1.Controls.Add(this.tB_title);
            this.panel1.Controls.Add(this.button_book_modification);
            this.panel1.Controls.Add(this.tB_year);
            this.panel1.Controls.Add(this.button_new_book);
            this.panel1.Controls.Add(this.tB_genre);
            this.panel1.Controls.Add(this.button_display);
            this.panel1.Controls.Add(this.tB_pagenumber);
            this.panel1.Controls.Add(this.tB_selling_price);
            this.panel1.Controls.Add(this.tB_purchase_price);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 775);
            this.panel1.TabIndex = 30;
            // 
            // BookManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.könyvekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.könyvekBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Genre;
        private System.Windows.Forms.Label label_Pagenumber;
        private System.Windows.Forms.Label label_Purchase_price;
        private System.Windows.Forms.TextBox tB_ISBN;
        private System.Windows.Forms.TextBox tB_author;
        private System.Windows.Forms.TextBox tB_title;
        private System.Windows.Forms.TextBox tB_year;
        private System.Windows.Forms.TextBox tB_genre;
        private System.Windows.Forms.TextBox tB_pagenumber;
        private System.Windows.Forms.TextBox tB_purchase_price;
        private System.Windows.Forms.Button button_display;
        private System.Windows.Forms.Button button_new_book;
        private System.Windows.Forms.Button button_book_modification;
        private System.Windows.Forms.Button button_book_delete;
        private System.Windows.Forms.Label label_Year;
        private System.Windows.Forms.TextBox tB_publisher;
        private System.Windows.Forms.Label label_Publisher;
        private System.Windows.Forms.TextBox tB_condition;
        private System.Windows.Forms.TextBox tB_binding;
        private System.Windows.Forms.Label label_Binding;
        private System.Windows.Forms.Label label_Condition;
        private AntiqueDBDataSet antiqueDBDataSet;
        private System.Windows.Forms.BindingSource könyvekBindingSource;
        private AntiqueDBDataSetTableAdapters.KönyvekTableAdapter könyvekTableAdapter;
        private System.Windows.Forms.BindingSource könyvekBindingSource1;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.Label label_BookID;
        private System.Windows.Forms.Label label_Selling_price;
        private System.Windows.Forms.TextBox tB_selling_price;
        private System.Windows.Forms.Panel panel1;
    }
}