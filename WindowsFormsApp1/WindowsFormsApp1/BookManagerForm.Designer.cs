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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.könyvekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.antiqueDBDataSet = new WindowsFormsApp1.AntiqueDBDataSet();
            this.antiqueDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_ISBN = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_pagenumber = new System.Windows.Forms.Label();
            this.label_purchase_price = new System.Windows.Forms.Label();
            this.tB_ISBN = new System.Windows.Forms.TextBox();
            this.tB_author = new System.Windows.Forms.TextBox();
            this.tB_title = new System.Windows.Forms.TextBox();
            this.tB_year = new System.Windows.Forms.TextBox();
            this.tB_genre = new System.Windows.Forms.TextBox();
            this.tB_pagenumber = new System.Windows.Forms.TextBox();
            this.tB_purchase_price = new System.Windows.Forms.TextBox();
            this.display_button = new System.Windows.Forms.Button();
            this.new_book_add_button = new System.Windows.Forms.Button();
            this.book_modification_button = new System.Windows.Forms.Button();
            this.book_delete_button = new System.Windows.Forms.Button();
            this.label_year = new System.Windows.Forms.Label();
            this.tB_publisher = new System.Windows.Forms.TextBox();
            this.label_publisher = new System.Windows.Forms.Label();
            this.tB_condition = new System.Windows.Forms.TextBox();
            this.tB_binding = new System.Windows.Forms.TextBox();
            this.label_binding = new System.Windows.Forms.Label();
            this.label_condition = new System.Windows.Forms.Label();
            this.könyvekTableAdapter = new WindowsFormsApp1.AntiqueDBDataSetTableAdapters.KönyvekTableAdapter();
            this.könyvekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.label_bookID = new System.Windows.Forms.Label();
            this.label_selling_price = new System.Windows.Forms.Label();
            this.tB_selling_price = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.saleToolStripMenuItem,
            this.regularCustomerToolStripMenuItem,
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(463, 28);
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
            this.dataGridView.Size = new System.Drawing.Size(1007, 763);
            this.dataGridView.TabIndex = 27;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG_double_Click);
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
            this.label_ISBN.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ISBN.Location = new System.Drawing.Point(12, 50);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(93, 23);
            this.label_ISBN.TabIndex = 16;
            this.label_ISBN.Text = "ISBN szám";
            // 
            // label_author
            // 
            this.label_author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_author.Location = new System.Drawing.Point(12, 82);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(60, 23);
            this.label_author.TabIndex = 17;
            this.label_author.Text = "Szerző";
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.Location = new System.Drawing.Point(12, 114);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(39, 20);
            this.label_title.TabIndex = 18;
            this.label_title.Text = "Cím";
            // 
            // label_genre
            // 
            this.label_genre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_genre.AutoSize = true;
            this.label_genre.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_genre.Location = new System.Drawing.Point(12, 178);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(55, 23);
            this.label_genre.TabIndex = 20;
            this.label_genre.Text = "Műfaj";
            // 
            // label_pagenumber
            // 
            this.label_pagenumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_pagenumber.AutoSize = true;
            this.label_pagenumber.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_pagenumber.Location = new System.Drawing.Point(12, 306);
            this.label_pagenumber.Name = "label_pagenumber";
            this.label_pagenumber.Size = new System.Drawing.Size(92, 23);
            this.label_pagenumber.TabIndex = 24;
            this.label_pagenumber.Text = "Oldalszám";
            // 
            // label_purchase_price
            // 
            this.label_purchase_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_purchase_price.AutoSize = true;
            this.label_purchase_price.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_purchase_price.Location = new System.Drawing.Point(12, 338);
            this.label_purchase_price.Name = "label_purchase_price";
            this.label_purchase_price.Size = new System.Drawing.Size(108, 23);
            this.label_purchase_price.TabIndex = 25;
            this.label_purchase_price.Text = "Beszerzési ár";
            // 
            // tB_ISBN
            // 
            this.tB_ISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_ISBN.BackColor = System.Drawing.SystemColors.Window;
            this.tB_ISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_ISBN.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_ISBN.ForeColor = System.Drawing.Color.Gray;
            this.tB_ISBN.Location = new System.Drawing.Point(170, 50);
            this.tB_ISBN.Name = "tB_ISBN";
            this.tB_ISBN.Size = new System.Drawing.Size(251, 25);
            this.tB_ISBN.TabIndex = 1;
            this.tB_ISBN.Text = "ISBN";
            this.tB_ISBN.Enter += new System.EventHandler(this.tB_ISBN_Enter);
            this.tB_ISBN.Leave += new System.EventHandler(this.tB_ISBN_Leave);
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
            this.tB_author.BackColor = System.Drawing.SystemColors.Window;
            this.tB_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_author.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_author.ForeColor = System.Drawing.Color.Gray;
            this.tB_author.Location = new System.Drawing.Point(170, 82);
            this.tB_author.Name = "tB_author";
            this.tB_author.Size = new System.Drawing.Size(251, 25);
            this.tB_author.TabIndex = 2;
            this.tB_author.Text = "Szerző";
            this.tB_author.Enter += new System.EventHandler(this.tB_author_Enter);
            this.tB_author.Leave += new System.EventHandler(this.tB_author_Leave);
            // 
            // tB_title
            // 
            this.tB_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_title.BackColor = System.Drawing.SystemColors.Window;
            this.tB_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_title.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_title.ForeColor = System.Drawing.Color.Gray;
            this.tB_title.Location = new System.Drawing.Point(170, 114);
            this.tB_title.Name = "tB_title";
            this.tB_title.Size = new System.Drawing.Size(251, 25);
            this.tB_title.TabIndex = 3;
            this.tB_title.Text = "Cím";
            this.tB_title.Enter += new System.EventHandler(this.tB_title_Enter);
            this.tB_title.Leave += new System.EventHandler(this.tB_title_Leave);
            // 
            // tB_year
            // 
            this.tB_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_year.BackColor = System.Drawing.SystemColors.Window;
            this.tB_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_year.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_year.ForeColor = System.Drawing.Color.Gray;
            this.tB_year.Location = new System.Drawing.Point(170, 146);
            this.tB_year.Name = "tB_year";
            this.tB_year.Size = new System.Drawing.Size(251, 25);
            this.tB_year.TabIndex = 4;
            this.tB_year.Text = "Kiadás éve";
            this.tB_year.Enter += new System.EventHandler(this.tB_year_Enter);
            this.tB_year.Leave += new System.EventHandler(this.tB_year_Leave);
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
            this.tB_genre.BackColor = System.Drawing.SystemColors.Window;
            this.tB_genre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_genre.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_genre.ForeColor = System.Drawing.Color.Gray;
            this.tB_genre.Location = new System.Drawing.Point(170, 178);
            this.tB_genre.Name = "tB_genre";
            this.tB_genre.Size = new System.Drawing.Size(251, 25);
            this.tB_genre.TabIndex = 5;
            this.tB_genre.Text = "Műfaj";
            this.tB_genre.Enter += new System.EventHandler(this.tB_genre_Enter);
            this.tB_genre.Leave += new System.EventHandler(this.tB_genre_Leave);
            // 
            // tB_pagenumber
            // 
            this.tB_pagenumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_pagenumber.BackColor = System.Drawing.SystemColors.Window;
            this.tB_pagenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_pagenumber.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_pagenumber.ForeColor = System.Drawing.Color.Gray;
            this.tB_pagenumber.Location = new System.Drawing.Point(170, 306);
            this.tB_pagenumber.Name = "tB_pagenumber";
            this.tB_pagenumber.Size = new System.Drawing.Size(251, 25);
            this.tB_pagenumber.TabIndex = 9;
            this.tB_pagenumber.Text = "Oldalszám";
            this.tB_pagenumber.Enter += new System.EventHandler(this.tB_pagenumber_Enter);
            this.tB_pagenumber.Leave += new System.EventHandler(this.tB_pagenumber_Leave);
            // 
            // tB_purchase_price
            // 
            this.tB_purchase_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_purchase_price.BackColor = System.Drawing.SystemColors.Window;
            this.tB_purchase_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_purchase_price.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_purchase_price.ForeColor = System.Drawing.Color.Gray;
            this.tB_purchase_price.Location = new System.Drawing.Point(170, 338);
            this.tB_purchase_price.Name = "tB_purchase_price";
            this.tB_purchase_price.Size = new System.Drawing.Size(251, 25);
            this.tB_purchase_price.TabIndex = 10;
            this.tB_purchase_price.Text = "Beszerzési ár forintban";
            this.tB_purchase_price.Enter += new System.EventHandler(this.tB_purchase_price_Enter);
            this.tB_purchase_price.Leave += new System.EventHandler(this.tB_purchase_price_Leave);
            // 
            // display_button
            // 
            this.display_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.display_button.AutoSize = true;
            this.display_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.display_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.display_button.FlatAppearance.BorderSize = 0;
            this.display_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.display_button.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.display_button.Location = new System.Drawing.Point(93, 539);
            this.display_button.Name = "display_button";
            this.display_button.Size = new System.Drawing.Size(240, 50);
            this.display_button.TabIndex = 12;
            this.display_button.Text = "Könyv keresés";
            this.display_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.display_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.display_button.UseVisualStyleBackColor = false;
            this.display_button.Click += new System.EventHandler(this.books_display_Click);
            // 
            // new_book_add_button
            // 
            this.new_book_add_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.new_book_add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.new_book_add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_book_add_button.FlatAppearance.BorderSize = 0;
            this.new_book_add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_book_add_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_book_add_button.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.new_book_add_button.Location = new System.Drawing.Point(93, 417);
            this.new_book_add_button.Name = "new_book_add_button";
            this.new_book_add_button.Size = new System.Drawing.Size(240, 50);
            this.new_book_add_button.TabIndex = 13;
            this.new_book_add_button.Text = "Új könyv hozzáadása";
            this.new_book_add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.new_book_add_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.new_book_add_button.UseVisualStyleBackColor = false;
            this.new_book_add_button.Click += new System.EventHandler(this.button_new_book_Click);
            // 
            // book_modification_button
            // 
            this.book_modification_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.book_modification_button.AutoSize = true;
            this.book_modification_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.book_modification_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book_modification_button.FlatAppearance.BorderSize = 0;
            this.book_modification_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_modification_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.book_modification_button.Image = global::WindowsFormsApp1.Properties.Resources.modification;
            this.book_modification_button.Location = new System.Drawing.Point(93, 689);
            this.book_modification_button.Name = "book_modification_button";
            this.book_modification_button.Size = new System.Drawing.Size(240, 50);
            this.book_modification_button.TabIndex = 14;
            this.book_modification_button.Text = "Könyv módosítása";
            this.book_modification_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.book_modification_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.book_modification_button.UseVisualStyleBackColor = false;
            this.book_modification_button.Click += new System.EventHandler(this.button_book_modification_Click);
            // 
            // book_delete_button
            // 
            this.book_delete_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.book_delete_button.AutoSize = true;
            this.book_delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.book_delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book_delete_button.FlatAppearance.BorderSize = 0;
            this.book_delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_delete_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.book_delete_button.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.book_delete_button.Location = new System.Drawing.Point(93, 614);
            this.book_delete_button.Name = "book_delete_button";
            this.book_delete_button.Size = new System.Drawing.Size(240, 50);
            this.book_delete_button.TabIndex = 15;
            this.book_delete_button.Text = "Könyv törlése";
            this.book_delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.book_delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.book_delete_button.UseVisualStyleBackColor = false;
            this.book_delete_button.Click += new System.EventHandler(this.button_book_delete_Click);
            // 
            // label_year
            // 
            this.label_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_year.Location = new System.Drawing.Point(12, 146);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(92, 23);
            this.label_year.TabIndex = 19;
            this.label_year.Text = "Kiadás éve";
            // 
            // tB_publisher
            // 
            this.tB_publisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_publisher.AutoCompleteCustomSource.AddRange(new string[] {
            "Európa Könyvkiadó",
            "Zrínyi Katonai Kiadó",
            "Árkádia Kiadó",
            "Kozmosz Könyvek",
            "Valhalla Páholy Kft.",
            "Maecenas Kft.",
            "Könymolyképző Kiadó Kft.",
            "Geolart Bt.",
            "Kossuth Kiadó Zrt.",
            "Napraforgó 2005 Kft.",
            "Fix-Therm Kft.",
            "Európa Könyvkiadó Kft.",
            "Agave Könyvek Kiadó Kft.",
            "Gabo Könyvkiadó és keresk. Kft.",
            "Magyar Könyvklub"});
            this.tB_publisher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tB_publisher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tB_publisher.BackColor = System.Drawing.SystemColors.Window;
            this.tB_publisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_publisher.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_publisher.ForeColor = System.Drawing.Color.Gray;
            this.tB_publisher.Location = new System.Drawing.Point(170, 210);
            this.tB_publisher.Name = "tB_publisher";
            this.tB_publisher.Size = new System.Drawing.Size(251, 25);
            this.tB_publisher.TabIndex = 6;
            this.tB_publisher.Text = "Kiadó";
            this.tB_publisher.Enter += new System.EventHandler(this.tB_publisher_Enter);
            this.tB_publisher.Leave += new System.EventHandler(this.tB_publisher_Leave);
            // 
            // label_publisher
            // 
            this.label_publisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_publisher.AutoSize = true;
            this.label_publisher.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_publisher.Location = new System.Drawing.Point(12, 210);
            this.label_publisher.Name = "label_publisher";
            this.label_publisher.Size = new System.Drawing.Size(55, 23);
            this.label_publisher.TabIndex = 21;
            this.label_publisher.Text = "Kiadó";
            // 
            // tB_condition
            // 
            this.tB_condition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_condition.AutoCompleteCustomSource.AddRange(new string[] {
            "Újszerű",
            "Hibátlan",
            "Jó",
            "Közepes"});
            this.tB_condition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tB_condition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tB_condition.BackColor = System.Drawing.SystemColors.Window;
            this.tB_condition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_condition.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_condition.ForeColor = System.Drawing.Color.Gray;
            this.tB_condition.Location = new System.Drawing.Point(170, 242);
            this.tB_condition.Name = "tB_condition";
            this.tB_condition.Size = new System.Drawing.Size(251, 25);
            this.tB_condition.TabIndex = 7;
            this.tB_condition.Text = "Állapot";
            this.tB_condition.Enter += new System.EventHandler(this.tB_condition_Enter);
            this.tB_condition.Leave += new System.EventHandler(this.tB_condition_Leave);
            // 
            // tB_binding
            // 
            this.tB_binding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_binding.AutoCompleteCustomSource.AddRange(new string[] {
            "Puhatáblás",
            "Keménytáblás",
            "Ragasztókötött",
            "Kartonált",
            "Fűzött kemény papír"});
            this.tB_binding.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tB_binding.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tB_binding.BackColor = System.Drawing.SystemColors.Window;
            this.tB_binding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_binding.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_binding.ForeColor = System.Drawing.Color.Gray;
            this.tB_binding.Location = new System.Drawing.Point(170, 274);
            this.tB_binding.Name = "tB_binding";
            this.tB_binding.Size = new System.Drawing.Size(251, 25);
            this.tB_binding.TabIndex = 8;
            this.tB_binding.Text = "Kötés";
            this.tB_binding.Enter += new System.EventHandler(this.tB_binding_Enter);
            this.tB_binding.Leave += new System.EventHandler(this.tB_binding_Leave);
            // 
            // label_binding
            // 
            this.label_binding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_binding.AutoSize = true;
            this.label_binding.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_binding.Location = new System.Drawing.Point(12, 274);
            this.label_binding.Name = "label_binding";
            this.label_binding.Size = new System.Drawing.Size(53, 23);
            this.label_binding.TabIndex = 23;
            this.label_binding.Text = "Kötés";
            // 
            // label_condition
            // 
            this.label_condition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_condition.AutoSize = true;
            this.label_condition.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_condition.Location = new System.Drawing.Point(12, 242);
            this.label_condition.Name = "label_condition";
            this.label_condition.Size = new System.Drawing.Size(67, 23);
            this.label_condition.TabIndex = 22;
            this.label_condition.Text = "Állapot";
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
            this.tB_ID.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_ID.ForeColor = System.Drawing.Color.Gray;
            this.tB_ID.Location = new System.Drawing.Point(170, 492);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.Size = new System.Drawing.Size(251, 25);
            this.tB_ID.TabIndex = 28;
            this.tB_ID.Text = "Könyv ID";
            this.tB_ID.Enter += new System.EventHandler(this.tB_ID_Enter);
            this.tB_ID.Leave += new System.EventHandler(this.tB_ID_Leave);
            // 
            // label_bookID
            // 
            this.label_bookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_bookID.AutoSize = true;
            this.label_bookID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_bookID.Location = new System.Drawing.Point(12, 492);
            this.label_bookID.Name = "label_bookID";
            this.label_bookID.Size = new System.Drawing.Size(136, 23);
            this.label_bookID.TabIndex = 29;
            this.label_bookID.Text = "Könyv azonosító";
            // 
            // label_selling_price
            // 
            this.label_selling_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_selling_price.AutoSize = true;
            this.label_selling_price.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_selling_price.Location = new System.Drawing.Point(12, 370);
            this.label_selling_price.Name = "label_selling_price";
            this.label_selling_price.Size = new System.Drawing.Size(86, 23);
            this.label_selling_price.TabIndex = 26;
            this.label_selling_price.Text = "Eladási ár";
            // 
            // tB_selling_price
            // 
            this.tB_selling_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_selling_price.BackColor = System.Drawing.SystemColors.Window;
            this.tB_selling_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_selling_price.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_selling_price.ForeColor = System.Drawing.Color.Gray;
            this.tB_selling_price.Location = new System.Drawing.Point(170, 370);
            this.tB_selling_price.Name = "tB_selling_price";
            this.tB_selling_price.Size = new System.Drawing.Size(251, 25);
            this.tB_selling_price.TabIndex = 11;
            this.tB_selling_price.Text = "Hozzáadásnál nem kell megadni!";
            this.tB_selling_price.Enter += new System.EventHandler(this.tB_selling_price_Enter);
            this.tB_selling_price.Leave += new System.EventHandler(this.tB_selling_price_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_bookID);
            this.panel1.Controls.Add(this.label_ISBN);
            this.panel1.Controls.Add(this.tB_ID);
            this.panel1.Controls.Add(this.label_author);
            this.panel1.Controls.Add(this.label_condition);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Controls.Add(this.label_binding);
            this.panel1.Controls.Add(this.label_genre);
            this.panel1.Controls.Add(this.tB_binding);
            this.panel1.Controls.Add(this.label_pagenumber);
            this.panel1.Controls.Add(this.tB_condition);
            this.panel1.Controls.Add(this.label_purchase_price);
            this.panel1.Controls.Add(this.label_publisher);
            this.panel1.Controls.Add(this.label_selling_price);
            this.panel1.Controls.Add(this.tB_publisher);
            this.panel1.Controls.Add(this.tB_ISBN);
            this.panel1.Controls.Add(this.label_year);
            this.panel1.Controls.Add(this.tB_author);
            this.panel1.Controls.Add(this.book_delete_button);
            this.panel1.Controls.Add(this.tB_title);
            this.panel1.Controls.Add(this.book_modification_button);
            this.panel1.Controls.Add(this.tB_year);
            this.panel1.Controls.Add(this.new_book_add_button);
            this.panel1.Controls.Add(this.tB_genre);
            this.panel1.Controls.Add(this.display_button);
            this.panel1.Controls.Add(this.tB_pagenumber);
            this.panel1.Controls.Add(this.tB_selling_price);
            this.panel1.Controls.Add(this.tB_purchase_price);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 773);
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
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Könyv kezelő";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_Close_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wishListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource antiqueDBDataSetBindingSource;
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_pagenumber;
        private System.Windows.Forms.Label label_purchase_price;
        private System.Windows.Forms.TextBox tB_ISBN;
        private System.Windows.Forms.TextBox tB_author;
        private System.Windows.Forms.TextBox tB_title;
        private System.Windows.Forms.TextBox tB_year;
        private System.Windows.Forms.TextBox tB_genre;
        private System.Windows.Forms.TextBox tB_pagenumber;
        private System.Windows.Forms.TextBox tB_purchase_price;
        private System.Windows.Forms.Button display_button;
        private System.Windows.Forms.Button new_book_add_button;
        private System.Windows.Forms.Button book_modification_button;
        private System.Windows.Forms.Button book_delete_button;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.TextBox tB_publisher;
        private System.Windows.Forms.Label label_publisher;
        private System.Windows.Forms.TextBox tB_condition;
        private System.Windows.Forms.TextBox tB_binding;
        private System.Windows.Forms.Label label_binding;
        private System.Windows.Forms.Label label_condition;
        private AntiqueDBDataSet antiqueDBDataSet;
        private System.Windows.Forms.BindingSource könyvekBindingSource;
        private AntiqueDBDataSetTableAdapters.KönyvekTableAdapter könyvekTableAdapter;
        private System.Windows.Forms.BindingSource könyvekBindingSource1;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.Label label_bookID;
        private System.Windows.Forms.Label label_selling_price;
        private System.Windows.Forms.TextBox tB_selling_price;
        private System.Windows.Forms.Panel panel1;
    }
}