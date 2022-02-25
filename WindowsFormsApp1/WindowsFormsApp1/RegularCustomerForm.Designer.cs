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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_born_date = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_phone_number = new System.Windows.Forms.TextBox();
            this.textBox_email_address = new System.Windows.Forms.TextBox();
            this.textBox_torzsvasarloi_kod = new System.Windows.Forms.TextBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.display_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.info_button = new System.Windows.Forms.Button();
            this.antiqueDBDataSet = new WindowsFormsApp1.AntiqueDBDataSet();
            this.törzsvásárlókBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.törzsvásárlókTableAdapter = new WindowsFormsApp1.AntiqueDBDataSetTableAdapters.TörzsvásárlókTableAdapter();
            this.törzsvásárlóiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.névDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.címDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.születésiDátumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonszámDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCímDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktuálisPontokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.előzőÉvesPontokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.törzsvásárlókBindingSource)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Születési dátum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(50, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(50, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cím";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(50, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefonszám";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(50, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email cím";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(777, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Törzsvásrálói kód";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(200, 40);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(240, 22);
            this.textBox_name.TabIndex = 9;
            // 
            // textBox_born_date
            // 
            this.textBox_born_date.Location = new System.Drawing.Point(200, 80);
            this.textBox_born_date.Name = "textBox_born_date";
            this.textBox_born_date.Size = new System.Drawing.Size(240, 22);
            this.textBox_born_date.TabIndex = 10;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(200, 160);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(240, 22);
            this.textBox_address.TabIndex = 12;
            // 
            // textBox_phone_number
            // 
            this.textBox_phone_number.Location = new System.Drawing.Point(200, 200);
            this.textBox_phone_number.Name = "textBox_phone_number";
            this.textBox_phone_number.Size = new System.Drawing.Size(240, 22);
            this.textBox_phone_number.TabIndex = 13;
            // 
            // textBox_email_address
            // 
            this.textBox_email_address.Location = new System.Drawing.Point(200, 240);
            this.textBox_email_address.Name = "textBox_email_address";
            this.textBox_email_address.Size = new System.Drawing.Size(240, 22);
            this.textBox_email_address.TabIndex = 14;
            // 
            // textBox_torzsvasarloi_kod
            // 
            this.textBox_torzsvasarloi_kod.Location = new System.Drawing.Point(728, 168);
            this.textBox_torzsvasarloi_kod.Name = "textBox_torzsvasarloi_kod";
            this.textBox_torzsvasarloi_kod.Size = new System.Drawing.Size(240, 22);
            this.textBox_torzsvasarloi_kod.TabIndex = 15;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Nő",
            "Férfi"});
            this.comboBox_gender.Location = new System.Drawing.Point(200, 120);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(240, 24);
            this.comboBox_gender.TabIndex = 16;
            // 
            // display_button
            // 
            this.display_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.display_button.Location = new System.Drawing.Point(760, 210);
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
            this.button1.Location = new System.Drawing.Point(500, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "Új törzsvásárló regisztrálása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(500, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 50);
            this.button2.TabIndex = 21;
            this.button2.Text = "Törzsvásárlói adatok módosítása";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(500, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 50);
            this.button3.TabIndex = 22;
            this.button3.Text = "Törzsvásárló törlése";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.törzsvásárlóiidDataGridViewTextBoxColumn,
            this.névDataGridViewTextBoxColumn,
            this.címDataGridViewTextBoxColumn,
            this.születésiDátumDataGridViewTextBoxColumn,
            this.telefonszámDataGridViewTextBoxColumn,
            this.emailCímDataGridViewTextBoxColumn,
            this.aktuálisPontokDataGridViewTextBoxColumn,
            this.előzőÉvesPontokDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.törzsvásárlókBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 281);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(982, 360);
            this.dataGridView.TabIndex = 23;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // info_button
            // 
            this.info_button.Location = new System.Drawing.Point(971, 167);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(23, 23);
            this.info_button.TabIndex = 24;
            this.info_button.Text = "I";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // antiqueDBDataSet
            // 
            this.antiqueDBDataSet.DataSetName = "AntiqueDBDataSet";
            this.antiqueDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // törzsvásárlókBindingSource
            // 
            this.törzsvásárlókBindingSource.DataMember = "Törzsvásárlók";
            this.törzsvásárlókBindingSource.DataSource = this.antiqueDBDataSet;
            // 
            // törzsvásárlókTableAdapter
            // 
            this.törzsvásárlókTableAdapter.ClearBeforeFill = true;
            // 
            // törzsvásárlóiidDataGridViewTextBoxColumn
            // 
            this.törzsvásárlóiidDataGridViewTextBoxColumn.DataPropertyName = "Törzsvásárlói_id";
            this.törzsvásárlóiidDataGridViewTextBoxColumn.HeaderText = "Törzsvásárlói_id";
            this.törzsvásárlóiidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.törzsvásárlóiidDataGridViewTextBoxColumn.Name = "törzsvásárlóiidDataGridViewTextBoxColumn";
            this.törzsvásárlóiidDataGridViewTextBoxColumn.Width = 125;
            // 
            // névDataGridViewTextBoxColumn
            // 
            this.névDataGridViewTextBoxColumn.DataPropertyName = "Név";
            this.névDataGridViewTextBoxColumn.HeaderText = "Név";
            this.névDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.névDataGridViewTextBoxColumn.Name = "névDataGridViewTextBoxColumn";
            this.névDataGridViewTextBoxColumn.Width = 125;
            // 
            // címDataGridViewTextBoxColumn
            // 
            this.címDataGridViewTextBoxColumn.DataPropertyName = "Cím";
            this.címDataGridViewTextBoxColumn.HeaderText = "Cím";
            this.címDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.címDataGridViewTextBoxColumn.Name = "címDataGridViewTextBoxColumn";
            this.címDataGridViewTextBoxColumn.Width = 125;
            // 
            // születésiDátumDataGridViewTextBoxColumn
            // 
            this.születésiDátumDataGridViewTextBoxColumn.DataPropertyName = "Születési dátum";
            this.születésiDátumDataGridViewTextBoxColumn.HeaderText = "Születési dátum";
            this.születésiDátumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.születésiDátumDataGridViewTextBoxColumn.Name = "születésiDátumDataGridViewTextBoxColumn";
            this.születésiDátumDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonszámDataGridViewTextBoxColumn
            // 
            this.telefonszámDataGridViewTextBoxColumn.DataPropertyName = "Telefonszám";
            this.telefonszámDataGridViewTextBoxColumn.HeaderText = "Telefonszám";
            this.telefonszámDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonszámDataGridViewTextBoxColumn.Name = "telefonszámDataGridViewTextBoxColumn";
            this.telefonszámDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailCímDataGridViewTextBoxColumn
            // 
            this.emailCímDataGridViewTextBoxColumn.DataPropertyName = "E-mail cím";
            this.emailCímDataGridViewTextBoxColumn.HeaderText = "E-mail cím";
            this.emailCímDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailCímDataGridViewTextBoxColumn.Name = "emailCímDataGridViewTextBoxColumn";
            this.emailCímDataGridViewTextBoxColumn.Width = 125;
            // 
            // aktuálisPontokDataGridViewTextBoxColumn
            // 
            this.aktuálisPontokDataGridViewTextBoxColumn.DataPropertyName = "Aktuális pontok";
            this.aktuálisPontokDataGridViewTextBoxColumn.HeaderText = "Aktuális pontok";
            this.aktuálisPontokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aktuálisPontokDataGridViewTextBoxColumn.Name = "aktuálisPontokDataGridViewTextBoxColumn";
            this.aktuálisPontokDataGridViewTextBoxColumn.Width = 125;
            // 
            // előzőÉvesPontokDataGridViewTextBoxColumn
            // 
            this.előzőÉvesPontokDataGridViewTextBoxColumn.DataPropertyName = "Előző éves pontok";
            this.előzőÉvesPontokDataGridViewTextBoxColumn.HeaderText = "Előző éves pontok";
            this.előzőÉvesPontokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.előzőÉvesPontokDataGridViewTextBoxColumn.Name = "előzőÉvesPontokDataGridViewTextBoxColumn";
            this.előzőÉvesPontokDataGridViewTextBoxColumn.Width = 125;
            // 
            // RegularCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1006, 653);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display_button);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.textBox_torzsvasarloi_kod);
            this.Controls.Add(this.textBox_email_address);
            this.Controls.Add(this.textBox_phone_number);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_born_date);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegularCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Törzsvásárlók";
            this.Load += new System.EventHandler(this.RegularCustomerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.törzsvásárlókBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_born_date;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_phone_number;
        private System.Windows.Forms.TextBox textBox_email_address;
        private System.Windows.Forms.TextBox textBox_torzsvasarloi_kod;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Button display_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button info_button;
        private AntiqueDBDataSet antiqueDBDataSet;
        private System.Windows.Forms.BindingSource törzsvásárlókBindingSource;
        private AntiqueDBDataSetTableAdapters.TörzsvásárlókTableAdapter törzsvásárlókTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn törzsvásárlóiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn névDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn címDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn születésiDátumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonszámDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCímDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktuálisPontokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn előzőÉvesPontokDataGridViewTextBoxColumn;
    }
}