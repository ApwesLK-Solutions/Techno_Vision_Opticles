namespace TechnoVisionOptical.view
{
    partial class frm_dashboard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ViewReports = new MetroFramework.Controls.MetroTile();
            this.btn_OrderContactLense = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_OrderCLense = new MetroFramework.Controls.MetroTile();
            this.btn_OrderSpecs = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btn_OrderContactLense.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TechnoVisionOptical.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ViewReports
            // 
            this.btn_ViewReports.ActiveControl = null;
            this.btn_ViewReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ViewReports.Location = new System.Drawing.Point(499, 153);
            this.btn_ViewReports.Name = "btn_ViewReports";
            this.btn_ViewReports.Size = new System.Drawing.Size(242, 170);
            this.btn_ViewReports.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_ViewReports.TabIndex = 1;
            this.btn_ViewReports.Text = "Reports";
            this.btn_ViewReports.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_ViewReports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_ViewReports.UseSelectable = true;
            // 
            // btn_OrderContactLense
            // 
            this.btn_OrderContactLense.ColumnCount = 1;
            this.btn_OrderContactLense.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.21067F));
            this.btn_OrderContactLense.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.btn_OrderContactLense.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.btn_OrderContactLense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OrderContactLense.Location = new System.Drawing.Point(20, 60);
            this.btn_OrderContactLense.Name = "btn_OrderContactLense";
            this.btn_OrderContactLense.RowCount = 2;
            this.btn_OrderContactLense.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.88283F));
            this.btn_OrderContactLense.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.11716F));
            this.btn_OrderContactLense.Size = new System.Drawing.Size(1000, 466);
            this.btn_OrderContactLense.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btn_OrderCLense, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_OrderSpecs, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_ViewReports, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 137);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.01227F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.98773F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(994, 326);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_OrderCLense
            // 
            this.btn_OrderCLense.ActiveControl = null;
            this.btn_OrderCLense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OrderCLense.Location = new System.Drawing.Point(251, 153);
            this.btn_OrderCLense.Name = "btn_OrderCLense";
            this.btn_OrderCLense.Size = new System.Drawing.Size(242, 170);
            this.btn_OrderCLense.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_OrderCLense.TabIndex = 3;
            this.btn_OrderCLense.Text = "New Contact Lense Order";
            this.btn_OrderCLense.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_OrderCLense.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_OrderCLense.UseSelectable = true;
            // 
            // btn_OrderSpecs
            // 
            this.btn_OrderSpecs.ActiveControl = null;
            this.btn_OrderSpecs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OrderSpecs.Location = new System.Drawing.Point(3, 153);
            this.btn_OrderSpecs.Name = "btn_OrderSpecs";
            this.btn_OrderSpecs.Size = new System.Drawing.Size(242, 170);
            this.btn_OrderSpecs.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_OrderSpecs.TabIndex = 2;
            this.btn_OrderSpecs.Text = "New Spectacle Order";
            this.btn_OrderSpecs.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_OrderSpecs.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_OrderSpecs.UseSelectable = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(994, 120);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Controls.Add(this.metroTile4, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(353, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(638, 114);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroTile4.Location = new System.Drawing.Point(587, 3);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(48, 41);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile4.TabIndex = 4;
            this.metroTile4.TileImage = global::TechnoVisionOptical.Properties.Resources.backup_KjJ_icon;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            // 
            // frm_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 546);
            this.Controls.Add(this.btn_OrderContactLense);
            this.MaximizeBox = false;
            this.Name = "frm_dashboard";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btn_OrderContactLense.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btn_ViewReports;
        private System.Windows.Forms.TableLayoutPanel btn_OrderContactLense;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroTile btn_OrderSpecs;
        private MetroFramework.Controls.MetroTile btn_OrderCLense;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroTile metroTile4;
    }
}