namespace TechnoVisionOptical.view
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
            this.btn_close = new MetroFramework.Controls.MetroTile();
            this.txt_order_no = new MetroFramework.Controls.MetroTextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVisionOptical.technovisionDataSet();
            this.customersTableAdapter = new TechnoVisionOptical.technovisionDataSetTableAdapters.customersTableAdapter();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.ordersummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_summaryTableAdapter = new TechnoVisionOptical.technovisionDataSetTableAdapters.order_summaryTableAdapter();
            this.lenseordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lense_ordersTableAdapter = new TechnoVisionOptical.technovisionDataSetTableAdapters.lense_ordersTableAdapter();
            this.ordernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenses_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenseordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_new_payment
            // 
            this.btn_new_payment.ActiveControl = null;
            this.btn_new_payment.Location = new System.Drawing.Point(500, 406);
            this.btn_new_payment.Name = "btn_new_payment";
            this.btn_new_payment.Size = new System.Drawing.Size(116, 45);
            this.btn_new_payment.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_new_payment.TabIndex = 4;
            this.btn_new_payment.Text = "New Payment";
            this.btn_new_payment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new_payment.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_new_payment.UseSelectable = true;
            this.btn_new_payment.Click += new System.EventHandler(this.btn_new_payment_Click);
            // 
            // btn_close
            // 
            this.btn_close.ActiveControl = null;
            this.btn_close.Location = new System.Drawing.Point(622, 406);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 45);
            this.btn_close.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_close.UseSelectable = true;
            // 
            // txt_order_no
            // 
            // 
            // 
            // 
            this.txt_order_no.CustomButton.Image = null;
            this.txt_order_no.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txt_order_no.CustomButton.Name = "";
            this.txt_order_no.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_order_no.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_order_no.CustomButton.TabIndex = 1;
            this.txt_order_no.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_order_no.CustomButton.UseSelectable = true;
            this.txt_order_no.CustomButton.Visible = false;
            this.txt_order_no.Lines = new string[0];
            this.txt_order_no.Location = new System.Drawing.Point(466, 29);
            this.txt_order_no.MaxLength = 32767;
            this.txt_order_no.Name = "txt_order_no";
            this.txt_order_no.PasswordChar = '\0';
            this.txt_order_no.PromptText = "Search Here";
            this.txt_order_no.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_order_no.SelectedText = "";
            this.txt_order_no.SelectionLength = 0;
            this.txt_order_no.SelectionStart = 0;
            this.txt_order_no.ShortcutsEnabled = true;
            this.txt_order_no.Size = new System.Drawing.Size(125, 23);
            this.txt_order_no.TabIndex = 8;
            this.txt_order_no.UseSelectable = true;
            this.txt_order_no.WaterMark = "Search Here";
            this.txt_order_no.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_order_no.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.technovisionDataSet;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordernumberDataGridViewTextBoxColumn,
            this.receiptnumberDataGridViewTextBoxColumn,
            this.lenses_total,
            this.advance,
            this.balance});
            this.metroGrid1.DataSource = this.lenseordersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 82);
            this.metroGrid1.Name = "metroGrid1";
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
            this.metroGrid1.Size = new System.Drawing.Size(684, 300);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGrid1.TabIndex = 9;
            // 
            // ordersummaryBindingSource
            // 
            this.ordersummaryBindingSource.DataMember = "order_summary";
            this.ordersummaryBindingSource.DataSource = this.technovisionDataSet;
            // 
            // order_summaryTableAdapter
            // 
            this.order_summaryTableAdapter.ClearBeforeFill = true;
            // 
            // lenseordersBindingSource
            // 
            this.lenseordersBindingSource.DataMember = "lense_orders";
            this.lenseordersBindingSource.DataSource = this.technovisionDataSet;
            // 
            // lense_ordersTableAdapter
            // 
            this.lense_ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordernumberDataGridViewTextBoxColumn
            // 
            this.ordernumberDataGridViewTextBoxColumn.DataPropertyName = "order_number";
            this.ordernumberDataGridViewTextBoxColumn.HeaderText = "Order Number";
            this.ordernumberDataGridViewTextBoxColumn.Name = "ordernumberDataGridViewTextBoxColumn";
            // 
            // receiptnumberDataGridViewTextBoxColumn
            // 
            this.receiptnumberDataGridViewTextBoxColumn.DataPropertyName = "receipt_number";
            this.receiptnumberDataGridViewTextBoxColumn.HeaderText = "Receipt Number";
            this.receiptnumberDataGridViewTextBoxColumn.Name = "receiptnumberDataGridViewTextBoxColumn";
            // 
            // lenses_total
            // 
            this.lenses_total.DataPropertyName = "lenses_total";
            this.lenses_total.HeaderText = "Total Amount";
            this.lenses_total.Name = "lenses_total";
            // 
            // advance
            // 
            this.advance.DataPropertyName = "advance";
            this.advance.HeaderText = "Advance";
            this.advance.Name = "advance";
            // 
            // balance
            // 
            this.balance.DataPropertyName = "balance";
            this.balance.HeaderText = "Balance";
            this.balance.Name = "balance";
            // 
            // frm_paymentPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 462);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.txt_order_no);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_new_payment);
            this.MaximizeBox = false;
            this.Name = "frm_paymentPlan";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Payment Plan Manager - Contact Lenses";
            this.Load += new System.EventHandler(this.frm_paymentPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenseordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_new_payment;
        private MetroFramework.Controls.MetroTile btn_close;
        private MetroFramework.Controls.MetroTextBox txt_order_no;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private technovisionDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource ordersummaryBindingSource;
        private technovisionDataSetTableAdapters.order_summaryTableAdapter order_summaryTableAdapter;
        private System.Windows.Forms.BindingSource lenseordersBindingSource;
        private technovisionDataSetTableAdapters.lense_ordersTableAdapter lense_ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenses_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn advance;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
    }
}