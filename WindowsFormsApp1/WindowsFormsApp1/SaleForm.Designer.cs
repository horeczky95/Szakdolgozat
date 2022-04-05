namespace WindowsFormsApp1
{
    partial class SaleForm
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
            this.regularCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_books = new System.Windows.Forms.DataGridView();
            this.könyvekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.antiqueDBDataSet = new WindowsFormsApp1.AntiqueDBDataSet();
            this.listView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sellin_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_total_name = new System.Windows.Forms.Label();
            this.label_subtotal_name = new System.Windows.Forms.Label();
            this.könyvekTableAdapter = new WindowsFormsApp1.AntiqueDBDataSetTableAdapters.KönyvekTableAdapter();
            this.tB_ISBN = new System.Windows.Forms.TextBox();
            this.label_year = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_ISBN = new System.Windows.Forms.Label();
            this.tB_genre = new System.Windows.Forms.TextBox();
            this.tB_year = new System.Windows.Forms.TextBox();
            this.tB_title = new System.Windows.Forms.TextBox();
            this.tB_author = new System.Windows.Forms.TextBox();
            this.tB_id = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_subtotal = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_regcust_ID = new System.Windows.Forms.Label();
            this.tB_regcust_ID = new System.Windows.Forms.TextBox();
            this.tB_book_discount = new System.Windows.Forms.TextBox();
            this.label_book_discount = new System.Windows.Forms.Label();
            this.tB_total_discount = new System.Windows.Forms.TextBox();
            this.label_total_discount = new System.Windows.Forms.Label();
            this.dataGridView_regcust = new System.Windows.Forms.DataGridView();
            this.tB_barcode = new System.Windows.Forms.TextBox();
            this.label_barcode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pB_barcode = new System.Windows.Forms.PictureBox();
            this.search_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.sale_button = new System.Windows.Forms.Button();
            this.regcust_point_button = new System.Windows.Forms.Button();
            this.discount_button = new System.Windows.Forms.Button();
            this.display_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.barcode_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.könyvekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_regcust)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_barcode)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1482, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.regularCustomerToolStripMenuItem,
            this.bookManagerToolStripMenuItem,
            this.wishListToolStripMenuItem,
            this.statementsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "Fájl";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.mainMenuToolStripMenuItem.Text = "Főmenü";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
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
            // wishListToolStripMenuItem
            // 
            this.wishListToolStripMenuItem.Name = "wishListToolStripMenuItem";
            this.wishListToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.wishListToolStripMenuItem.Text = "Kívánság lista";
            this.wishListToolStripMenuItem.Click += new System.EventHandler(this.wishListToolStripMenuItem_Click);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.helpToolStripMenuItem.Text = "Súgó";
            // 
            // dataGridView_books
            // 
            this.dataGridView_books.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_books.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_books.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_books.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_books.GridColor = System.Drawing.Color.Black;
            this.dataGridView_books.Location = new System.Drawing.Point(585, 42);
            this.dataGridView_books.Name = "dataGridView_books";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_books.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_books.RowHeadersWidth = 51;
            this.dataGridView_books.RowTemplate.Height = 24;
            this.dataGridView_books.Size = new System.Drawing.Size(869, 370);
            this.dataGridView_books.TabIndex = 19;
            this.dataGridView_books.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG_double_Click);
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
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ISBN,
            this.Author,
            this.Title,
            this.Sellin_Price});
            this.listView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(585, 420);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(869, 290);
            this.listView.TabIndex = 20;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 84;
            // 
            // Author
            // 
            this.Author.Text = "Szerző";
            this.Author.Width = 162;
            // 
            // Title
            // 
            this.Title.Text = "Cím";
            this.Title.Width = 210;
            // 
            // Sellin_Price
            // 
            this.Sellin_Price.Text = "Eladási ár";
            this.Sellin_Price.Width = 101;
            // 
            // label_total_name
            // 
            this.label_total_name.AutoSize = true;
            this.label_total_name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_total_name.Location = new System.Drawing.Point(1116, 763);
            this.label_total_name.Name = "label_total_name";
            this.label_total_name.Size = new System.Drawing.Size(109, 27);
            this.label_total_name.TabIndex = 34;
            this.label_total_name.Text = "Végösszeg";
            // 
            // label_subtotal_name
            // 
            this.label_subtotal_name.AutoSize = true;
            this.label_subtotal_name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_subtotal_name.Location = new System.Drawing.Point(1116, 723);
            this.label_subtotal_name.Name = "label_subtotal_name";
            this.label_subtotal_name.Size = new System.Drawing.Size(115, 27);
            this.label_subtotal_name.TabIndex = 32;
            this.label_subtotal_name.Text = "Részösszeg";
            // 
            // könyvekTableAdapter
            // 
            this.könyvekTableAdapter.ClearBeforeFill = true;
            // 
            // tB_ISBN
            // 
            this.tB_ISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_ISBN.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_ISBN.ForeColor = System.Drawing.Color.Gray;
            this.tB_ISBN.Location = new System.Drawing.Point(317, 74);
            this.tB_ISBN.Name = "tB_ISBN";
            this.tB_ISBN.Size = new System.Drawing.Size(240, 25);
            this.tB_ISBN.TabIndex = 1;
            this.tB_ISBN.Text = "ISBN";
            this.tB_ISBN.Enter += new System.EventHandler(this.tB_ISBN_Enter);
            this.tB_ISBN.Leave += new System.EventHandler(this.tB_ISBN_Leave);
            // 
            // label_year
            // 
            this.label_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_year.Location = new System.Drawing.Point(12, 166);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(92, 23);
            this.label_year.TabIndex = 25;
            this.label_year.Text = "Kiadás éve";
            // 
            // label_genre
            // 
            this.label_genre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_genre.AutoSize = true;
            this.label_genre.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_genre.Location = new System.Drawing.Point(12, 194);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(55, 23);
            this.label_genre.TabIndex = 26;
            this.label_genre.Text = "Műfaj";
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.Location = new System.Drawing.Point(12, 136);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(42, 23);
            this.label_title.TabIndex = 24;
            this.label_title.Text = "Cím";
            // 
            // label_author
            // 
            this.label_author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_author.Location = new System.Drawing.Point(12, 106);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(60, 23);
            this.label_author.TabIndex = 23;
            this.label_author.Text = "Szerző";
            // 
            // label_ISBN
            // 
            this.label_ISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ISBN.Location = new System.Drawing.Point(12, 75);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(49, 23);
            this.label_ISBN.TabIndex = 22;
            this.label_ISBN.Text = "ISBN";
            // 
            // tB_genre
            // 
            this.tB_genre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_genre.AutoCompleteCustomSource.AddRange(new string[] {
            "Krími",
            "Történelmi regény",
            "Romantikus regény",
            "Sci-Fi",
            "Fantasy",
            "Horror",
            "Ifjúsági regény",
            "Gasztronómia",
            "Sport",
            "Lektűr",
            "Akció, kaland",
            "Erotikus",
            "Humor",
            "Dráma",
            "Mese",
            "Novella",
            "Manga",
            "Utazás"});
            this.tB_genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tB_genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tB_genre.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_genre.ForeColor = System.Drawing.Color.Gray;
            this.tB_genre.Location = new System.Drawing.Point(317, 192);
            this.tB_genre.Name = "tB_genre";
            this.tB_genre.Size = new System.Drawing.Size(240, 25);
            this.tB_genre.TabIndex = 5;
            this.tB_genre.Text = "Műfaj";
            this.tB_genre.Enter += new System.EventHandler(this.tB_genre_Enter);
            this.tB_genre.Leave += new System.EventHandler(this.tB_genre_Leave);
            // 
            // tB_year
            // 
            this.tB_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_year.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_year.ForeColor = System.Drawing.Color.Gray;
            this.tB_year.Location = new System.Drawing.Point(317, 162);
            this.tB_year.Name = "tB_year";
            this.tB_year.Size = new System.Drawing.Size(240, 25);
            this.tB_year.TabIndex = 4;
            this.tB_year.Text = "Kiadás éve";
            this.tB_year.Enter += new System.EventHandler(this.tB_year_Enter);
            this.tB_year.Leave += new System.EventHandler(this.tB_year_Leave);
            // 
            // tB_title
            // 
            this.tB_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_title.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_title.ForeColor = System.Drawing.Color.Gray;
            this.tB_title.Location = new System.Drawing.Point(317, 132);
            this.tB_title.Name = "tB_title";
            this.tB_title.Size = new System.Drawing.Size(240, 25);
            this.tB_title.TabIndex = 3;
            this.tB_title.Text = "Cím";
            this.tB_title.Enter += new System.EventHandler(this.tB_title_Enter);
            this.tB_title.Leave += new System.EventHandler(this.tB_title_Leave);
            // 
            // tB_author
            // 
            this.tB_author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_author.AutoCompleteCustomSource.AddRange(new string[] {
            "Agatha Christie",
            "E. M. Nathanson",
            "Gaston Leruxon",
            "Margaret Mitchell",
            "William Kotzwinkle",
            "Pierre Boulle",
            "Dave Wolverton",
            "Danielle Steel",
            "Jennifer L. Armentrout",
            "Sarin Bowen",
            "Elle Kennedy",
            "Kiss Attia",
            "Carla Bardi",
            "Mari Salinas",
            "Kiss Enikő",
            "Stephen King",
            "Laurell K Hamilton",
            "Anna Todd",
            "Sandra Brown",
            "Stephanie Perkins",
            "Kathleen E. Woodiwiss"});
            this.tB_author.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tB_author.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tB_author.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_author.ForeColor = System.Drawing.Color.Gray;
            this.tB_author.Location = new System.Drawing.Point(317, 102);
            this.tB_author.Name = "tB_author";
            this.tB_author.Size = new System.Drawing.Size(240, 25);
            this.tB_author.TabIndex = 2;
            this.tB_author.Text = "Szerző";
            this.tB_author.Enter += new System.EventHandler(this.tB_author_Enter);
            this.tB_author.Leave += new System.EventHandler(this.tB_author_Leave);
            // 
            // tB_id
            // 
            this.tB_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_id.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_id.ForeColor = System.Drawing.Color.Gray;
            this.tB_id.Location = new System.Drawing.Point(317, 222);
            this.tB_id.Name = "tB_id";
            this.tB_id.Size = new System.Drawing.Size(240, 25);
            this.tB_id.TabIndex = 6;
            this.tB_id.Text = "ID";
            this.tB_id.Enter += new System.EventHandler(this.tB_ID_Enter);
            this.tB_id.Leave += new System.EventHandler(this.tB_ID_Leave);
            // 
            // label_ID
            // 
            this.label_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ID.Location = new System.Drawing.Point(12, 220);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(87, 23);
            this.label_ID.TabIndex = 27;
            this.label_ID.Text = "Azonosító";
            // 
            // label_subtotal
            // 
            this.label_subtotal.AutoSize = true;
            this.label_subtotal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_subtotal.Location = new System.Drawing.Point(1287, 723);
            this.label_subtotal.Name = "label_subtotal";
            this.label_subtotal.Size = new System.Drawing.Size(45, 27);
            this.label_subtotal.TabIndex = 33;
            this.label_subtotal.Text = "0 Ft";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_total.Location = new System.Drawing.Point(1287, 763);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(45, 27);
            this.label_total.TabIndex = 35;
            this.label_total.Text = "0 Ft";
            // 
            // label_regcust_ID
            // 
            this.label_regcust_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_regcust_ID.AutoSize = true;
            this.label_regcust_ID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_regcust_ID.Location = new System.Drawing.Point(12, 312);
            this.label_regcust_ID.Name = "label_regcust_ID";
            this.label_regcust_ID.Size = new System.Drawing.Size(146, 23);
            this.label_regcust_ID.TabIndex = 28;
            this.label_regcust_ID.Text = "Törzsvásárlói kód";
            // 
            // tB_regcust_ID
            // 
            this.tB_regcust_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_regcust_ID.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_regcust_ID.ForeColor = System.Drawing.Color.Gray;
            this.tB_regcust_ID.Location = new System.Drawing.Point(317, 311);
            this.tB_regcust_ID.Name = "tB_regcust_ID";
            this.tB_regcust_ID.Size = new System.Drawing.Size(240, 25);
            this.tB_regcust_ID.TabIndex = 10;
            this.tB_regcust_ID.Text = "Törzsvásárlói kód";
            this.tB_regcust_ID.Enter += new System.EventHandler(this.tB_regcust_ID_Enter);
            this.tB_regcust_ID.Leave += new System.EventHandler(this.tB_regcust_ID_Leave);
            // 
            // tB_book_discount
            // 
            this.tB_book_discount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_book_discount.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_book_discount.ForeColor = System.Drawing.Color.Gray;
            this.tB_book_discount.Location = new System.Drawing.Point(317, 342);
            this.tB_book_discount.Name = "tB_book_discount";
            this.tB_book_discount.Size = new System.Drawing.Size(240, 25);
            this.tB_book_discount.TabIndex = 11;
            this.tB_book_discount.Text = "Könyv kedvezmény";
            this.tB_book_discount.Enter += new System.EventHandler(this.tB_book_discount_Enter);
            this.tB_book_discount.Leave += new System.EventHandler(this.tB_book_discount_Leave);
            // 
            // label_book_discount
            // 
            this.label_book_discount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_book_discount.AutoSize = true;
            this.label_book_discount.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_book_discount.Location = new System.Drawing.Point(12, 342);
            this.label_book_discount.Name = "label_book_discount";
            this.label_book_discount.Size = new System.Drawing.Size(187, 23);
            this.label_book_discount.TabIndex = 29;
            this.label_book_discount.Text = "Könyv kedvezmény (%)";
            // 
            // tB_total_discount
            // 
            this.tB_total_discount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_total_discount.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_total_discount.ForeColor = System.Drawing.Color.Gray;
            this.tB_total_discount.Location = new System.Drawing.Point(317, 372);
            this.tB_total_discount.Name = "tB_total_discount";
            this.tB_total_discount.Size = new System.Drawing.Size(240, 25);
            this.tB_total_discount.TabIndex = 12;
            this.tB_total_discount.Text = "Végösszeg kedvezmény";
            this.tB_total_discount.Enter += new System.EventHandler(this.tB_total_discount_Enter);
            this.tB_total_discount.Leave += new System.EventHandler(this.tB_total_discount_Leave);
            // 
            // label_total_discount
            // 
            this.label_total_discount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_total_discount.AutoSize = true;
            this.label_total_discount.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_total_discount.Location = new System.Drawing.Point(12, 372);
            this.label_total_discount.Name = "label_total_discount";
            this.label_total_discount.Size = new System.Drawing.Size(218, 23);
            this.label_total_discount.TabIndex = 30;
            this.label_total_discount.Text = "Végösszeg kedvezmény (%)";
            // 
            // dataGridView_regcust
            // 
            this.dataGridView_regcust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_regcust.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridView_regcust.Location = new System.Drawing.Point(12, 462);
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
            this.dataGridView_regcust.Size = new System.Drawing.Size(534, 160);
            this.dataGridView_regcust.TabIndex = 21;
            this.dataGridView_regcust.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reg_cust_db_double_click);
            // 
            // tB_barcode
            // 
            this.tB_barcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_barcode.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_barcode.ForeColor = System.Drawing.Color.Gray;
            this.tB_barcode.Location = new System.Drawing.Point(602, 748);
            this.tB_barcode.Name = "tB_barcode";
            this.tB_barcode.Size = new System.Drawing.Size(240, 25);
            this.tB_barcode.TabIndex = 17;
            this.tB_barcode.Text = "Vonalkód";
            this.tB_barcode.Enter += new System.EventHandler(this.tB_barcode_Enter);
            this.tB_barcode.Leave += new System.EventHandler(this.tB_barcode_Leave);
            // 
            // label_barcode
            // 
            this.label_barcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_barcode.AutoSize = true;
            this.label_barcode.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_barcode.Location = new System.Drawing.Point(680, 718);
            this.label_barcode.Name = "label_barcode";
            this.label_barcode.Size = new System.Drawing.Size(84, 23);
            this.label_barcode.TabIndex = 31;
            this.label_barcode.Text = "Vonalkód";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pB_barcode);
            this.panel1.Controls.Add(this.search_button);
            this.panel1.Controls.Add(this.tB_ISBN);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.sale_button);
            this.panel1.Controls.Add(this.dataGridView_regcust);
            this.panel1.Controls.Add(this.label_ISBN);
            this.panel1.Controls.Add(this.regcust_point_button);
            this.panel1.Controls.Add(this.label_author);
            this.panel1.Controls.Add(this.discount_button);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Controls.Add(this.display_button);
            this.panel1.Controls.Add(this.tB_total_discount);
            this.panel1.Controls.Add(this.label_genre);
            this.panel1.Controls.Add(this.label_total_discount);
            this.panel1.Controls.Add(this.label_year);
            this.panel1.Controls.Add(this.tB_book_discount);
            this.panel1.Controls.Add(this.tB_title);
            this.panel1.Controls.Add(this.label_book_discount);
            this.panel1.Controls.Add(this.tB_year);
            this.panel1.Controls.Add(this.tB_regcust_ID);
            this.panel1.Controls.Add(this.tB_genre);
            this.panel1.Controls.Add(this.label_regcust_ID);
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.tB_id);
            this.panel1.Controls.Add(this.tB_author);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 773);
            this.panel1.TabIndex = 53;
            // 
            // pB_barcode
            // 
            this.pB_barcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pB_barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pB_barcode.Cursor = System.Windows.Forms.Cursors.No;
            this.pB_barcode.Image = global::WindowsFormsApp1.Properties.Resources.barcode_example;
            this.pB_barcode.Location = new System.Drawing.Point(12, 630);
            this.pB_barcode.Name = "pB_barcode";
            this.pB_barcode.Size = new System.Drawing.Size(534, 136);
            this.pB_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_barcode.TabIndex = 50;
            this.pB_barcode.TabStop = false;
            // 
            // search_button
            // 
            this.search_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.search_button.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.search_button.Location = new System.Drawing.Point(12, 14);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(177, 52);
            this.search_button.TabIndex = 15;
            this.search_button.Text = "Könyv keresés";
            this.search_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // add_button
            // 
            this.add_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_button.Image = global::WindowsFormsApp1.Properties.Resources.basket;
            this.add_button.Location = new System.Drawing.Point(12, 252);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(177, 52);
            this.add_button.TabIndex = 7;
            this.add_button.Text = "Könyv kosárhoz adása";
            this.add_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // sale_button
            // 
            this.sale_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sale_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.sale_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sale_button.FlatAppearance.BorderSize = 0;
            this.sale_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sale_button.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sale_button.Image = global::WindowsFormsApp1.Properties.Resources.selling;
            this.sale_button.Location = new System.Drawing.Point(380, 252);
            this.sale_button.Name = "sale_button";
            this.sale_button.Size = new System.Drawing.Size(177, 52);
            this.sale_button.TabIndex = 9;
            this.sale_button.Text = "Eladás";
            this.sale_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sale_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sale_button.UseVisualStyleBackColor = false;
            this.sale_button.Click += new System.EventHandler(this.sale_button_Click);
            // 
            // regcust_point_button
            // 
            this.regcust_point_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regcust_point_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.regcust_point_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regcust_point_button.FlatAppearance.BorderSize = 0;
            this.regcust_point_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regcust_point_button.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regcust_point_button.Image = global::WindowsFormsApp1.Properties.Resources.regular_cutomer_points;
            this.regcust_point_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regcust_point_button.Location = new System.Drawing.Point(12, 402);
            this.regcust_point_button.Name = "regcust_point_button";
            this.regcust_point_button.Size = new System.Drawing.Size(177, 52);
            this.regcust_point_button.TabIndex = 13;
            this.regcust_point_button.Text = "Törzsvásálói pont levonás";
            this.regcust_point_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.regcust_point_button.UseVisualStyleBackColor = false;
            this.regcust_point_button.Click += new System.EventHandler(this.reg_cust_point_button_Click);
            // 
            // discount_button
            // 
            this.discount_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discount_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.discount_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discount_button.FlatAppearance.BorderSize = 0;
            this.discount_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discount_button.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.discount_button.Image = global::WindowsFormsApp1.Properties.Resources.discount;
            this.discount_button.Location = new System.Drawing.Point(380, 402);
            this.discount_button.Name = "discount_button";
            this.discount_button.Size = new System.Drawing.Size(177, 52);
            this.discount_button.TabIndex = 14;
            this.discount_button.Text = "Kedvezmény";
            this.discount_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.discount_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.discount_button.UseVisualStyleBackColor = false;
            this.discount_button.Click += new System.EventHandler(this.discount_Click);
            // 
            // display_button
            // 
            this.display_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.display_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.display_button.FlatAppearance.BorderSize = 0;
            this.display_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display_button.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.display_button.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.display_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.display_button.Location = new System.Drawing.Point(380, 12);
            this.display_button.Name = "display_button";
            this.display_button.Size = new System.Drawing.Size(177, 52);
            this.display_button.TabIndex = 16;
            this.display_button.Text = "Összes könyv megjelenítése";
            this.display_button.UseVisualStyleBackColor = false;
            this.display_button.Click += new System.EventHandler(this.display_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_button.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.delete_button.Location = new System.Drawing.Point(196, 252);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(177, 52);
            this.delete_button.TabIndex = 8;
            this.delete_button.Text = "Törlés a kosárból";
            this.delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // barcode_button
            // 
            this.barcode_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.barcode_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barcode_button.FlatAppearance.BorderSize = 0;
            this.barcode_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.barcode_button.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.barcode_button.Image = global::WindowsFormsApp1.Properties.Resources.barcode;
            this.barcode_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.barcode_button.Location = new System.Drawing.Point(848, 721);
            this.barcode_button.Name = "barcode_button";
            this.barcode_button.Size = new System.Drawing.Size(177, 52);
            this.barcode_button.TabIndex = 18;
            this.barcode_button.Text = "Vonalkód beolvasás";
            this.barcode_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.barcode_button.UseVisualStyleBackColor = false;
            this.barcode_button.Click += new System.EventHandler(this.barcode_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_barcode);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label_subtotal);
            this.Controls.Add(this.tB_barcode);
            this.Controls.Add(this.label_subtotal_name);
            this.Controls.Add(this.label_total_name);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.barcode_button);
            this.Controls.Add(this.dataGridView_books);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eladás";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.könyvekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_regcust)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wishListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_books;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label_total_name;
        private System.Windows.Forms.Label label_subtotal_name;
        private AntiqueDBDataSet antiqueDBDataSet;
        private System.Windows.Forms.BindingSource könyvekBindingSource;
        private AntiqueDBDataSetTableAdapters.KönyvekTableAdapter könyvekTableAdapter;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button sale_button;
        private System.Windows.Forms.TextBox tB_ISBN;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.TextBox tB_genre;
        private System.Windows.Forms.TextBox tB_year;
        private System.Windows.Forms.TextBox tB_title;
        private System.Windows.Forms.TextBox tB_author;
        private System.Windows.Forms.Button display_button;
        private System.Windows.Forms.TextBox tB_id;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Sellin_Price;
        private System.Windows.Forms.Label label_subtotal;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label label_regcust_ID;
        private System.Windows.Forms.TextBox tB_regcust_ID;
        private System.Windows.Forms.TextBox tB_book_discount;
        private System.Windows.Forms.Label label_book_discount;
        private System.Windows.Forms.TextBox tB_total_discount;
        private System.Windows.Forms.Label label_total_discount;
        private System.Windows.Forms.Button discount_button;
        private System.Windows.Forms.DataGridView dataGridView_regcust;
        private System.Windows.Forms.Button regcust_point_button;
        private System.Windows.Forms.Button barcode_button;
        private System.Windows.Forms.PictureBox pB_barcode;
        private System.Windows.Forms.TextBox tB_barcode;
        private System.Windows.Forms.Label label_barcode;
        private System.Windows.Forms.Panel panel1;
    }
}