namespace WindowsFormsApp1
{
    partial class StatementsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.finishDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.bookManagerToolStripMenuItem,
            this.wishListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mainMenuToolStripMenuItem.Text = "Főmenü";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saleToolStripMenuItem.Text = "Eladás";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // regularCustomerToolStripMenuItem
            // 
            this.regularCustomerToolStripMenuItem.Name = "regularCustomerToolStripMenuItem";
            this.regularCustomerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.regularCustomerToolStripMenuItem.Text = "Törzsvásárlók";
            this.regularCustomerToolStripMenuItem.Click += new System.EventHandler(this.regularCustomerToolStripMenuItem_Click);
            // 
            // bookManagerToolStripMenuItem
            // 
            this.bookManagerToolStripMenuItem.Name = "bookManagerToolStripMenuItem";
            this.bookManagerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bookManagerToolStripMenuItem.Text = "Könyv kezelő";
            this.bookManagerToolStripMenuItem.Click += new System.EventHandler(this.bookManagerToolStripMenuItem_Click);
            // 
            // wishListToolStripMenuItem
            // 
            this.wishListToolStripMenuItem.Name = "wishListToolStripMenuItem";
            this.wishListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.wishListToolStripMenuItem.Text = "Kívánság lista";
            this.wishListToolStripMenuItem.Click += new System.EventHandler(this.wishListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Kilépés";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.súgóToolStripMenuItem.Text = "Súgó";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(160, 70);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(233, 22);
            this.startDate.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 360);
            this.dataGridView1.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(541, 281);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.Legend = "Legend1";
            series1.Name = "Kiadás";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series2.Legend = "Legend1";
            series2.Name = "Bevétel";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(453, 360);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // finishDate
            // 
            this.finishDate.Location = new System.Drawing.Point(160, 160);
            this.finishDate.Name = "finishDate";
            this.finishDate.Size = new System.Drawing.Size(233, 22);
            this.finishDate.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(450, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "Teljes kimutatás";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(450, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 50);
            this.button2.TabIndex = 23;
            this.button2.Text = "Bevételek kimutatása";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(450, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 50);
            this.button3.TabIndex = 24;
            this.button3.Text = "Kiadások kimutatása";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kezdő dátum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Befejező dátum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(647, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Adott időszakra vonatkozó adatok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(649, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Összes bevétel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(649, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Összes kiadás";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(649, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Adott időszak nyeresége";
            // 
            // StatementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 653);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finishDate);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatementsForm";
            this.Text = "Kimutatások";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wishListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker finishDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}