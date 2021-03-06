﻿namespace TechnoVisionOptical.view
{
    partial class frm_contactlenses
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_order_no = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_duedate = new MetroFramework.Controls.MetroDateTime();
            this.txt_orderdate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmb_testby = new MetroFramework.Controls.MetroComboBox();
            this.testersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVisionOptical.technovisionDataSet();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txt_lenseRs = new MetroFramework.Controls.MetroTextBox();
            this.txt_advRs = new MetroFramework.Controls.MetroTextBox();
            this.txt_balRs = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.btn_next = new MetroFramework.Controls.MetroTile();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.cmb_pay_method = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.cmb_pay_plan = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmb_jobType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmb_orderStatus = new MetroFramework.Controls.MetroComboBox();
            this.lbl_receiptNo = new MetroFramework.Controls.MetroLabel();
            this.btn_cal = new MetroFramework.Controls.MetroTile();
            this.testersTableAdapter = new TechnoVisionOptical.technovisionDataSetTableAdapters.testersTableAdapter();
            this.testersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(18, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Order No:";
            // 
            // txt_order_no
            // 
            // 
            // 
            // 
            this.txt_order_no.CustomButton.Image = null;
            this.txt_order_no.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txt_order_no.CustomButton.Name = "";
            this.txt_order_no.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_order_no.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_order_no.CustomButton.TabIndex = 1;
            this.txt_order_no.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_order_no.CustomButton.UseSelectable = true;
            this.txt_order_no.CustomButton.Visible = false;
            this.txt_order_no.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_order_no.Lines = new string[0];
            this.txt_order_no.Location = new System.Drawing.Point(105, 76);
            this.txt_order_no.MaxLength = 32767;
            this.txt_order_no.Name = "txt_order_no";
            this.txt_order_no.PasswordChar = '\0';
            this.txt_order_no.PromptText = "Enter Order Number";
            this.txt_order_no.ReadOnly = true;
            this.txt_order_no.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_order_no.SelectedText = "";
            this.txt_order_no.SelectionLength = 0;
            this.txt_order_no.SelectionStart = 0;
            this.txt_order_no.ShortcutsEnabled = true;
            this.txt_order_no.Size = new System.Drawing.Size(238, 29);
            this.txt_order_no.TabIndex = 1;
            this.txt_order_no.UseSelectable = true;
            this.txt_order_no.WaterMark = "Enter Order Number";
            this.txt_order_no.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_order_no.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(18, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Order Date";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 116);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Due Date";
            // 
            // txt_duedate
            // 
            this.txt_duedate.Location = new System.Drawing.Point(105, 111);
            this.txt_duedate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txt_duedate.Name = "txt_duedate";
            this.txt_duedate.Size = new System.Drawing.Size(238, 29);
            this.txt_duedate.TabIndex = 2;
            this.txt_duedate.Value = new System.DateTime(2019, 1, 24, 11, 4, 5, 0);
            // 
            // txt_orderdate
            // 
            this.txt_orderdate.Location = new System.Drawing.Point(105, 146);
            this.txt_orderdate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txt_orderdate.Name = "txt_orderdate";
            this.txt_orderdate.Size = new System.Drawing.Size(238, 29);
            this.txt_orderdate.TabIndex = 3;
            this.txt_orderdate.Value = new System.DateTime(2019, 1, 24, 0, 0, 0, 0);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(18, 186);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 19);
            this.metroLabel7.TabIndex = 20;
            this.metroLabel7.Text = "Tested By";
            // 
            // cmb_testby
            // 
            this.cmb_testby.DataSource = this.testersBindingSource;
            this.cmb_testby.DisplayMember = "name";
            this.cmb_testby.FormattingEnabled = true;
            this.cmb_testby.ItemHeight = 23;
            this.cmb_testby.Location = new System.Drawing.Point(105, 181);
            this.cmb_testby.Name = "cmb_testby";
            this.cmb_testby.PromptText = "Select";
            this.cmb_testby.Size = new System.Drawing.Size(238, 29);
            this.cmb_testby.TabIndex = 4;
            this.cmb_testby.UseSelectable = true;
            this.cmb_testby.ValueMember = "name";
            // 
            // testersBindingSource
            // 
            this.testersBindingSource.DataMember = "testers";
            this.testersBindingSource.DataSource = this.technovisionDataSet;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(357, 79);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(77, 19);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Lenses Total";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(357, 115);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(59, 19);
            this.metroLabel9.TabIndex = 23;
            this.metroLabel9.Text = "Advance";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(357, 151);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(54, 19);
            this.metroLabel13.TabIndex = 24;
            this.metroLabel13.Text = "Balance";
            // 
            // txt_lenseRs
            // 
            // 
            // 
            // 
            this.txt_lenseRs.CustomButton.Image = null;
            this.txt_lenseRs.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txt_lenseRs.CustomButton.Name = "";
            this.txt_lenseRs.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_lenseRs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_lenseRs.CustomButton.TabIndex = 1;
            this.txt_lenseRs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_lenseRs.CustomButton.UseSelectable = true;
            this.txt_lenseRs.CustomButton.Visible = false;
            this.txt_lenseRs.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_lenseRs.Lines = new string[] {
        "0"};
            this.txt_lenseRs.Location = new System.Drawing.Point(464, 74);
            this.txt_lenseRs.MaxLength = 32767;
            this.txt_lenseRs.Name = "txt_lenseRs";
            this.txt_lenseRs.PasswordChar = '\0';
            this.txt_lenseRs.PromptText = "Total Amount";
            this.txt_lenseRs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_lenseRs.SelectedText = "";
            this.txt_lenseRs.SelectionLength = 0;
            this.txt_lenseRs.SelectionStart = 0;
            this.txt_lenseRs.ShortcutsEnabled = true;
            this.txt_lenseRs.Size = new System.Drawing.Size(238, 29);
            this.txt_lenseRs.TabIndex = 7;
            this.txt_lenseRs.Text = "0";
            this.txt_lenseRs.UseSelectable = true;
            this.txt_lenseRs.WaterMark = "Total Amount";
            this.txt_lenseRs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_lenseRs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_lenseRs.TextChanged += new System.EventHandler(this.txt_lenseRs_TextChanged);
            // 
            // txt_advRs
            // 
            // 
            // 
            // 
            this.txt_advRs.CustomButton.Image = null;
            this.txt_advRs.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txt_advRs.CustomButton.Name = "";
            this.txt_advRs.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_advRs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_advRs.CustomButton.TabIndex = 1;
            this.txt_advRs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_advRs.CustomButton.UseSelectable = true;
            this.txt_advRs.CustomButton.Visible = false;
            this.txt_advRs.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_advRs.Lines = new string[] {
        "0"};
            this.txt_advRs.Location = new System.Drawing.Point(464, 108);
            this.txt_advRs.MaxLength = 32767;
            this.txt_advRs.Name = "txt_advRs";
            this.txt_advRs.PasswordChar = '\0';
            this.txt_advRs.PromptText = "Advance Amount";
            this.txt_advRs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_advRs.SelectedText = "";
            this.txt_advRs.SelectionLength = 0;
            this.txt_advRs.SelectionStart = 0;
            this.txt_advRs.ShortcutsEnabled = true;
            this.txt_advRs.Size = new System.Drawing.Size(238, 29);
            this.txt_advRs.TabIndex = 8;
            this.txt_advRs.Text = "0";
            this.txt_advRs.UseSelectable = true;
            this.txt_advRs.WaterMark = "Advance Amount";
            this.txt_advRs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_advRs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_advRs.TextChanged += new System.EventHandler(this.txt_advRs_TextChanged);
            // 
            // txt_balRs
            // 
            // 
            // 
            // 
            this.txt_balRs.CustomButton.Image = null;
            this.txt_balRs.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txt_balRs.CustomButton.Name = "";
            this.txt_balRs.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txt_balRs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_balRs.CustomButton.TabIndex = 1;
            this.txt_balRs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_balRs.CustomButton.UseSelectable = true;
            this.txt_balRs.CustomButton.Visible = false;
            this.txt_balRs.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_balRs.Lines = new string[] {
        "0"};
            this.txt_balRs.Location = new System.Drawing.Point(464, 146);
            this.txt_balRs.MaxLength = 32767;
            this.txt_balRs.Name = "txt_balRs";
            this.txt_balRs.PasswordChar = '\0';
            this.txt_balRs.PromptText = "Balance";
            this.txt_balRs.ReadOnly = true;
            this.txt_balRs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_balRs.SelectedText = "";
            this.txt_balRs.SelectionLength = 0;
            this.txt_balRs.SelectionStart = 0;
            this.txt_balRs.ShortcutsEnabled = true;
            this.txt_balRs.Size = new System.Drawing.Size(211, 31);
            this.txt_balRs.TabIndex = 29;
            this.txt_balRs.Text = "0";
            this.txt_balRs.UseSelectable = true;
            this.txt_balRs.WaterMark = "Balance";
            this.txt_balRs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_balRs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(498, 29);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(77, 19);
            this.metroLabel29.TabIndex = 87;
            this.metroLabel29.Text = "Reciept No:";
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(520, 256);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(85, 45);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.UseStyleColors = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_next
            // 
            this.btn_next.ActiveControl = null;
            this.btn_next.Location = new System.Drawing.Point(617, 256);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(85, 45);
            this.btn_next.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = "Next";
            this.btn_next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_next.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_next.UseSelectable = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(357, 187);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(109, 19);
            this.metroLabel16.TabIndex = 91;
            this.metroLabel16.Text = "Payment Method";
            // 
            // cmb_pay_method
            // 
            this.cmb_pay_method.FormattingEnabled = true;
            this.cmb_pay_method.ItemHeight = 23;
            this.cmb_pay_method.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.cmb_pay_method.Location = new System.Drawing.Point(464, 183);
            this.cmb_pay_method.Name = "cmb_pay_method";
            this.cmb_pay_method.PromptText = "Select";
            this.cmb_pay_method.Size = new System.Drawing.Size(238, 29);
            this.cmb_pay_method.TabIndex = 10;
            this.cmb_pay_method.UseSelectable = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(357, 223);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(88, 19);
            this.metroLabel17.TabIndex = 93;
            this.metroLabel17.Text = "Payment Plan";
            // 
            // cmb_pay_plan
            // 
            this.cmb_pay_plan.FormattingEnabled = true;
            this.cmb_pay_plan.ItemHeight = 23;
            this.cmb_pay_plan.Items.AddRange(new object[] {
            "Full Payment",
            "Advance",
            "Installment"});
            this.cmb_pay_plan.Location = new System.Drawing.Point(464, 217);
            this.cmb_pay_plan.Name = "cmb_pay_plan";
            this.cmb_pay_plan.PromptText = "Select";
            this.cmb_pay_plan.Size = new System.Drawing.Size(238, 29);
            this.cmb_pay_plan.TabIndex = 11;
            this.cmb_pay_plan.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(18, 221);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Job Type";
            // 
            // cmb_jobType
            // 
            this.cmb_jobType.FormattingEnabled = true;
            this.cmb_jobType.ItemHeight = 23;
            this.cmb_jobType.Items.AddRange(new object[] {
            "New ",
            "Replacement"});
            this.cmb_jobType.Location = new System.Drawing.Point(105, 216);
            this.cmb_jobType.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_jobType.Name = "cmb_jobType";
            this.cmb_jobType.PromptText = "Select";
            this.cmb_jobType.Size = new System.Drawing.Size(238, 29);
            this.cmb_jobType.TabIndex = 5;
            this.cmb_jobType.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(18, 256);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Order Status";
            // 
            // cmb_orderStatus
            // 
            this.cmb_orderStatus.FormattingEnabled = true;
            this.cmb_orderStatus.ItemHeight = 23;
            this.cmb_orderStatus.Items.AddRange(new object[] {
            "PENDING ",
            "DELIVERED",
            "CANCELED"});
            this.cmb_orderStatus.Location = new System.Drawing.Point(105, 251);
            this.cmb_orderStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_orderStatus.Name = "cmb_orderStatus";
            this.cmb_orderStatus.PromptText = "Select";
            this.cmb_orderStatus.Size = new System.Drawing.Size(238, 29);
            this.cmb_orderStatus.TabIndex = 6;
            this.cmb_orderStatus.UseSelectable = true;
            // 
            // lbl_receiptNo
            // 
            this.lbl_receiptNo.AutoSize = true;
            this.lbl_receiptNo.Location = new System.Drawing.Point(565, 29);
            this.lbl_receiptNo.Name = "lbl_receiptNo";
            this.lbl_receiptNo.Size = new System.Drawing.Size(53, 19);
            this.lbl_receiptNo.TabIndex = 87;
            this.lbl_receiptNo.Text = "Rxxxxxx";
            // 
            // btn_cal
            // 
            this.btn_cal.ActiveControl = null;
            this.btn_cal.Location = new System.Drawing.Point(671, 145);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(30, 33);
            this.btn_cal.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_cal.TabIndex = 9;
            this.btn_cal.TileImage = global::TechnoVisionOptical.Properties.Resources.Webp_net_resizeimage__1_;
            this.btn_cal.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cal.UseSelectable = true;
            this.btn_cal.UseTileImage = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // testersTableAdapter
            // 
            this.testersTableAdapter.ClearBeforeFill = true;
            // 
            // testersBindingSource1
            // 
            this.testersBindingSource1.DataMember = "testers";
            this.testersBindingSource1.DataSource = this.technovisionDataSet;
            // 
            // frm_contactlenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 318);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.cmb_pay_plan);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.cmb_pay_method);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_receiptNo);
            this.Controls.Add(this.metroLabel29);
            this.Controls.Add(this.txt_balRs);
            this.Controls.Add(this.txt_advRs);
            this.Controls.Add(this.txt_lenseRs);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.cmb_orderStatus);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmb_jobType);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cmb_testby);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txt_orderdate);
            this.Controls.Add(this.txt_duedate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_order_no);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_contactlenses";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Contact Lenses";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_contactlenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_order_no;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime txt_duedate;
        private MetroFramework.Controls.MetroDateTime txt_orderdate;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cmb_testby;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txt_lenseRs;
        private MetroFramework.Controls.MetroTextBox txt_advRs;
        private MetroFramework.Controls.MetroTextBox txt_balRs;
        private MetroFramework.Controls.MetroLabel metroLabel30;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroTile btn_clear;
        private MetroFramework.Controls.MetroTile btn_next;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroComboBox cmb_pay_method;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroComboBox cmb_pay_plan;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmb_jobType;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmb_orderStatus;
        private MetroFramework.Controls.MetroLabel lbl_receiptNo;
        private MetroFramework.Controls.MetroTile btn_cal;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource testersBindingSource;
        private technovisionDataSetTableAdapters.testersTableAdapter testersTableAdapter;
        private System.Windows.Forms.BindingSource testersBindingSource1;
    }
}