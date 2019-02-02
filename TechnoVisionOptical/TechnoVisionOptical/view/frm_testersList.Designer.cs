namespace TechnoVisionOptical.view
{
    partial class frm_testersList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_emp_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_addTester = new MetroFramework.Controls.MetroTile();
            this.btn_delete = new MetroFramework.Controls.MetroTile();
            this.grid_testers = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVisionOptical.technovisionDataSet();
            this.testersTableAdapter = new TechnoVisionOptical.technovisionDataSetTableAdapters.testersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid_testers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_emp_name
            // 
            // 
            // 
            // 
            this.txt_emp_name.CustomButton.Image = null;
            this.txt_emp_name.CustomButton.Location = new System.Drawing.Point(275, 2);
            this.txt_emp_name.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_emp_name.CustomButton.Name = "";
            this.txt_emp_name.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txt_emp_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_emp_name.CustomButton.TabIndex = 1;
            this.txt_emp_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_emp_name.CustomButton.UseSelectable = true;
            this.txt_emp_name.CustomButton.Visible = false;
            this.txt_emp_name.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_emp_name.Lines = new string[0];
            this.txt_emp_name.Location = new System.Drawing.Point(227, 495);
            this.txt_emp_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_emp_name.MaxLength = 32767;
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.PasswordChar = '\0';
            this.txt_emp_name.PromptText = "Enter Employee Name";
            this.txt_emp_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_emp_name.SelectedText = "";
            this.txt_emp_name.SelectionLength = 0;
            this.txt_emp_name.SelectionStart = 0;
            this.txt_emp_name.ShortcutsEnabled = true;
            this.txt_emp_name.Size = new System.Drawing.Size(232, 28);
            this.txt_emp_name.TabIndex = 13;
            this.txt_emp_name.UseSelectable = true;
            this.txt_emp_name.WaterMark = "Enter Employee Name";
            this.txt_emp_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_emp_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(77, 495);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 20);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Employee Name";
            // 
            // btn_addTester
            // 
            this.btn_addTester.ActiveControl = null;
            this.btn_addTester.Location = new System.Drawing.Point(131, 537);
            this.btn_addTester.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addTester.Name = "btn_addTester";
            this.btn_addTester.Size = new System.Drawing.Size(113, 55);
            this.btn_addTester.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_addTester.TabIndex = 9;
            this.btn_addTester.Text = "Add";
            this.btn_addTester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addTester.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_addTester.UseSelectable = true;
            this.btn_addTester.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ActiveControl = null;
            this.btn_delete.Location = new System.Drawing.Point(255, 537);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(113, 55);
            this.btn_delete.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // grid_testers
            // 
            this.grid_testers.AllowUserToResizeRows = false;
            this.grid_testers.AutoGenerateColumns = false;
            this.grid_testers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_testers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_testers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_testers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_testers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_testers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_testers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_testers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.grid_testers.DataSource = this.testersBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_testers.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_testers.EnableHeadersVisualStyles = false;
            this.grid_testers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_testers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_testers.Location = new System.Drawing.Point(29, 69);
            this.grid_testers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid_testers.Name = "grid_testers";
            this.grid_testers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_testers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_testers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_testers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_testers.Size = new System.Drawing.Size(465, 398);
            this.grid_testers.Style = MetroFramework.MetroColorStyle.Green;
            this.grid_testers.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // testersBindingSource
            // 
            this.testersBindingSource.DataMember = "testers";
            this.testersBindingSource.DataSource = this.technovisionDataSet;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.EnforceConstraints = false;
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testersTableAdapter
            // 
            this.testersTableAdapter.ClearBeforeFill = true;
            // 
            // frm_testersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 608);
            this.Controls.Add(this.grid_testers);
            this.Controls.Add(this.txt_emp_name);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_addTester);
            this.Controls.Add(this.btn_delete);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_testersList";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Testers List";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_testersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_testers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_emp_name;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btn_addTester;
        private MetroFramework.Controls.MetroTile btn_delete;
        private MetroFramework.Controls.MetroGrid grid_testers;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource testersBindingSource;
        private technovisionDataSetTableAdapters.testersTableAdapter testersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}