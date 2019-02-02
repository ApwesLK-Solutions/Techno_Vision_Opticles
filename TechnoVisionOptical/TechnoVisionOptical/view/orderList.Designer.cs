namespace TechnoVisionOptical.view
{
    partial class orderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_print = new MetroFramework.Controls.MetroTile();
            this.btn_cancel = new MetroFramework.Controls.MetroTile();
            this.grid_order_list = new MetroFramework.Controls.MetroGrid();
            this.ordernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVisionOptical.technovisionDataSet();
            this.order_summaryTableAdapter = new TechnoVisionOptical.technovisionDataSetTableAdapters.order_summaryTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmb_mark_as = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_order_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.ActiveControl = null;
            this.btn_print.Location = new System.Drawing.Point(676, 385);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(101, 44);
            this.btn_print.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_print.TabIndex = 6;
            this.btn_print.Text = "Print";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_print.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_print.UseSelectable = true;
            this.btn_print.UseTileImage = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ActiveControl = null;
            this.btn_cancel.Location = new System.Drawing.Point(569, 385);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(101, 44);
            this.btn_cancel.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Set";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // grid_order_list
            // 
            this.grid_order_list.AllowUserToAddRows = false;
            this.grid_order_list.AllowUserToDeleteRows = false;
            this.grid_order_list.AllowUserToResizeRows = false;
            this.grid_order_list.AutoGenerateColumns = false;
            this.grid_order_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_order_list.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_order_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_order_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_order_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_order_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_order_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordernumberDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.ordertypeDataGridViewTextBoxColumn,
            this.status});
            this.grid_order_list.DataSource = this.ordersummaryBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_order_list.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_order_list.EnableHeadersVisualStyles = false;
            this.grid_order_list.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_order_list.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_order_list.Location = new System.Drawing.Point(23, 72);
            this.grid_order_list.Name = "grid_order_list";
            this.grid_order_list.ReadOnly = true;
            this.grid_order_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_order_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_order_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_order_list.Size = new System.Drawing.Size(754, 293);
            this.grid_order_list.Style = MetroFramework.MetroColorStyle.Green;
            this.grid_order_list.TabIndex = 8;
            this.grid_order_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_order_list_CellContentClick);
            // 
            // ordernumberDataGridViewTextBoxColumn
            // 
            this.ordernumberDataGridViewTextBoxColumn.DataPropertyName = "order_number";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordernumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ordernumberDataGridViewTextBoxColumn.HeaderText = "Order Number";
            this.ordernumberDataGridViewTextBoxColumn.Name = "ordernumberDataGridViewTextBoxColumn";
            this.ordernumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordertypeDataGridViewTextBoxColumn
            // 
            this.ordertypeDataGridViewTextBoxColumn.DataPropertyName = "order_type";
            this.ordertypeDataGridViewTextBoxColumn.HeaderText = "Order Type";
            this.ordertypeDataGridViewTextBoxColumn.Name = "ordertypeDataGridViewTextBoxColumn";
            this.ordertypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // ordersummaryBindingSource
            // 
            this.ordersummaryBindingSource.DataMember = "order_summary";
            this.ordersummaryBindingSource.DataSource = this.technovisionDataSetBindingSource;
            // 
            // technovisionDataSetBindingSource
            // 
            this.technovisionDataSetBindingSource.DataSource = this.technovisionDataSet;
            this.technovisionDataSetBindingSource.Position = 0;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.EnforceConstraints = false;
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_summaryTableAdapter
            // 
            this.order_summaryTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(320, 395);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Mark Order As";
            // 
            // cmb_mark_as
            // 
            this.cmb_mark_as.FormattingEnabled = true;
            this.cmb_mark_as.ItemHeight = 23;
            this.cmb_mark_as.Items.AddRange(new object[] {
            "DELEVERED",
            "CANCELED"});
            this.cmb_mark_as.Location = new System.Drawing.Point(420, 393);
            this.cmb_mark_as.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_mark_as.Name = "cmb_mark_as";
            this.cmb_mark_as.Size = new System.Drawing.Size(145, 29);
            this.cmb_mark_as.TabIndex = 10;
            this.cmb_mark_as.UseSelectable = true;
            // 
            // orderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_mark_as);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grid_order_list);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_print);
            this.MaximizeBox = false;
            this.Name = "orderList";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Orders List";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.orderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_order_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_print;
        private MetroFramework.Controls.MetroTile btn_cancel;
        private MetroFramework.Controls.MetroGrid grid_order_list;
        private System.Windows.Forms.BindingSource technovisionDataSetBindingSource;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource ordersummaryBindingSource;
        private technovisionDataSetTableAdapters.order_summaryTableAdapter order_summaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmb_mark_as;
    }
}