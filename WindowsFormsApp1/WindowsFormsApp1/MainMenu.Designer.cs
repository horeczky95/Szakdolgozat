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
            this.antiqueDBDataSet = new WindowsFormsApp1.AntiqueDBDataSet();
            this.könyvekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.könyvekTableAdapter = new WindowsFormsApp1.AntiqueDBDataSetTableAdapters.KönyvekTableAdapter();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szerzőDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.címDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.műfajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiadásÉveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.regular_customer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.regular_customer.AutoSize = true;
            this.regular_customer.BackColor = System.Drawing.Color.Salmon;
            this.regular_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regular_customer.Location = new System.Drawing.Point(30, 160);
            this.regular_customer.Name = "regular_customer";
            this.regular_customer.Size = new System.Drawing.Size(230, 100);
            this.regular_customer.TabIndex = 2;
            this.regular_customer.Text = "Törzsvásárlók";
            this.regular_customer.UseVisualStyleBackColor = false;
            this.regular_customer.Click += new System.EventHandler(this.regular_customer_Click);
            // 
            // book_manager
            // 
            this.book_manager.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.book_manager.AutoSize = true;
            this.book_manager.BackColor = System.Drawing.Color.Salmon;
            this.book_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.book_manager.Location = new System.Drawing.Point(30, 280);
            this.book_manager.Name = "book_manager";
            this.book_manager.Size = new System.Drawing.Size(230, 100);
            this.book_manager.TabIndex = 3;
            this.book_manager.Text = "Könyv kezelő";
            this.book_manager.UseVisualStyleBackColor = false;
            this.book_manager.Click += new System.EventHandler(this.book_manager_Click);
            // 
            // statments
            // 
            this.statments.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statments.AutoSize = true;
            this.statments.BackColor = System.Drawing.Color.Salmon;
            this.statments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statments.Location = new System.Drawing.Point(30, 520);
            this.statments.Name = "statments";
            this.statments.Size = new System.Drawing.Size(230, 100);
            this.statments.TabIndex = 5;
            this.statments.Text = "Kimutatások";
            this.statments.UseVisualStyleBackColor = false;
            this.statments.Click += new System.EventHandler(this.statments_Click);
            // 
            // wish_list
            // 
            this.wish_list.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wish_list.AutoSize = true;
            this.wish_list.BackColor = System.Drawing.Color.Salmon;
            this.wish_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wish_list.Location = new System.Drawing.Point(30, 400);
            this.wish_list.Name = "wish_list";
            this.wish_list.Size = new System.Drawing.Size(230, 100);
            this.wish_list.TabIndex = 4;
            this.wish_list.Text = "Kívánság lista";
            this.wish_list.UseVisualStyleBackColor = false;
            this.wish_list.Click += new System.EventHandler(this.wish_list_Click);
            // 
            // sale
            // 
            this.sale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sale.AutoSize = true;
            this.sale.BackColor = System.Drawing.Color.Salmon;
            this.sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sale.Location = new System.Drawing.Point(30, 40);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(230, 100);
            this.sale.TabIndex = 1;
            this.sale.Text = "Eladás";
            this.sale.UseVisualStyleBackColor = false;
            this.sale.Click += new System.EventHandler(this.sale_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.szerzőDataGridViewTextBoxColumn,
            this.címDataGridViewTextBoxColumn,
            this.műfajDataGridViewTextBoxColumn,
            this.kiadásÉveDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.könyvekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(296, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 599);
            this.dataGridView1.TabIndex = 6;
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
            // műfajDataGridViewTextBoxColumn
            // 
            this.műfajDataGridViewTextBoxColumn.DataPropertyName = "Műfaj";
            this.műfajDataGridViewTextBoxColumn.HeaderText = "Műfaj";
            this.műfajDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.műfajDataGridViewTextBoxColumn.Name = "műfajDataGridViewTextBoxColumn";
            this.műfajDataGridViewTextBoxColumn.Width = 125;
            // 
            // kiadásÉveDataGridViewTextBoxColumn
            // 
            this.kiadásÉveDataGridViewTextBoxColumn.DataPropertyName = "Kiadás éve";
            this.kiadásÉveDataGridViewTextBoxColumn.HeaderText = "Kiadás éve";
            this.kiadásÉveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kiadásÉveDataGridViewTextBoxColumn.Name = "kiadásÉveDataGridViewTextBoxColumn";
            this.kiadásÉveDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1006, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sale);
            this.Controls.Add(this.statments);
            this.Controls.Add(this.wish_list);
            this.Controls.Add(this.book_manager);
            this.Controls.Add(this.regular_customer);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.könyvekBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szerzőDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn címDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn műfajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiadásÉveDataGridViewTextBoxColumn;
    }
}

