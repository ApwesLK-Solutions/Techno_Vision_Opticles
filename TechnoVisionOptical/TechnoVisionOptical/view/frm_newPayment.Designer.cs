﻿namespace TechnoVisionOptical.view
{
    partial class frm_newPayment
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btn_pay = new MetroFramework.Controls.MetroTile();
            this.Txt_orderNum = new MetroFramework.Controls.MetroTextBox();
            this.txt_receiptNumber = new MetroFramework.Controls.MetroTextBox();
            this.txt_dueAmount = new MetroFramework.Controls.MetroTextBox();
            this.txt_amount = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieptnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVisionOptical.technovisionDataSet();
            this.paymentsTableAdapter = new TechnoVisionOptical.technovisionDataSetTableAdapters.paymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(19, 68);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(67, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Order No";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 129);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Due Amount";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(19, 158);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(56, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Amount";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(19, 98);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(105, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Receipt Number";
            // 
            // btn_pay
            // 
            this.btn_pay.ActiveControl = null;
            this.btn_pay.Location = new System.Drawing.Point(199, 195);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(127, 45);
            this.btn_pay.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_pay.TabIndex = 5;
            this.btn_pay.Text = "Add Payment";
            this.btn_pay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pay.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_pay.UseSelectable = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // Txt_orderNum
            // 
            // 
            // 
            // 
            this.Txt_orderNum.CustomButton.Image = null;
            this.Txt_orderNum.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.Txt_orderNum.CustomButton.Name = "";
            this.Txt_orderNum.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.Txt_orderNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_orderNum.CustomButton.TabIndex = 1;
            this.Txt_orderNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_orderNum.CustomButton.UseSelectable = true;
            this.Txt_orderNum.CustomButton.Visible = false;
            this.Txt_orderNum.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Txt_orderNum.Lines = new string[0];
            this.Txt_orderNum.Location = new System.Drawing.Point(161, 66);
            this.Txt_orderNum.MaxLength = 32767;
            this.Txt_orderNum.Name = "Txt_orderNum";
            this.Txt_orderNum.PasswordChar = '\0';
            this.Txt_orderNum.ReadOnly = true;
            this.Txt_orderNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_orderNum.SelectedText = "";
            this.Txt_orderNum.SelectionLength = 0;
            this.Txt_orderNum.SelectionStart = 0;
            this.Txt_orderNum.ShortcutsEnabled = true;
            this.Txt_orderNum.Size = new System.Drawing.Size(167, 23);
            this.Txt_orderNum.TabIndex = 1;
            this.Txt_orderNum.UseSelectable = true;
            this.Txt_orderNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_orderNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_receiptNumber
            // 
            // 
            // 
            // 
            this.txt_receiptNumber.CustomButton.Image = null;
            this.txt_receiptNumber.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txt_receiptNumber.CustomButton.Name = "";
            this.txt_receiptNumber.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txt_receiptNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_receiptNumber.CustomButton.TabIndex = 1;
            this.txt_receiptNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_receiptNumber.CustomButton.UseSelectable = true;
            this.txt_receiptNumber.CustomButton.Visible = false;
            this.txt_receiptNumber.Enabled = false;
            this.txt_receiptNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_receiptNumber.Lines = new string[0];
            this.txt_receiptNumber.Location = new System.Drawing.Point(161, 97);
            this.txt_receiptNumber.MaxLength = 32767;
            this.txt_receiptNumber.Name = "txt_receiptNumber";
            this.txt_receiptNumber.PasswordChar = '\0';
            this.txt_receiptNumber.ReadOnly = true;
            this.txt_receiptNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_receiptNumber.SelectedText = "";
            this.txt_receiptNumber.SelectionLength = 0;
            this.txt_receiptNumber.SelectionStart = 0;
            this.txt_receiptNumber.ShortcutsEnabled = true;
            this.txt_receiptNumber.Size = new System.Drawing.Size(167, 23);
            this.txt_receiptNumber.TabIndex = 2;
            this.txt_receiptNumber.UseSelectable = true;
            this.txt_receiptNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_receiptNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_dueAmount
            // 
            // 
            // 
            // 
            this.txt_dueAmount.CustomButton.Image = null;
            this.txt_dueAmount.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txt_dueAmount.CustomButton.Name = "";
            this.txt_dueAmount.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txt_dueAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_dueAmount.CustomButton.TabIndex = 1;
            this.txt_dueAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_dueAmount.CustomButton.UseSelectable = true;
            this.txt_dueAmount.CustomButton.Visible = false;
            this.txt_dueAmount.Enabled = false;
            this.txt_dueAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_dueAmount.Lines = new string[0];
            this.txt_dueAmount.Location = new System.Drawing.Point(161, 129);
            this.txt_dueAmount.MaxLength = 32767;
            this.txt_dueAmount.Name = "txt_dueAmount";
            this.txt_dueAmount.PasswordChar = '\0';
            this.txt_dueAmount.ReadOnly = true;
            this.txt_dueAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dueAmount.SelectedText = "";
            this.txt_dueAmount.SelectionLength = 0;
            this.txt_dueAmount.SelectionStart = 0;
            this.txt_dueAmount.ShortcutsEnabled = true;
            this.txt_dueAmount.Size = new System.Drawing.Size(167, 23);
            this.txt_dueAmount.TabIndex = 3;
            this.txt_dueAmount.UseSelectable = true;
            this.txt_dueAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_dueAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_amount
            // 
            // 
            // 
            // 
            this.txt_amount.CustomButton.Image = null;
            this.txt_amount.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txt_amount.CustomButton.Name = "";
            this.txt_amount.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txt_amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_amount.CustomButton.TabIndex = 1;
            this.txt_amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_amount.CustomButton.UseSelectable = true;
            this.txt_amount.CustomButton.Visible = false;
            this.txt_amount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_amount.Lines = new string[0];
            this.txt_amount.Location = new System.Drawing.Point(161, 158);
            this.txt_amount.MaxLength = 32767;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.PasswordChar = '\0';
            this.txt_amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_amount.SelectedText = "";
            this.txt_amount.SelectionLength = 0;
            this.txt_amount.SelectionStart = 0;
            this.txt_amount.ShortcutsEnabled = true;
            this.txt_amount.Size = new System.Drawing.Size(167, 23);
            this.txt_amount.TabIndex = 4;
            this.txt_amount.UseSelectable = true;
            this.txt_amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.recieptnoDataGridViewTextBoxColumn,
            this.paymentamountDataGridViewTextBoxColumn,
            this.paymentdateDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.paymentsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(345, 24);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(436, 218);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGrid1.TabIndex = 29;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "Order ID";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recieptnoDataGridViewTextBoxColumn
            // 
            this.recieptnoDataGridViewTextBoxColumn.DataPropertyName = "reciept_no";
            this.recieptnoDataGridViewTextBoxColumn.HeaderText = "Receipt Number";
            this.recieptnoDataGridViewTextBoxColumn.Name = "recieptnoDataGridViewTextBoxColumn";
            this.recieptnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentamountDataGridViewTextBoxColumn
            // 
            this.paymentamountDataGridViewTextBoxColumn.DataPropertyName = "payment_amount";
            this.paymentamountDataGridViewTextBoxColumn.HeaderText = "Payment Amount";
            this.paymentamountDataGridViewTextBoxColumn.Name = "paymentamountDataGridViewTextBoxColumn";
            this.paymentamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentdateDataGridViewTextBoxColumn
            // 
            this.paymentdateDataGridViewTextBoxColumn.DataPropertyName = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn.HeaderText = "Payment Date";
            this.paymentdateDataGridViewTextBoxColumn.Name = "paymentdateDataGridViewTextBoxColumn";
            this.paymentdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            this.paymentsBindingSource.DataSource = this.technovisionDataSet;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.EnforceConstraints = false;
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_newPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 264);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.txt_dueAmount);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_receiptNumber);
            this.Controls.Add(this.Txt_orderNum);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel9);
            this.MaximizeBox = false;
            this.Name = "frm_newPayment";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "New Payment";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_newPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTile btn_pay;
        private MetroFramework.Controls.MetroTextBox Txt_orderNum;
        private MetroFramework.Controls.MetroTextBox txt_receiptNumber;
        private MetroFramework.Controls.MetroTextBox txt_dueAmount;
        private MetroFramework.Controls.MetroTextBox txt_amount;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private technovisionDataSetTableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieptnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdateDataGridViewTextBoxColumn;
    }
}