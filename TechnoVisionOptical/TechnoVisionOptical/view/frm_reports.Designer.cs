namespace TechnoVisionOptical.view
{
    partial class frm_reports
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
            this.txt_select_date_report = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_specsSaleDaily = new MetroFramework.Controls.MetroTile();
            this.btn_lenseSaleDaily = new MetroFramework.Controls.MetroTile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_specSaleMonthly = new MetroFramework.Controls.MetroTile();
            this.btn_lenseSaleMonthly = new MetroFramework.Controls.MetroTile();
            this.txt_from_date = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_show_order_list = new MetroFramework.Controls.MetroTile();
            this.txt_to_date = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_select_date_report
            // 
            this.txt_select_date_report.Location = new System.Drawing.Point(131, 32);
            this.txt_select_date_report.Margin = new System.Windows.Forms.Padding(4);
            this.txt_select_date_report.MinimumSize = new System.Drawing.Size(0, 30);
            this.txt_select_date_report.Name = "txt_select_date_report";
            this.txt_select_date_report.Size = new System.Drawing.Size(389, 30);
            this.txt_select_date_report.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 38);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Select Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.txt_select_date_report);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(551, 154);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Reports";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.9697F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.0303F));
            this.tableLayoutPanel1.Controls.Add(this.btn_specsSaleDaily, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_lenseSaleDaily, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 75);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 58);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btn_specsSaleDaily
            // 
            this.btn_specsSaleDaily.ActiveControl = null;
            this.btn_specsSaleDaily.Location = new System.Drawing.Point(210, 4);
            this.btn_specsSaleDaily.Margin = new System.Windows.Forms.Padding(4);
            this.btn_specsSaleDaily.Name = "btn_specsSaleDaily";
            this.btn_specsSaleDaily.Size = new System.Drawing.Size(225, 48);
            this.btn_specsSaleDaily.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_specsSaleDaily.TabIndex = 5;
            this.btn_specsSaleDaily.Text = "Spectacle Sale Report";
            this.btn_specsSaleDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_specsSaleDaily.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_specsSaleDaily.UseSelectable = true;
            this.btn_specsSaleDaily.Click += new System.EventHandler(this.btn_specsSaleDaily_Click);
            // 
            // btn_lenseSaleDaily
            // 
            this.btn_lenseSaleDaily.ActiveControl = null;
            this.btn_lenseSaleDaily.Location = new System.Drawing.Point(4, 4);
            this.btn_lenseSaleDaily.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lenseSaleDaily.Name = "btn_lenseSaleDaily";
            this.btn_lenseSaleDaily.Size = new System.Drawing.Size(197, 48);
            this.btn_lenseSaleDaily.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_lenseSaleDaily.TabIndex = 4;
            this.btn_lenseSaleDaily.Text = "Lense Sale Report";
            this.btn_lenseSaleDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_lenseSaleDaily.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_lenseSaleDaily.UseSelectable = true;
            this.btn_lenseSaleDaily.Click += new System.EventHandler(this.btn_generate_date_report_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_to_date);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.txt_from_date);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(597, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(563, 154);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monthly Reports";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(300, 38);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(23, 20);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "To";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.9697F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.0303F));
            this.tableLayoutPanel2.Controls.Add(this.btn_specSaleMonthly, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_lenseSaleMonthly, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(77, 75);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(440, 58);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btn_specSaleMonthly
            // 
            this.btn_specSaleMonthly.ActiveControl = null;
            this.btn_specSaleMonthly.Location = new System.Drawing.Point(210, 4);
            this.btn_specSaleMonthly.Margin = new System.Windows.Forms.Padding(4);
            this.btn_specSaleMonthly.Name = "btn_specSaleMonthly";
            this.btn_specSaleMonthly.Size = new System.Drawing.Size(225, 48);
            this.btn_specSaleMonthly.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_specSaleMonthly.TabIndex = 5;
            this.btn_specSaleMonthly.Text = "Spectacle Sale Report";
            this.btn_specSaleMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_specSaleMonthly.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_specSaleMonthly.UseSelectable = true;
            this.btn_specSaleMonthly.Click += new System.EventHandler(this.btn_specSaleMonthly_Click);
            // 
            // btn_lenseSaleMonthly
            // 
            this.btn_lenseSaleMonthly.ActiveControl = null;
            this.btn_lenseSaleMonthly.Location = new System.Drawing.Point(4, 4);
            this.btn_lenseSaleMonthly.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lenseSaleMonthly.Name = "btn_lenseSaleMonthly";
            this.btn_lenseSaleMonthly.Size = new System.Drawing.Size(197, 48);
            this.btn_lenseSaleMonthly.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_lenseSaleMonthly.TabIndex = 4;
            this.btn_lenseSaleMonthly.Text = "Lense Sale Report";
            this.btn_lenseSaleMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_lenseSaleMonthly.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_lenseSaleMonthly.UseSelectable = true;
            this.btn_lenseSaleMonthly.Click += new System.EventHandler(this.btn_lenseSaleMonthly_Click);
            // 
            // txt_from_date
            // 
            this.txt_from_date.Location = new System.Drawing.Point(102, 33);
            this.txt_from_date.Margin = new System.Windows.Forms.Padding(4);
            this.txt_from_date.MinimumSize = new System.Drawing.Size(0, 30);
            this.txt_from_date.Name = "txt_from_date";
            this.txt_from_date.Size = new System.Drawing.Size(197, 30);
            this.txt_from_date.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 38);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "From";
            // 
            // btn_show_order_list
            // 
            this.btn_show_order_list.ActiveControl = null;
            this.btn_show_order_list.Location = new System.Drawing.Point(444, 248);
            this.btn_show_order_list.Margin = new System.Windows.Forms.Padding(4);
            this.btn_show_order_list.Name = "btn_show_order_list";
            this.btn_show_order_list.Size = new System.Drawing.Size(301, 91);
            this.btn_show_order_list.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_show_order_list.TabIndex = 6;
            this.btn_show_order_list.Text = "Show Order List";
            this.btn_show_order_list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_order_list.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_show_order_list.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_show_order_list.UseSelectable = true;
            this.btn_show_order_list.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // txt_to_date
            // 
            this.txt_to_date.Location = new System.Drawing.Point(326, 33);
            this.txt_to_date.Margin = new System.Windows.Forms.Padding(4);
            this.txt_to_date.MinimumSize = new System.Drawing.Size(0, 30);
            this.txt_to_date.Name = "txt_to_date";
            this.txt_to_date.Size = new System.Drawing.Size(197, 30);
            this.txt_to_date.TabIndex = 8;
            // 
            // frm_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 368);
            this.Controls.Add(this.btn_show_order_list);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_reports";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Reports";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime txt_select_date_report;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile btn_lenseSaleDaily;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroDateTime txt_from_date;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btn_show_order_list;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile btn_specsSaleDaily;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroTile btn_specSaleMonthly;
        private MetroFramework.Controls.MetroTile btn_lenseSaleMonthly;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime txt_to_date;
    }
}