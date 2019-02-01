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
            this.btn_lenseSaleDaily = new MetroFramework.Controls.MetroTile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_select_month_report = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_order_number_report = new MetroFramework.Controls.MetroTextBox();
            this.btn_generate_orderNo_report = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_show_order_list = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_specsSaleDaily = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_specSaleMonthly = new MetroFramework.Controls.MetroTile();
            this.btn_lenseSaleMonthly = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_select_date_report
            // 
            this.txt_select_date_report.Location = new System.Drawing.Point(98, 26);
            this.txt_select_date_report.MinimumSize = new System.Drawing.Size(0, 29);
            this.txt_select_date_report.Name = "txt_select_date_report";
            this.txt_select_date_report.Size = new System.Drawing.Size(293, 29);
            this.txt_select_date_report.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(18, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Select Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.txt_select_date_report);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 125);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Reports";
            // 
            // btn_lenseSaleDaily
            // 
            this.btn_lenseSaleDaily.ActiveControl = null;
            this.btn_lenseSaleDaily.Location = new System.Drawing.Point(3, 3);
            this.btn_lenseSaleDaily.Name = "btn_lenseSaleDaily";
            this.btn_lenseSaleDaily.Size = new System.Drawing.Size(148, 39);
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
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.txt_select_month_report);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(448, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 125);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monthly Reports";
            // 
            // txt_select_month_report
            // 
            this.txt_select_month_report.Location = new System.Drawing.Point(115, 26);
            this.txt_select_month_report.MinimumSize = new System.Drawing.Size(0, 29);
            this.txt_select_month_report.Name = "txt_select_month_report";
            this.txt_select_month_report.Size = new System.Drawing.Size(293, 29);
            this.txt_select_month_report.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Select Month";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_order_number_report);
            this.groupBox3.Controls.Add(this.btn_generate_orderNo_report);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(29, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 74);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Re-print Order";
            // 
            // txt_order_number_report
            // 
            // 
            // 
            // 
            this.txt_order_number_report.CustomButton.Image = null;
            this.txt_order_number_report.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.txt_order_number_report.CustomButton.Name = "";
            this.txt_order_number_report.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_order_number_report.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_order_number_report.CustomButton.TabIndex = 1;
            this.txt_order_number_report.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_order_number_report.CustomButton.UseSelectable = true;
            this.txt_order_number_report.CustomButton.Visible = false;
            this.txt_order_number_report.Lines = new string[0];
            this.txt_order_number_report.Location = new System.Drawing.Point(148, 29);
            this.txt_order_number_report.MaxLength = 32767;
            this.txt_order_number_report.Name = "txt_order_number_report";
            this.txt_order_number_report.PasswordChar = '\0';
            this.txt_order_number_report.PromptText = "Enter Order Number";
            this.txt_order_number_report.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_order_number_report.SelectedText = "";
            this.txt_order_number_report.SelectionLength = 0;
            this.txt_order_number_report.SelectionStart = 0;
            this.txt_order_number_report.ShortcutsEnabled = true;
            this.txt_order_number_report.Size = new System.Drawing.Size(293, 23);
            this.txt_order_number_report.TabIndex = 5;
            this.txt_order_number_report.UseSelectable = true;
            this.txt_order_number_report.WaterMark = "Enter Order Number";
            this.txt_order_number_report.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_order_number_report.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_generate_orderNo_report
            // 
            this.btn_generate_orderNo_report.ActiveControl = null;
            this.btn_generate_orderNo_report.Location = new System.Drawing.Point(459, 21);
            this.btn_generate_orderNo_report.Name = "btn_generate_orderNo_report";
            this.btn_generate_orderNo_report.Size = new System.Drawing.Size(132, 39);
            this.btn_generate_orderNo_report.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_generate_orderNo_report.TabIndex = 4;
            this.btn_generate_orderNo_report.Text = "Generate";
            this.btn_generate_orderNo_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_generate_orderNo_report.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_generate_orderNo_report.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(44, 31);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Order Number";
            // 
            // btn_show_order_list
            // 
            this.btn_show_order_list.ActiveControl = null;
            this.btn_show_order_list.Location = new System.Drawing.Point(699, 209);
            this.btn_show_order_list.Name = "btn_show_order_list";
            this.btn_show_order_list.Size = new System.Drawing.Size(171, 74);
            this.btn_show_order_list.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_show_order_list.TabIndex = 6;
            this.btn_show_order_list.Text = "Show Order List";
            this.btn_show_order_list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_order_list.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_show_order_list.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_show_order_list.UseSelectable = true;
            this.btn_show_order_list.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.9697F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.0303F));
            this.tableLayoutPanel1.Controls.Add(this.btn_specsSaleDaily, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_lenseSaleDaily, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 47);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btn_specsSaleDaily
            // 
            this.btn_specsSaleDaily.ActiveControl = null;
            this.btn_specsSaleDaily.Location = new System.Drawing.Point(157, 3);
            this.btn_specsSaleDaily.Name = "btn_specsSaleDaily";
            this.btn_specsSaleDaily.Size = new System.Drawing.Size(169, 39);
            this.btn_specsSaleDaily.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_specsSaleDaily.TabIndex = 5;
            this.btn_specsSaleDaily.Text = "Spectacle Sale Report";
            this.btn_specsSaleDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_specsSaleDaily.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_specsSaleDaily.UseSelectable = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.9697F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.0303F));
            this.tableLayoutPanel2.Controls.Add(this.btn_specSaleMonthly, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_lenseSaleMonthly, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(58, 61);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(330, 47);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btn_specSaleMonthly
            // 
            this.btn_specSaleMonthly.ActiveControl = null;
            this.btn_specSaleMonthly.Location = new System.Drawing.Point(157, 3);
            this.btn_specSaleMonthly.Name = "btn_specSaleMonthly";
            this.btn_specSaleMonthly.Size = new System.Drawing.Size(169, 39);
            this.btn_specSaleMonthly.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_specSaleMonthly.TabIndex = 5;
            this.btn_specSaleMonthly.Text = "Spectacle Sale Report";
            this.btn_specSaleMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_specSaleMonthly.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_specSaleMonthly.UseSelectable = true;
            // 
            // btn_lenseSaleMonthly
            // 
            this.btn_lenseSaleMonthly.ActiveControl = null;
            this.btn_lenseSaleMonthly.Location = new System.Drawing.Point(3, 3);
            this.btn_lenseSaleMonthly.Name = "btn_lenseSaleMonthly";
            this.btn_lenseSaleMonthly.Size = new System.Drawing.Size(148, 39);
            this.btn_lenseSaleMonthly.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_lenseSaleMonthly.TabIndex = 4;
            this.btn_lenseSaleMonthly.Text = "Lense Sale Report";
            this.btn_lenseSaleMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_lenseSaleMonthly.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_lenseSaleMonthly.UseSelectable = true;
            // 
            // frm_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 316);
            this.Controls.Add(this.btn_show_order_list);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_reports";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Reports";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime txt_select_date_report;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile btn_lenseSaleDaily;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroDateTime txt_select_month_report;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile btn_generate_orderNo_report;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_order_number_report;
        private MetroFramework.Controls.MetroTile btn_show_order_list;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile btn_specsSaleDaily;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroTile btn_specSaleMonthly;
        private MetroFramework.Controls.MetroTile btn_lenseSaleMonthly;
    }
}