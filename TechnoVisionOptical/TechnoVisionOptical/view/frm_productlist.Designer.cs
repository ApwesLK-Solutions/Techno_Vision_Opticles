namespace TechnoVisionOptical.view
{
    partial class frm_productlist
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
            this.btn_delete = new MetroFramework.Controls.MetroTile();
            this.btn_add = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_model_name = new MetroFramework.Controls.MetroTextBox();
            this.grid_frame = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.framemodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVisionOptical.technovisionDataSet();
            this.frameTableAdapter = new TechnoVisionOptical.technovisionDataSetTableAdapters.frameTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid_frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.ActiveControl = null;
            this.btn_delete.Location = new System.Drawing.Point(191, 436);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(85, 45);
            this.btn_delete.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.ActiveControl = null;
            this.btn_add.Location = new System.Drawing.Point(98, 436);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(85, 45);
            this.btn_add.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(64, 402);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Model Name";
            // 
            // txt_model_name
            // 
            // 
            // 
            // 
            this.txt_model_name.CustomButton.Image = null;
            this.txt_model_name.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txt_model_name.CustomButton.Name = "";
            this.txt_model_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_model_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_model_name.CustomButton.TabIndex = 1;
            this.txt_model_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_model_name.CustomButton.UseSelectable = true;
            this.txt_model_name.CustomButton.Visible = false;
            this.txt_model_name.Lines = new string[0];
            this.txt_model_name.Location = new System.Drawing.Point(157, 402);
            this.txt_model_name.MaxLength = 32767;
            this.txt_model_name.Name = "txt_model_name";
            this.txt_model_name.PasswordChar = '\0';
            this.txt_model_name.PromptText = "Enter Model Name";
            this.txt_model_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_model_name.SelectedText = "";
            this.txt_model_name.SelectionLength = 0;
            this.txt_model_name.SelectionStart = 0;
            this.txt_model_name.ShortcutsEnabled = true;
            this.txt_model_name.Size = new System.Drawing.Size(174, 23);
            this.txt_model_name.TabIndex = 1;
            this.txt_model_name.UseSelectable = true;
            this.txt_model_name.WaterMark = "Enter Model Name";
            this.txt_model_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_model_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grid_frame
            // 
            this.grid_frame.AllowUserToAddRows = false;
            this.grid_frame.AllowUserToDeleteRows = false;
            this.grid_frame.AllowUserToResizeRows = false;
            this.grid_frame.AutoGenerateColumns = false;
            this.grid_frame.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_frame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_frame.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_frame.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_frame.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_frame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_frame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.framemodelDataGridViewTextBoxColumn});
            this.grid_frame.DataSource = this.frameBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_frame.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_frame.EnableHeadersVisualStyles = false;
            this.grid_frame.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_frame.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_frame.Location = new System.Drawing.Point(22, 56);
            this.grid_frame.Name = "grid_frame";
            this.grid_frame.ReadOnly = true;
            this.grid_frame.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_frame.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_frame.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_frame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_frame.Size = new System.Drawing.Size(349, 323);
            this.grid_frame.Style = MetroFramework.MetroColorStyle.Green;
            this.grid_frame.TabIndex = 90;
            this.grid_frame.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_frame_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Product ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // framemodelDataGridViewTextBoxColumn
            // 
            this.framemodelDataGridViewTextBoxColumn.DataPropertyName = "frame_model";
            this.framemodelDataGridViewTextBoxColumn.HeaderText = "Frame Model";
            this.framemodelDataGridViewTextBoxColumn.Name = "framemodelDataGridViewTextBoxColumn";
            this.framemodelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frameBindingSource
            // 
            this.frameBindingSource.DataMember = "frame";
            this.frameBindingSource.DataSource = this.technovisionDataSetBindingSource;
            // 
            // technovisionDataSetBindingSource
            // 
            this.technovisionDataSetBindingSource.DataSource = this.technovisionDataSet;
            this.technovisionDataSetBindingSource.Position = 0;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frameTableAdapter
            // 
            this.frameTableAdapter.ClearBeforeFill = true;
            // 
            // frm_productlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 494);
            this.Controls.Add(this.grid_frame);
            this.Controls.Add(this.txt_model_name);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.MinimizeBox = false;
            this.Name = "frm_productlist";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Frame List";
            this.Load += new System.EventHandler(this.frm_productlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_delete;
        private MetroFramework.Controls.MetroTile btn_add;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_model_name;
        private MetroFramework.Controls.MetroGrid grid_frame;
        private System.Windows.Forms.BindingSource technovisionDataSetBindingSource;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource frameBindingSource;
        private technovisionDataSetTableAdapters.frameTableAdapter frameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn framemodelDataGridViewTextBoxColumn;
    }
}