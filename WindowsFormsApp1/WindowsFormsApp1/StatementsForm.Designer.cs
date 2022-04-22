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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.antiqueDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.antiqueDBDataSet = new WindowsFormsApp1.AntiqueDBDataSet();
            this.finishDate = new System.Windows.Forms.DateTimePicker();
            this.full_statments_button = new System.Windows.Forms.Button();
            this.revenues_statements_button = new System.Windows.Forms.Button();
            this.costs_statements_button = new System.Windows.Forms.Button();
            this.label_Start = new System.Windows.Forms.Label();
            this.label_Finish = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.label_all_revenues = new System.Windows.Forms.Label();
            this.label_all_costs = new System.Windows.Forms.Label();
            this.label_all_profit = new System.Windows.Forms.Label();
            this.bevételekTableAdapter = new WindowsFormsApp1.AntiqueDBDataSetTableAdapters.BevételekTableAdapter();
            this.label_revenue = new System.Windows.Forms.Label();
            this.label_cost = new System.Windows.Forms.Label();
            this.label_profit = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
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
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
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
            this.wishListToolStripMenuItem,
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
            // wishListToolStripMenuItem
            // 
            this.wishListToolStripMenuItem.Name = "wishListToolStripMenuItem";
            this.wishListToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.wishListToolStripMenuItem.Text = "Kívánság lista";
            this.wishListToolStripMenuItem.Click += new System.EventHandler(this.wishListToolStripMenuItem_Click);
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
            // startDate
            // 
            this.startDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDate.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startDate.Location = new System.Drawing.Point(160, 29);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(233, 25);
            this.startDate.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(763, 31);
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
            this.dataGridView.Size = new System.Drawing.Size(707, 235);
            this.dataGridView.TabIndex = 15;
            // 
            // antiqueDBDataSetBindingSource
            // 
            this.antiqueDBDataSetBindingSource.DataSource = this.antiqueDBDataSet;
            this.antiqueDBDataSetBindingSource.Position = 0;
            // 
            // antiqueDBDataSet
            // 
            this.antiqueDBDataSet.DataSetName = "AntiqueDBDataSet";
            this.antiqueDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finishDate
            // 
            this.finishDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.finishDate.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.finishDate.Location = new System.Drawing.Point(160, 58);
            this.finishDate.Name = "finishDate";
            this.finishDate.Size = new System.Drawing.Size(233, 25);
            this.finishDate.TabIndex = 2;
            // 
            // full_statments_button
            // 
            this.full_statments_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.full_statments_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.full_statments_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.full_statments_button.FlatAppearance.BorderSize = 0;
            this.full_statments_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.full_statments_button.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_statments_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.full_statments_button.Location = new System.Drawing.Point(12, 94);
            this.full_statments_button.Name = "full_statments_button";
            this.full_statments_button.Size = new System.Drawing.Size(174, 50);
            this.full_statments_button.TabIndex = 3;
            this.full_statments_button.Text = "Teljes kimutatás";
            this.full_statments_button.UseVisualStyleBackColor = false;
            this.full_statments_button.Click += new System.EventHandler(this.full_statments_button_Click);
            // 
            // revenues_statements_button
            // 
            this.revenues_statements_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.revenues_statements_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.revenues_statements_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.revenues_statements_button.FlatAppearance.BorderSize = 0;
            this.revenues_statements_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revenues_statements_button.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenues_statements_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.revenues_statements_button.Location = new System.Drawing.Point(192, 94);
            this.revenues_statements_button.Name = "revenues_statements_button";
            this.revenues_statements_button.Size = new System.Drawing.Size(174, 50);
            this.revenues_statements_button.TabIndex = 4;
            this.revenues_statements_button.Text = "Bevételek kimutatása";
            this.revenues_statements_button.UseVisualStyleBackColor = false;
            this.revenues_statements_button.Click += new System.EventHandler(this.revenues_statements_Click);
            // 
            // costs_statements_button
            // 
            this.costs_statements_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costs_statements_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.costs_statements_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.costs_statements_button.FlatAppearance.BorderSize = 0;
            this.costs_statements_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.costs_statements_button.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costs_statements_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.costs_statements_button.Location = new System.Drawing.Point(111, 150);
            this.costs_statements_button.Name = "costs_statements_button";
            this.costs_statements_button.Size = new System.Drawing.Size(174, 50);
            this.costs_statements_button.TabIndex = 5;
            this.costs_statements_button.Text = "Kiadások kimutatása";
            this.costs_statements_button.UseVisualStyleBackColor = false;
            this.costs_statements_button.Click += new System.EventHandler(this.costs_statements_Click);
            // 
            // label_Start
            // 
            this.label_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Start.AutoSize = true;
            this.label_Start.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Start.Location = new System.Drawing.Point(12, 29);
            this.label_Start.Name = "label_Start";
            this.label_Start.Size = new System.Drawing.Size(111, 23);
            this.label_Start.TabIndex = 6;
            this.label_Start.Text = "Kezdő dátum";
            // 
            // label_Finish
            // 
            this.label_Finish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Finish.AutoSize = true;
            this.label_Finish.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Finish.Location = new System.Drawing.Point(12, 58);
            this.label_Finish.Name = "label_Finish";
            this.label_Finish.Size = new System.Drawing.Size(126, 23);
            this.label_Finish.TabIndex = 7;
            this.label_Finish.Text = "Befejező dátum";
            // 
            // label_data
            // 
            this.label_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_data.Location = new System.Drawing.Point(442, 29);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(274, 23);
            this.label_data.TabIndex = 8;
            this.label_data.Text = "Adott időszakra vonatkozó adatok";
            // 
            // label_all_revenues
            // 
            this.label_all_revenues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_all_revenues.AutoSize = true;
            this.label_all_revenues.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_all_revenues.Location = new System.Drawing.Point(442, 79);
            this.label_all_revenues.Name = "label_all_revenues";
            this.label_all_revenues.Size = new System.Drawing.Size(123, 23);
            this.label_all_revenues.TabIndex = 9;
            this.label_all_revenues.Text = "Összes bevétel";
            // 
            // label_all_costs
            // 
            this.label_all_costs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_all_costs.AutoSize = true;
            this.label_all_costs.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_all_costs.Location = new System.Drawing.Point(442, 128);
            this.label_all_costs.Name = "label_all_costs";
            this.label_all_costs.Size = new System.Drawing.Size(120, 23);
            this.label_all_costs.TabIndex = 11;
            this.label_all_costs.Text = "Összes kiadás";
            // 
            // label_all_profit
            // 
            this.label_all_profit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_all_profit.AutoSize = true;
            this.label_all_profit.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_all_profit.Location = new System.Drawing.Point(442, 178);
            this.label_all_profit.Name = "label_all_profit";
            this.label_all_profit.Size = new System.Drawing.Size(196, 23);
            this.label_all_profit.TabIndex = 13;
            this.label_all_profit.Text = "Adott időszak nyeresége";
            // 
            // bevételekTableAdapter
            // 
            this.bevételekTableAdapter.ClearBeforeFill = true;
            // 
            // label_revenue
            // 
            this.label_revenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_revenue.AutoSize = true;
            this.label_revenue.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_revenue.Location = new System.Drawing.Point(666, 77);
            this.label_revenue.Name = "label_revenue";
            this.label_revenue.Size = new System.Drawing.Size(38, 23);
            this.label_revenue.TabIndex = 10;
            this.label_revenue.Text = "0 Ft";
            // 
            // label_cost
            // 
            this.label_cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cost.Location = new System.Drawing.Point(666, 128);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(38, 23);
            this.label_cost.TabIndex = 12;
            this.label_cost.Text = "0 Ft";
            // 
            // label_profit
            // 
            this.label_profit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_profit.AutoSize = true;
            this.label_profit.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_profit.Location = new System.Drawing.Point(666, 178);
            this.label_profit.Name = "label_profit";
            this.label_profit.Size = new System.Drawing.Size(38, 23);
            this.label_profit.TabIndex = 14;
            this.label_profit.Text = "0 Ft";
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.chart.BorderlineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Cursor = System.Windows.Forms.Cursors.No;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(16, 272);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.Legend = "Legend1";
            series1.LegendText = "Kiadások";
            series1.Name = "Costs";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series2.Legend = "Legend1";
            series2.LegendText = "Bevételek";
            series2.Name = "Revenues";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(1454, 519);
            this.chart.TabIndex = 16;
            this.chart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.revenues_statements_button);
            this.panel1.Controls.Add(this.startDate);
            this.panel1.Controls.Add(this.label_profit);
            this.panel1.Controls.Add(this.finishDate);
            this.panel1.Controls.Add(this.label_cost);
            this.panel1.Controls.Add(this.full_statments_button);
            this.panel1.Controls.Add(this.label_revenue);
            this.panel1.Controls.Add(this.costs_statements_button);
            this.panel1.Controls.Add(this.label_all_profit);
            this.panel1.Controls.Add(this.label_Start);
            this.panel1.Controls.Add(this.label_all_costs);
            this.panel1.Controls.Add(this.label_Finish);
            this.panel1.Controls.Add(this.label_all_revenues);
            this.panel1.Controls.Add(this.label_data);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 235);
            this.panel1.TabIndex = 17;
            // 
            // StatementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatementsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kimutatások";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_Close_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiqueDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem wishListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker finishDate;
        private System.Windows.Forms.Button full_statments_button;
        private System.Windows.Forms.Button revenues_statements_button;
        private System.Windows.Forms.Button costs_statements_button;
        private System.Windows.Forms.Label label_Start;
        private System.Windows.Forms.Label label_Finish;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label_all_revenues;
        private System.Windows.Forms.Label label_all_costs;
        private System.Windows.Forms.Label label_all_profit;
        private AntiqueDBDataSet antiqueDBDataSet;
        private AntiqueDBDataSetTableAdapters.BevételekTableAdapter bevételekTableAdapter;
        private System.Windows.Forms.BindingSource antiqueDBDataSetBindingSource;
        private System.Windows.Forms.Label label_revenue;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label_profit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel panel1;
    }
}