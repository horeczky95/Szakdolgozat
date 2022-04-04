namespace WindowsFormsApp1
{
    partial class MainMenu
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
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regular_customer = new System.Windows.Forms.Button();
            this.book_manager = new System.Windows.Forms.Button();
            this.statments = new System.Windows.Forms.Button();
            this.wish_list = new System.Windows.Forms.Button();
            this.sale = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.könyvekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.antiqueDBDataSet = new WindowsFormsApp1.AntiqueDBDataSet();
            this.könyvekTableAdapter = new WindowsFormsApp1.AntiqueDBDataSetTableAdapters.KönyvekTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.könyvekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).BeginInit();
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
            this.saleToolStripMenuItem,
            this.regularCustomerToolStripMenuItem,
            this.bookManagerToolStripMenuItem,
            this.wishListToolStripMenuItem,
            this.statementsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.saleToolStripMenuItem.Text = "Eladás";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click_1);
            // 
            // regularCustomerToolStripMenuItem
            // 
            this.regularCustomerToolStripMenuItem.Name = "regularCustomerToolStripMenuItem";
            this.regularCustomerToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.regularCustomerToolStripMenuItem.Text = "Törzsvásárlók";
            this.regularCustomerToolStripMenuItem.Click += new System.EventHandler(this.regularCustomerToolStripMenuItem_Click_1);
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
            // regular_customer
            // 
            this.regular_customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regular_customer.AutoSize = true;
            this.regular_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.regular_customer.FlatAppearance.BorderSize = 0;
            this.regular_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regular_customer.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regular_customer.Image = global::WindowsFormsApp1.Properties.Resources.regular_customer;
            this.regular_customer.Location = new System.Drawing.Point(0, 219);
            this.regular_customer.Name = "regular_customer";
            this.regular_customer.Size = new System.Drawing.Size(275, 100);
            this.regular_customer.TabIndex = 2;
            this.regular_customer.Text = "Törzsvásárlók";
            this.regular_customer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.regular_customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.regular_customer.UseVisualStyleBackColor = false;
            this.regular_customer.Click += new System.EventHandler(this.regular_customer_Click);
            // 
            // book_manager
            // 
            this.book_manager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.book_manager.AutoSize = true;
            this.book_manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.book_manager.FlatAppearance.BorderSize = 0;
            this.book_manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_manager.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.book_manager.Image = global::WindowsFormsApp1.Properties.Resources.book_manager;
            this.book_manager.Location = new System.Drawing.Point(0, 338);
            this.book_manager.Name = "book_manager";
            this.book_manager.Size = new System.Drawing.Size(275, 100);
            this.book_manager.TabIndex = 3;
            this.book_manager.Text = "Könyvkezelő";
            this.book_manager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.book_manager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.book_manager.UseVisualStyleBackColor = false;
            this.book_manager.Click += new System.EventHandler(this.book_manager_Click);
            // 
            // statments
            // 
            this.statments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statments.AutoSize = true;
            this.statments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.statments.FlatAppearance.BorderSize = 0;
            this.statments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statments.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statments.Image = global::WindowsFormsApp1.Properties.Resources.statements;
            this.statments.Location = new System.Drawing.Point(0, 576);
            this.statments.Name = "statments";
            this.statments.Size = new System.Drawing.Size(275, 100);
            this.statments.TabIndex = 5;
            this.statments.Text = "Kimutatások";
            this.statments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.statments.UseVisualStyleBackColor = false;
            this.statments.Click += new System.EventHandler(this.statments_Click);
            // 
            // wish_list
            // 
            this.wish_list.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wish_list.AutoSize = true;
            this.wish_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.wish_list.FlatAppearance.BorderSize = 0;
            this.wish_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wish_list.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wish_list.Image = global::WindowsFormsApp1.Properties.Resources.wish_list;
            this.wish_list.Location = new System.Drawing.Point(0, 457);
            this.wish_list.Name = "wish_list";
            this.wish_list.Size = new System.Drawing.Size(275, 100);
            this.wish_list.TabIndex = 4;
            this.wish_list.Text = "Kívánságlista";
            this.wish_list.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.wish_list.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.wish_list.UseVisualStyleBackColor = false;
            this.wish_list.Click += new System.EventHandler(this.wish_list_Click);
            // 
            // sale
            // 
            this.sale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sale.AutoSize = true;
            this.sale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.sale.FlatAppearance.BorderSize = 0;
            this.sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sale.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sale.Image = global::WindowsFormsApp1.Properties.Resources.sale;
            this.sale.Location = new System.Drawing.Point(0, 100);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(275, 100);
            this.sale.TabIndex = 1;
            this.sale.Text = "Eladás";
            this.sale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sale.UseVisualStyleBackColor = false;
            this.sale.Click += new System.EventHandler(this.sale_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.dataGridView1.Location = new System.Drawing.Point(302, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 749);
            this.dataGridView1.TabIndex = 6;
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
            // könyvekTableAdapter
            // 
            this.könyvekTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sale);
            this.panel1.Controls.Add(this.regular_customer);
            this.panel1.Controls.Add(this.book_manager);
            this.panel1.Controls.Add(this.statments);
            this.panel1.Controls.Add(this.wish_list);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 775);
            this.panel1.TabIndex = 7;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.könyvekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wishListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.Button regular_customer;
        private System.Windows.Forms.Button book_manager;
        private System.Windows.Forms.Button statments;
        private System.Windows.Forms.Button wish_list;
        private System.Windows.Forms.Button sale;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AntiqueDBDataSet antiqueDBDataSet;
        private System.Windows.Forms.BindingSource könyvekBindingSource;
        private AntiqueDBDataSetTableAdapters.KönyvekTableAdapter könyvekTableAdapter;
        private System.Windows.Forms.Panel panel1;
    }
}

