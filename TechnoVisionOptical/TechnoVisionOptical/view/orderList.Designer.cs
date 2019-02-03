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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_print_comp = new MetroFramework.Controls.MetroTile();
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
            this.btn_print_cust = new MetroFramework.Controls.MetroTile();
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_order_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_print_comp
            // 
            this.btn_print_comp.ActiveControl = null;
            this.btn_print_comp.Location = new System.Drawing.Point(714, 474);
            this.btn_print_comp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_print_comp.Name = "btn_print_comp";
            this.btn_print_comp.Size = new System.Drawing.Size(163, 54);
            this.btn_print_comp.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_print_comp.TabIndex = 6;
            this.btn_print_comp.Text = "View Company Copy";
            this.btn_print_comp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_print_comp.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print_comp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_print_comp.UseSelectable = true;
            this.btn_print_comp.UseTileImage = true;
            this.btn_print_comp.Click += new System.EventHandler(this.btn_print_comp_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ActiveControl = null;
            this.btn_cancel.Location = new System.Drawing.Point(571, 474);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(135, 54);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_order_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_order_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordernumberDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.ordertypeDataGridViewTextBoxColumn,
            this.status});
            this.grid_order_list.DataSource = this.ordersummaryBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_order_list.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_order_list.EnableHeadersVisualStyles = false;
            this.grid_order_list.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_order_list.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_order_list.Location = new System.Drawing.Point(31, 89);
            this.grid_order_list.Margin = new System.Windows.Forms.Padding(4);
            this.grid_order_list.Name = "grid_order_list";
            this.grid_order_list.ReadOnly = true;
            this.grid_order_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_order_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_order_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_order_list.Size = new System.Drawing.Size(1005, 361);
            this.grid_order_list.Style = MetroFramework.MetroColorStyle.Green;
            this.grid_order_list.TabIndex = 8;
            this.grid_order_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_order_list_CellContentClick);
            // 
            // ordernumberDataGridViewTextBoxColumn
            // 
            this.ordernumberDataGridViewTextBoxColumn.DataPropertyName = "order_number";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordernumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.metroLabel1.Location = new System.Drawing.Point(239, 486);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Mark Order As";
            // 
            // cmb_mark_as
            // 
            this.cmb_mark_as.FormattingEnabled = true;
            this.cmb_mark_as.ItemHeight = 24;
            this.cmb_mark_as.Items.AddRange(new object[] {
            "DELEVERED",
            "CANCELED"});
            this.cmb_mark_as.Location = new System.Drawing.Point(372, 484);
            this.cmb_mark_as.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_mark_as.Name = "cmb_mark_as";
            this.cmb_mark_as.Size = new System.Drawing.Size(192, 30);
            this.cmb_mark_as.TabIndex = 10;
            this.cmb_mark_as.UseSelectable = true;
            // 
            // btn_print_cust
            // 
            this.btn_print_cust.ActiveControl = null;
            this.btn_print_cust.Location = new System.Drawing.Point(885, 474);
            this.btn_print_cust.Margin = new System.Windows.Forms.Padding(4);
            this.btn_print_cust.Name = "btn_print_cust";
            this.btn_print_cust.Size = new System.Drawing.Size(169, 54);
            this.btn_print_cust.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_print_cust.TabIndex = 6;
            this.btn_print_cust.Text = "View Customer Copy";
            this.btn_print_cust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_print_cust.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print_cust.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_print_cust.UseSelectable = true;
            this.btn_print_cust.UseTileImage = true;
            this.btn_print_cust.Click += new System.EventHandler(this.btn_print_cust_Click);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txt_search.CustomButton.Image = null;
            this.txt_search.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txt_search.CustomButton.Name = "";
            this.txt_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search.CustomButton.TabIndex = 1;
            this.txt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search.CustomButton.UseSelectable = true;
            this.txt_search.CustomButton.Visible = false;
            this.txt_search.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(837, 41);
            this.txt_search.MaxLength = 32767;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PromptText = "Search here...";
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(199, 23);
            this.txt_search.TabIndex = 11;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMark = "Search here...";
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // orderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cmb_mark_as);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grid_order_list);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_print_cust);
            this.Controls.Add(this.btn_print_comp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "orderList";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
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

        private MetroFramework.Controls.MetroTile btn_print_comp;
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
        private MetroFramework.Controls.MetroTile btn_print_cust;
        private MetroFramework.Controls.MetroTextBox txt_search;
    }
}