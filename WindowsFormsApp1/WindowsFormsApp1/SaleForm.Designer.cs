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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.antiqueDBDataSet = new WindowsFormsApp1.AntiqueDBDataSet();
            this.könyvekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.könyvekTableAdapter = new WindowsFormsApp1.AntiqueDBDataSetTableAdapters.KönyvekTableAdapter();
            this.Könyv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szerzőDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.címDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiadásÉveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.műfajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiadóDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eladásiÁrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Állapot = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.mainMenuToolStripMenuItem,
            this.regularCustomerToolStripMenuItem,
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
            // regularCustomerToolStripMenuItem
            // 
            this.regularCustomerToolStripMenuItem.Name = "regularCustomerToolStripMenuItem";
            this.regularCustomerToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.regularCustomerToolStripMenuItem.Text = "Törzsvásárlók";
            this.regularCustomerToolStripMenuItem.Click += new System.EventHandler(this.regularCustomerToolStripMenuItem_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Könyv_id,
            this.iSBNDataGridViewTextBoxColumn,
            this.szerzőDataGridViewTextBoxColumn,
            this.címDataGridViewTextBoxColumn,
            this.kiadásÉveDataGridViewTextBoxColumn,
            this.műfajDataGridViewTextBoxColumn,
            this.kiadóDataGridViewTextBoxColumn,
            this.eladásiÁrDataGridViewTextBoxColumn,
            this.Állapot});
            this.dataGridView1.DataSource = this.könyvekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(564, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 280);
            this.dataGridView1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(564, 319);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 280);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(794, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Végösszeg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(560, 615);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Részösszeg";
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
            // Könyv_id
            // 
            this.Könyv_id.DataPropertyName = "Könyv_id";
            this.Könyv_id.HeaderText = "Könyv_id";
            this.Könyv_id.MinimumWidth = 6;
            this.Könyv_id.Name = "Könyv_id";
            this.Könyv_id.Width = 125;
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
            // eladásiÁrDataGridViewTextBoxColumn
            // 
            this.eladásiÁrDataGridViewTextBoxColumn.DataPropertyName = "Eladási ár";
            this.eladásiÁrDataGridViewTextBoxColumn.HeaderText = "Eladási ár";
            this.eladásiÁrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eladásiÁrDataGridViewTextBoxColumn.Name = "eladásiÁrDataGridViewTextBoxColumn";
            this.eladásiÁrDataGridViewTextBoxColumn.Width = 125;
            // 
            // Állapot
            // 
            this.Állapot.DataPropertyName = "Állapot";
            this.Állapot.HeaderText = "Állapot";
            this.Állapot.MinimumWidth = 6;
            this.Állapot.Name = "Állapot";
            this.Állapot.Width = 125;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaleForm";
            this.Text = "Eladás";
            this.Load += new System.EventHandler(this.SaleForm_Load);
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
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wishListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AntiqueDBDataSet antiqueDBDataSet;
        private System.Windows.Forms.BindingSource könyvekBindingSource;
        private AntiqueDBDataSetTableAdapters.KönyvekTableAdapter könyvekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Könyv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szerzőDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn címDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiadásÉveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn műfajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiadóDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eladásiÁrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Állapot;
    }
}