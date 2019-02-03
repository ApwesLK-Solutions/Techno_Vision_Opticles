namespace TechnoVisionOptical.view
{
    partial class frm_orderComplete
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_viewCompany = new MetroFramework.Controls.MetroTile();
            this.btn_viewCustomer = new MetroFramework.Controls.MetroTile();
            this.btn_printBoth = new MetroFramework.Controls.MetroTile();
            this.btn_printCompany = new MetroFramework.Controls.MetroTile();
            this.btn_PrintCustomer = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(396, 295);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(209, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Order is Successfully Completed";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.13493F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.13491F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.73015F));
            this.tableLayoutPanel1.Controls.Add(this.btn_viewCompany, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_printBoth, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_printCompany, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_PrintCustomer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_viewCustomer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(151, 364);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 144);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_viewCompany
            // 
            this.btn_viewCompany.ActiveControl = null;
            this.btn_viewCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_viewCompany.Location = new System.Drawing.Point(502, 4);
            this.btn_viewCompany.Margin = new System.Windows.Forms.Padding(4);
            this.btn_viewCompany.Name = "btn_viewCompany";
            this.btn_viewCompany.Size = new System.Drawing.Size(246, 64);
            this.btn_viewCompany.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_viewCompany.TabIndex = 13;
            this.btn_viewCompany.Text = "View Company Reciept";
            this.btn_viewCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_viewCompany.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_viewCompany.UseSelectable = true;
            this.btn_viewCompany.Click += new System.EventHandler(this.btn_viewCompany_Click);
            // 
            // btn_viewCustomer
            // 
            this.btn_viewCustomer.ActiveControl = null;
            this.btn_viewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_viewCustomer.Location = new System.Drawing.Point(4, 4);
            this.btn_viewCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_viewCustomer.Name = "btn_viewCustomer";
            this.btn_viewCustomer.Size = new System.Drawing.Size(241, 64);
            this.btn_viewCustomer.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_viewCustomer.TabIndex = 2;
            this.btn_viewCustomer.Text = "View Customer Reciept";
            this.btn_viewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_viewCustomer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_viewCustomer.UseSelectable = true;
            this.btn_viewCustomer.Click += new System.EventHandler(this.btn_viewCustomer_Click);
            // 
            // btn_printBoth
            // 
            this.btn_printBoth.ActiveControl = null;
            this.btn_printBoth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_printBoth.Location = new System.Drawing.Point(502, 76);
            this.btn_printBoth.Margin = new System.Windows.Forms.Padding(4);
            this.btn_printBoth.Name = "btn_printBoth";
            this.btn_printBoth.Size = new System.Drawing.Size(246, 64);
            this.btn_printBoth.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_printBoth.TabIndex = 6;
            this.btn_printBoth.Text = "Print Both";
            this.btn_printBoth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_printBoth.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_printBoth.UseSelectable = true;
            this.btn_printBoth.Click += new System.EventHandler(this.btn_printBoth_Click_1);
            // 
            // btn_printCompany
            // 
            this.btn_printCompany.ActiveControl = null;
            this.btn_printCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_printCompany.Location = new System.Drawing.Point(253, 76);
            this.btn_printCompany.Margin = new System.Windows.Forms.Padding(4);
            this.btn_printCompany.Name = "btn_printCompany";
            this.btn_printCompany.Size = new System.Drawing.Size(241, 64);
            this.btn_printCompany.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_printCompany.TabIndex = 5;
            this.btn_printCompany.Text = "Print Company Reciept";
            this.btn_printCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_printCompany.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_printCompany.UseSelectable = true;
            this.btn_printCompany.Click += new System.EventHandler(this.btn_printCompany_Click);
            // 
            // btn_PrintCustomer
            // 
            this.btn_PrintCustomer.ActiveControl = null;
            this.btn_PrintCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_PrintCustomer.Location = new System.Drawing.Point(4, 76);
            this.btn_PrintCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PrintCustomer.Name = "btn_PrintCustomer";
            this.btn_PrintCustomer.Size = new System.Drawing.Size(241, 64);
            this.btn_PrintCustomer.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_PrintCustomer.TabIndex = 4;
            this.btn_PrintCustomer.Text = "Print Customer Reciept";
            this.btn_PrintCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PrintCustomer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_PrintCustomer.UseSelectable = true;
            this.btn_PrintCustomer.Click += new System.EventHandler(this.btn_PrintCustomer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TechnoVisionOptical.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(431, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frm_orderComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_orderComplete";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_orderComplete_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile btn_printBoth;
        private MetroFramework.Controls.MetroTile btn_printCompany;
        private MetroFramework.Controls.MetroTile btn_PrintCustomer;
        private MetroFramework.Controls.MetroTile btn_viewCustomer;
        private MetroFramework.Controls.MetroTile btn_viewCompany;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}