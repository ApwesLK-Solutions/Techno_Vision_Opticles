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
            this.btn_generate_date_report = new MetroFramework.Controls.MetroTile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_generate_month_report = new MetroFramework.Controls.MetroTile();
            this.txt_select_month_report = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_order_number_report = new MetroFramework.Controls.MetroTextBox();
            this.btn_generate_orderNo_report = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_show_order_list = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_select_date_report
            // 
            this.txt_select_date_report.Location = new System.Drawing.Point(148, 26);
            this.txt_select_date_report.MinimumSize = new System.Drawing.Size(0, 29);
            this.txt_select_date_report.Name = "txt_select_date_report";
            this.txt_select_date_report.Size = new System.Drawing.Size(293, 29);
            this.txt_select_date_report.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(68, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Select Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_generate_date_report);
            this.groupBox1.Controls.Add(this.txt_select_date_report);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Reports";
            // 
            // btn_generate_date_report
            // 
            this.btn_generate_date_report.ActiveControl = null;
            this.btn_generate_date_report.Location = new System.Drawing.Point(459, 21);
            this.btn_generate_date_report.Name = "btn_generate_date_report";
            this.btn_generate_date_report.Size = new System.Drawing.Size(132, 39);
            this.btn_generate_date_report.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_generate_date_report.TabIndex = 4;
            this.btn_generate_date_report.Text = "Generate";
            this.btn_generate_date_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_generate_date_report.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_generate_date_report.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_generate_month_report);
            this.groupBox2.Controls.Add(this.txt_select_month_report);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 74);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monthly Reports";
            // 
            // btn_generate_month_report
            // 
            this.btn_generate_month_report.ActiveControl = null;
            this.btn_generate_month_report.Location = new System.Drawing.Point(459, 21);
            this.btn_generate_month_report.Name = "btn_generate_month_report";
            this.btn_generate_month_report.Size = new System.Drawing.Size(132, 39);
            this.btn_generate_month_report.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_generate_month_report.TabIndex = 4;
            this.btn_generate_month_report.Text = "Generate";
            this.btn_generate_month_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_generate_month_report.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_generate_month_report.UseSelectable = true;
            // 
            // txt_select_month_report
            // 
            this.txt_select_month_report.Location = new System.Drawing.Point(148, 26);
            this.txt_select_month_report.MinimumSize = new System.Drawing.Size(0, 29);
            this.txt_select_month_report.Name = "txt_select_month_report";
            this.txt_select_month_report.Size = new System.Drawing.Size(293, 29);
            this.txt_select_month_report.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(57, 31);
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
            this.groupBox3.Location = new System.Drawing.Point(36, 241);
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
            this.txt_order_number_report.WaterMark = "Enter Order Number";
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
            this.btn_show_order_list.Location = new System.Drawing.Point(36, 324);
            this.btn_show_order_list.Name = "btn_show_order_list";
            this.btn_show_order_list.Size = new System.Drawing.Size(654, 65);
            this.btn_show_order_list.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_show_order_list.TabIndex = 6;
            this.btn_show_order_list.Text = "Show Order List";
            this.btn_show_order_list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_order_list.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_show_order_list.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_show_order_list.UseSelectable = true;
            this.btn_show_order_list.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // frm_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 428);
            this.Controls.Add(this.btn_show_order_list);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_reports";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Reports";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime txt_select_date_report;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile btn_generate_date_report;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile btn_generate_month_report;
        private MetroFramework.Controls.MetroDateTime txt_select_month_report;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile btn_generate_orderNo_report;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_order_number_report;
        private MetroFramework.Controls.MetroTile btn_show_order_list;
    }
}