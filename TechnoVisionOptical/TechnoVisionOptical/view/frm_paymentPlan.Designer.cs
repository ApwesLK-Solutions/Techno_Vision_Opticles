﻿namespace TechnoVisionOptical.view
{
    partial class frm_paymentPlan
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
            this.btn_new_payment = new MetroFramework.Controls.MetroTile();
            this.txt_order_no = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.ordernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieptnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVisionOptical.technovisionDataSet();
            this.customerPaymentsTableAdapter = new TechnoVisionOptical.technovisionDataSetTableAdapters.CustomerPaymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_new_payment
            // 
            this.btn_new_payment.ActiveControl = null;
            this.btn_new_payment.Location = new System.Drawing.Point(1015, 502);
            this.btn_new_payment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new_payment.Name = "btn_new_payment";
            this.btn_new_payment.Size = new System.Drawing.Size(155, 55);
            this.btn_new_payment.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_new_payment.TabIndex = 4;
            this.btn_new_payment.Text = "New Payment";
            this.btn_new_payment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new_payment.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_new_payment.UseSelectable = true;
            this.btn_new_payment.Click += new System.EventHandler(this.btn_new_payment_Click);
            // 
            // txt_order_no
            // 
            // 
            // 
            // 
            this.txt_order_no.CustomButton.Image = null;
            this.txt_order_no.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txt_order_no.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txt_order_no.CustomButton.Name = "";
            this.txt_order_no.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_order_no.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_order_no.CustomButton.TabIndex = 1;
            this.txt_order_no.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_order_no.CustomButton.UseSelectable = true;
            this.txt_order_no.CustomButton.Visible = false;
            this.txt_order_no.Lines = new string[0];
            this.txt_order_no.Location = new System.Drawing.Point(1015, 81);
            this.txt_order_no.Margin = new System.Windows.Forms.Padding(4);
            this.txt_order_no.MaxLength = 32767;
            this.txt_order_no.Name = "txt_order_no";
            this.txt_order_no.PasswordChar = '\0';
            this.txt_order_no.PromptText = "Search Here";
            this.txt_order_no.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_order_no.SelectedText = "";
            this.txt_order_no.SelectionLength = 0;
            this.txt_order_no.SelectionStart = 0;
            this.txt_order_no.ShortcutsEnabled = true;
            this.txt_order_no.Size = new System.Drawing.Size(167, 28);
            this.txt_order_no.TabIndex = 8;
            this.txt_order_no.UseSelectable = true;
            this.txt_order_no.WaterMark = "Search Here";
            this.txt_order_no.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_order_no.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_order_no.TextChanged += new System.EventHandler(this.txt_order_no_TextChanged);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.ordernumberDataGridViewTextBoxColumn,
            this.ordertypeDataGridViewTextBoxColumn,
            this.dueamountDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn,
            this.paymentplanDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.recieptnoDataGridViewTextBoxColumn,
            this.paymentamountDataGridViewTextBoxColumn,
            this.paymentdateDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.customerPaymentsBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(35, 117);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(4);
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
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1147, 362);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGrid1.TabIndex = 9;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // ordernumberDataGridViewTextBoxColumn
            // 
            this.ordernumberDataGridViewTextBoxColumn.DataPropertyName = "order_number";
            this.ordernumberDataGridViewTextBoxColumn.HeaderText = "Order Number";
            this.ordernumberDataGridViewTextBoxColumn.Name = "ordernumberDataGridViewTextBoxColumn";
            this.ordernumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordernumberDataGridViewTextBoxColumn.Width = 152;
            // 
            // ordertypeDataGridViewTextBoxColumn
            // 
            this.ordertypeDataGridViewTextBoxColumn.DataPropertyName = "order_type";
            this.ordertypeDataGridViewTextBoxColumn.HeaderText = "Order Type";
            this.ordertypeDataGridViewTextBoxColumn.Name = "ordertypeDataGridViewTextBoxColumn";
            this.ordertypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordertypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dueamountDataGridViewTextBoxColumn
            // 
            this.dueamountDataGridViewTextBoxColumn.DataPropertyName = "due_amount";
            this.dueamountDataGridViewTextBoxColumn.HeaderText = "Due Amount";
            this.dueamountDataGridViewTextBoxColumn.Name = "dueamountDataGridViewTextBoxColumn";
            this.dueamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.dueamountDataGridViewTextBoxColumn.Width = 137;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "Order Date";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            this.orderdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentplanDataGridViewTextBoxColumn
            // 
            this.paymentplanDataGridViewTextBoxColumn.DataPropertyName = "payment_plan";
            this.paymentplanDataGridViewTextBoxColumn.HeaderText = "Payment Plan";
            this.paymentplanDataGridViewTextBoxColumn.Name = "paymentplanDataGridViewTextBoxColumn";
            this.paymentplanDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentplanDataGridViewTextBoxColumn.Width = 143;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 81;
            // 
            // recieptnoDataGridViewTextBoxColumn
            // 
            this.recieptnoDataGridViewTextBoxColumn.DataPropertyName = "reciept_no";
            this.recieptnoDataGridViewTextBoxColumn.HeaderText = "Receipt No";
            this.recieptnoDataGridViewTextBoxColumn.Name = "recieptnoDataGridViewTextBoxColumn";
            this.recieptnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.recieptnoDataGridViewTextBoxColumn.Width = 124;
            // 
            // paymentamountDataGridViewTextBoxColumn
            // 
            this.paymentamountDataGridViewTextBoxColumn.DataPropertyName = "payment_amount";
            this.paymentamountDataGridViewTextBoxColumn.HeaderText = "Payment Amount";
            this.paymentamountDataGridViewTextBoxColumn.Name = "paymentamountDataGridViewTextBoxColumn";
            this.paymentamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentamountDataGridViewTextBoxColumn.Width = 173;
            // 
            // paymentdateDataGridViewTextBoxColumn
            // 
            this.paymentdateDataGridViewTextBoxColumn.DataPropertyName = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn.HeaderText = "Payment Date";
            this.paymentdateDataGridViewTextBoxColumn.Name = "paymentdateDataGridViewTextBoxColumn";
            this.paymentdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentdateDataGridViewTextBoxColumn.Width = 146;
            // 
            // customerPaymentsBindingSource
            // 
            this.customerPaymentsBindingSource.DataMember = "CustomerPayments";
            this.customerPaymentsBindingSource.DataSource = this.technovisionDataSet;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.EnforceConstraints = false;
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerPaymentsTableAdapter
            // 
            this.customerPaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_paymentPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 572);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.txt_order_no);
            this.Controls.Add(this.btn_new_payment);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_paymentPlan";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Payment Plan Manager";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_paymentPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_new_payment;
        private MetroFramework.Controls.MetroTextBox txt_order_no;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource customerPaymentsBindingSource;
        private technovisionDataSetTableAdapters.CustomerPaymentsTableAdapter customerPaymentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieptnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdateDataGridViewTextBoxColumn;
    }
}