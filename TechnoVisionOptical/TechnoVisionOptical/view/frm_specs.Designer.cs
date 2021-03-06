﻿namespace TechnoVisionOptical.view
{
    partial class frm_specs
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
            this.cmb_pay_plan = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.cmb_pay_method = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.lbl_receiptNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.cmb_testedby = new MetroFramework.Controls.MetroComboBox();
            this.testersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVisionOptical.technovisionDataSet();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_orderdate = new MetroFramework.Controls.MetroDateTime();
            this.txt_duedate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_order = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txt_total = new MetroFramework.Controls.MetroTextBox();
            this.txt_lenses = new MetroFramework.Controls.MetroTextBox();
            this.txt_eyeWear = new MetroFramework.Controls.MetroTextBox();
            this.txt_balance = new MetroFramework.Controls.MetroTextBox();
            this.txt_discount = new MetroFramework.Controls.MetroTextBox();
            this.txt_advance = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.btn_next = new MetroFramework.Controls.MetroTile();
            this.btn_clearall = new MetroFramework.Controls.MetroTile();
            this.cmb_orderStatus = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.testersTableAdapter = new TechnoVisionOptical.technovisionDataSetTableAdapters.testersTableAdapter();
            this.btn_calculate = new MetroFramework.Controls.MetroTile();
            this.calc_total = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_pay_plan
            // 
            this.cmb_pay_plan.FormattingEnabled = true;
            this.cmb_pay_plan.ItemHeight = 23;
            this.cmb_pay_plan.Items.AddRange(new object[] {
            "Advance",
            "Installment",
            "Full Amount"});
            this.cmb_pay_plan.Location = new System.Drawing.Point(167, 148);
            this.cmb_pay_plan.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_pay_plan.Name = "cmb_pay_plan";
            this.cmb_pay_plan.PromptText = "Select";
            this.cmb_pay_plan.Size = new System.Drawing.Size(180, 29);
            this.cmb_pay_plan.TabIndex = 3;
            this.cmb_pay_plan.UseSelectable = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(21, 153);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(88, 19);
            this.metroLabel17.TabIndex = 119;
            this.metroLabel17.Text = "Payment Plan";
            // 
            // cmb_pay_method
            // 
            this.cmb_pay_method.FormattingEnabled = true;
            this.cmb_pay_method.ItemHeight = 23;
            this.cmb_pay_method.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.cmb_pay_method.Location = new System.Drawing.Point(527, 113);
            this.cmb_pay_method.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_pay_method.Name = "cmb_pay_method";
            this.cmb_pay_method.PromptText = "Select";
            this.cmb_pay_method.Size = new System.Drawing.Size(180, 29);
            this.cmb_pay_method.TabIndex = 9;
            this.cmb_pay_method.UseSelectable = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(371, 118);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(109, 19);
            this.metroLabel16.TabIndex = 117;
            this.metroLabel16.Text = "Payment Method";
            // 
            // lbl_receiptNo
            // 
            this.lbl_receiptNo.AutoSize = true;
            this.lbl_receiptNo.Location = new System.Drawing.Point(575, 29);
            this.lbl_receiptNo.Name = "lbl_receiptNo";
            this.lbl_receiptNo.Size = new System.Drawing.Size(77, 19);
            this.lbl_receiptNo.TabIndex = 116;
            this.lbl_receiptNo.Text = "R+orderNo";
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(500, 29);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(77, 19);
            this.metroLabel29.TabIndex = 115;
            this.metroLabel29.Text = "Reciept No:";
            // 
            // cmb_testedby
            // 
            this.cmb_testedby.DataSource = this.testersBindingSource;
            this.cmb_testedby.DisplayMember = "name";
            this.cmb_testedby.FormattingEnabled = true;
            this.cmb_testedby.ItemHeight = 23;
            this.cmb_testedby.Location = new System.Drawing.Point(527, 149);
            this.cmb_testedby.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_testedby.Name = "cmb_testedby";
            this.cmb_testedby.PromptText = "Select";
            this.cmb_testedby.Size = new System.Drawing.Size(180, 29);
            this.cmb_testedby.TabIndex = 10;
            this.cmb_testedby.UseSelectable = true;
            this.cmb_testedby.ValueMember = "name";
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
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(371, 154);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 19);
            this.metroLabel7.TabIndex = 113;
            this.metroLabel7.Text = "Tested By";
            // 
            // txt_orderdate
            // 
            this.txt_orderdate.Location = new System.Drawing.Point(469, 76);
            this.txt_orderdate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txt_orderdate.Name = "txt_orderdate";
            this.txt_orderdate.Size = new System.Drawing.Size(238, 29);
            this.txt_orderdate.TabIndex = 8;
            this.txt_orderdate.Value = new System.DateTime(2019, 1, 13, 16, 24, 37, 0);
            // 
            // txt_duedate
            // 
            this.txt_duedate.Location = new System.Drawing.Point(108, 112);
            this.txt_duedate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_duedate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txt_duedate.Name = "txt_duedate";
            this.txt_duedate.Size = new System.Drawing.Size(239, 29);
            this.txt_duedate.TabIndex = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 98;
            this.metroLabel3.Text = "Due Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(371, 82);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 97;
            this.metroLabel2.Text = "Order Date";
            // 
            // txt_order
            // 
            // 
            // 
            // 
            this.txt_order.CustomButton.Image = null;
            this.txt_order.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txt_order.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_order.CustomButton.Name = "";
            this.txt_order.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_order.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_order.CustomButton.TabIndex = 1;
            this.txt_order.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_order.CustomButton.UseSelectable = true;
            this.txt_order.CustomButton.Visible = false;
            this.txt_order.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_order.Lines = new string[0];
            this.txt_order.Location = new System.Drawing.Point(109, 76);
            this.txt_order.MaxLength = 32767;
            this.txt_order.Name = "txt_order";
            this.txt_order.PasswordChar = '\0';
            this.txt_order.PromptText = "Enter Oder Number";
            this.txt_order.ReadOnly = true;
            this.txt_order.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_order.SelectedText = "";
            this.txt_order.SelectionLength = 0;
            this.txt_order.SelectionStart = 0;
            this.txt_order.ShortcutsEnabled = true;
            this.txt_order.Size = new System.Drawing.Size(238, 29);
            this.txt_order.TabIndex = 1;
            this.txt_order.UseSelectable = true;
            this.txt_order.WaterMark = "Enter Oder Number";
            this.txt_order.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_order.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(21, 81);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(70, 19);
            this.metroLabel8.TabIndex = 95;
            this.metroLabel8.Text = "Order No:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 189);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 121;
            this.metroLabel1.Text = "Eye Wear";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(21, 225);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(46, 19);
            this.metroLabel9.TabIndex = 122;
            this.metroLabel9.Text = "Lenses";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(21, 261);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(36, 19);
            this.metroLabel13.TabIndex = 123;
            this.metroLabel13.Text = "Total";
            // 
            // txt_total
            // 
            // 
            // 
            // 
            this.txt_total.CustomButton.Image = null;
            this.txt_total.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txt_total.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_total.CustomButton.Name = "";
            this.txt_total.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_total.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_total.CustomButton.TabIndex = 1;
            this.txt_total.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_total.CustomButton.UseSelectable = true;
            this.txt_total.CustomButton.Visible = false;
            this.txt_total.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_total.Lines = new string[] {
        "0"};
            this.txt_total.Location = new System.Drawing.Point(109, 256);
            this.txt_total.Margin = new System.Windows.Forms.Padding(2);
            this.txt_total.MaxLength = 32767;
            this.txt_total.Name = "txt_total";
            this.txt_total.PasswordChar = '\0';
            this.txt_total.ReadOnly = true;
            this.txt_total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_total.SelectedText = "";
            this.txt_total.SelectionLength = 0;
            this.txt_total.SelectionStart = 0;
            this.txt_total.ShortcutsEnabled = true;
            this.txt_total.Size = new System.Drawing.Size(212, 29);
            this.txt_total.TabIndex = 100;
            this.txt_total.Text = "0";
            this.txt_total.UseSelectable = true;
            this.txt_total.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_total.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_lenses
            // 
            // 
            // 
            // 
            this.txt_lenses.CustomButton.Image = null;
            this.txt_lenses.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txt_lenses.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_lenses.CustomButton.Name = "";
            this.txt_lenses.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_lenses.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_lenses.CustomButton.TabIndex = 1;
            this.txt_lenses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_lenses.CustomButton.UseSelectable = true;
            this.txt_lenses.CustomButton.Visible = false;
            this.txt_lenses.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_lenses.Lines = new string[] {
        "0"};
            this.txt_lenses.Location = new System.Drawing.Point(109, 220);
            this.txt_lenses.MaxLength = 32767;
            this.txt_lenses.Name = "txt_lenses";
            this.txt_lenses.PasswordChar = '\0';
            this.txt_lenses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_lenses.SelectedText = "";
            this.txt_lenses.SelectionLength = 0;
            this.txt_lenses.SelectionStart = 0;
            this.txt_lenses.ShortcutsEnabled = true;
            this.txt_lenses.Size = new System.Drawing.Size(238, 29);
            this.txt_lenses.TabIndex = 5;
            this.txt_lenses.Text = "0";
            this.txt_lenses.UseSelectable = true;
            this.txt_lenses.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_lenses.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_lenses.TextChanged += new System.EventHandler(this.txt_lenses_TextChanged);
            // 
            // txt_eyeWear
            // 
            // 
            // 
            // 
            this.txt_eyeWear.CustomButton.Image = null;
            this.txt_eyeWear.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txt_eyeWear.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_eyeWear.CustomButton.Name = "";
            this.txt_eyeWear.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_eyeWear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_eyeWear.CustomButton.TabIndex = 1;
            this.txt_eyeWear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_eyeWear.CustomButton.UseSelectable = true;
            this.txt_eyeWear.CustomButton.Visible = false;
            this.txt_eyeWear.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_eyeWear.Lines = new string[] {
        "0"};
            this.txt_eyeWear.Location = new System.Drawing.Point(109, 184);
            this.txt_eyeWear.MaxLength = 32767;
            this.txt_eyeWear.Name = "txt_eyeWear";
            this.txt_eyeWear.PasswordChar = '\0';
            this.txt_eyeWear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_eyeWear.SelectedText = "";
            this.txt_eyeWear.SelectionLength = 0;
            this.txt_eyeWear.SelectionStart = 0;
            this.txt_eyeWear.ShortcutsEnabled = true;
            this.txt_eyeWear.Size = new System.Drawing.Size(238, 29);
            this.txt_eyeWear.TabIndex = 4;
            this.txt_eyeWear.Text = "0";
            this.txt_eyeWear.UseSelectable = true;
            this.txt_eyeWear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_eyeWear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_eyeWear.TextChanged += new System.EventHandler(this.txt_eyeWear_TextChanged);
            // 
            // txt_balance
            // 
            // 
            // 
            // 
            this.txt_balance.CustomButton.Image = null;
            this.txt_balance.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txt_balance.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_balance.CustomButton.Name = "";
            this.txt_balance.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_balance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_balance.CustomButton.TabIndex = 1;
            this.txt_balance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_balance.CustomButton.UseSelectable = true;
            this.txt_balance.CustomButton.Visible = false;
            this.txt_balance.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_balance.Lines = new string[] {
        "0"};
            this.txt_balance.Location = new System.Drawing.Point(469, 257);
            this.txt_balance.MaxLength = 32767;
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.PasswordChar = '\0';
            this.txt_balance.ReadOnly = true;
            this.txt_balance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_balance.SelectedText = "";
            this.txt_balance.SelectionLength = 0;
            this.txt_balance.SelectionStart = 0;
            this.txt_balance.ShortcutsEnabled = true;
            this.txt_balance.Size = new System.Drawing.Size(212, 29);
            this.txt_balance.TabIndex = 101;
            this.txt_balance.Text = "0";
            this.txt_balance.UseSelectable = true;
            this.txt_balance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_balance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_discount
            // 
            // 
            // 
            // 
            this.txt_discount.CustomButton.Image = null;
            this.txt_discount.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txt_discount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_discount.CustomButton.Name = "";
            this.txt_discount.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_discount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_discount.CustomButton.TabIndex = 1;
            this.txt_discount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_discount.CustomButton.UseSelectable = true;
            this.txt_discount.CustomButton.Visible = false;
            this.txt_discount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_discount.Lines = new string[] {
        "0"};
            this.txt_discount.Location = new System.Drawing.Point(469, 221);
            this.txt_discount.MaxLength = 32767;
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.PasswordChar = '\0';
            this.txt_discount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_discount.SelectedText = "";
            this.txt_discount.SelectionLength = 0;
            this.txt_discount.SelectionStart = 0;
            this.txt_discount.ShortcutsEnabled = true;
            this.txt_discount.Size = new System.Drawing.Size(238, 29);
            this.txt_discount.TabIndex = 12;
            this.txt_discount.Text = "0";
            this.txt_discount.UseSelectable = true;
            this.txt_discount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_discount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            // 
            // txt_advance
            // 
            // 
            // 
            // 
            this.txt_advance.CustomButton.Image = null;
            this.txt_advance.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txt_advance.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_advance.CustomButton.Name = "";
            this.txt_advance.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_advance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_advance.CustomButton.TabIndex = 1;
            this.txt_advance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_advance.CustomButton.UseSelectable = true;
            this.txt_advance.CustomButton.Visible = false;
            this.txt_advance.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_advance.Lines = new string[] {
        "0"};
            this.txt_advance.Location = new System.Drawing.Point(469, 185);
            this.txt_advance.MaxLength = 32767;
            this.txt_advance.Name = "txt_advance";
            this.txt_advance.PasswordChar = '\0';
            this.txt_advance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_advance.SelectedText = "";
            this.txt_advance.SelectionLength = 0;
            this.txt_advance.SelectionStart = 0;
            this.txt_advance.ShortcutsEnabled = true;
            this.txt_advance.Size = new System.Drawing.Size(238, 29);
            this.txt_advance.TabIndex = 11;
            this.txt_advance.Text = "0";
            this.txt_advance.UseSelectable = true;
            this.txt_advance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_advance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_advance.TextChanged += new System.EventHandler(this.txt_advance_TextChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(371, 262);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(54, 19);
            this.metroLabel14.TabIndex = 129;
            this.metroLabel14.Text = "Balance";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(371, 226);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(58, 19);
            this.metroLabel15.TabIndex = 128;
            this.metroLabel15.Text = "Discount";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(371, 190);
            this.metroLabel18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(59, 19);
            this.metroLabel18.TabIndex = 127;
            this.metroLabel18.Text = "Advance";
            // 
            // btn_next
            // 
            this.btn_next.ActiveControl = null;
            this.btn_next.Location = new System.Drawing.Point(622, 293);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(85, 45);
            this.btn_next.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_next.TabIndex = 14;
            this.btn_next.Text = "Next";
            this.btn_next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_next.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_next.UseSelectable = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_clearall
            // 
            this.btn_clearall.ActiveControl = null;
            this.btn_clearall.Location = new System.Drawing.Point(532, 293);
            this.btn_clearall.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clearall.Name = "btn_clearall";
            this.btn_clearall.Size = new System.Drawing.Size(85, 45);
            this.btn_clearall.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_clearall.TabIndex = 15;
            this.btn_clearall.Text = "Clear All";
            this.btn_clearall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clearall.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clearall.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_clearall.UseSelectable = true;
            this.btn_clearall.Click += new System.EventHandler(this.btn_clearall_Click);
            // 
            // cmb_orderStatus
            // 
            this.cmb_orderStatus.FormattingEnabled = true;
            this.cmb_orderStatus.ItemHeight = 23;
            this.cmb_orderStatus.Items.AddRange(new object[] {
            "PENDING ",
            "DELIVERED",
            "CANCELED"});
            this.cmb_orderStatus.Location = new System.Drawing.Point(108, 292);
            this.cmb_orderStatus.Name = "cmb_orderStatus";
            this.cmb_orderStatus.PromptText = "Select";
            this.cmb_orderStatus.Size = new System.Drawing.Size(239, 29);
            this.cmb_orderStatus.TabIndex = 7;
            this.cmb_orderStatus.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 297);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 19);
            this.metroLabel5.TabIndex = 135;
            this.metroLabel5.Text = "Order Status";
            // 
            // testersTableAdapter
            // 
            this.testersTableAdapter.ClearBeforeFill = true;
            // 
            // btn_calculate
            // 
            this.btn_calculate.ActiveControl = null;
            this.btn_calculate.Location = new System.Drawing.Point(677, 256);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(30, 30);
            this.btn_calculate.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_calculate.TabIndex = 13;
            this.btn_calculate.TileImage = global::TechnoVisionOptical.Properties.Resources.Webp_net_resizeimage__1_;
            this.btn_calculate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_calculate.UseSelectable = true;
            this.btn_calculate.UseTileImage = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // calc_total
            // 
            this.calc_total.ActiveControl = null;
            this.calc_total.Location = new System.Drawing.Point(317, 255);
            this.calc_total.Name = "calc_total";
            this.calc_total.Size = new System.Drawing.Size(30, 30);
            this.calc_total.Style = MetroFramework.MetroColorStyle.Green;
            this.calc_total.TabIndex = 6;
            this.calc_total.TileImage = global::TechnoVisionOptical.Properties.Resources.Webp_net_resizeimage__1_;
            this.calc_total.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.calc_total.UseSelectable = true;
            this.calc_total.UseTileImage = true;
            this.calc_total.Click += new System.EventHandler(this.calc_total_Click);
            // 
            // frm_specs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 350);
            this.Controls.Add(this.calc_total);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.cmb_orderStatus);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btn_clearall);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_advance);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_lenses);
            this.Controls.Add(this.txt_eyeWear);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmb_pay_plan);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.cmb_pay_method);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.lbl_receiptNo);
            this.Controls.Add(this.metroLabel29);
            this.Controls.Add(this.cmb_testedby);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txt_orderdate);
            this.Controls.Add(this.txt_duedate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_order);
            this.Controls.Add(this.metroLabel8);
            this.MaximizeBox = false;
            this.Name = "frm_specs";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Spectacles";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_specs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmb_pay_plan;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroComboBox cmb_pay_method;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel lbl_receiptNo;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroComboBox cmb_testedby;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime txt_orderdate;
        private MetroFramework.Controls.MetroDateTime txt_duedate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_order;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txt_total;
        private MetroFramework.Controls.MetroTextBox txt_lenses;
        private MetroFramework.Controls.MetroTextBox txt_eyeWear;
        private MetroFramework.Controls.MetroTextBox txt_balance;
        private MetroFramework.Controls.MetroTextBox txt_discount;
        private MetroFramework.Controls.MetroTextBox txt_advance;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTile btn_next;
        private MetroFramework.Controls.MetroTile btn_clearall;
        private MetroFramework.Controls.MetroComboBox cmb_orderStatus;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource testersBindingSource;
        private technovisionDataSetTableAdapters.testersTableAdapter testersTableAdapter;
        private MetroFramework.Controls.MetroTile btn_calculate;
        private MetroFramework.Controls.MetroTile calc_total;
    }
}