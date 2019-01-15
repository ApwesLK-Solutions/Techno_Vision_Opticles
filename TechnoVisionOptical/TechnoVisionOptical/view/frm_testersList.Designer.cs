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
            this.text_emp_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_update = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // text_emp_name
            // 
            // 
            // 
            // 
            this.text_emp_name.CustomButton.Image = null;
            this.text_emp_name.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.text_emp_name.CustomButton.Name = "";
            this.text_emp_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.text_emp_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_emp_name.CustomButton.TabIndex = 1;
            this.text_emp_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_emp_name.CustomButton.UseSelectable = true;
            this.text_emp_name.CustomButton.Visible = false;
            this.text_emp_name.Lines = new string[0];
            this.text_emp_name.Location = new System.Drawing.Point(147, 329);
            this.text_emp_name.MaxLength = 32767;
            this.text_emp_name.Name = "text_emp_name";
            this.text_emp_name.PasswordChar = '\0';
            this.text_emp_name.PromptText = "Enter Frame ID";
            this.text_emp_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_emp_name.SelectedText = "";
            this.text_emp_name.SelectionLength = 0;
            this.text_emp_name.SelectionStart = 0;
            this.text_emp_name.ShortcutsEnabled = true;
            this.text_emp_name.Size = new System.Drawing.Size(174, 23);
            this.text_emp_name.TabIndex = 13;
            this.text_emp_name.UseSelectable = true;
            this.text_emp_name.WaterMark = "Enter Frame ID";
            this.text_emp_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_emp_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 329);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Employee Name";
            // 
            // btn_update
            // 
            this.btn_update.ActiveControl = null;
            this.btn_update.Location = new System.Drawing.Point(439, 382);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(85, 45);
            this.btn_update.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_update.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(530, 382);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(85, 45);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 9;
            this.metroTile2.Text = "Add";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(621, 382);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(85, 45);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "Delete";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // frm_testersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_emp_name);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Name = "frm_testersList";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Testers List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox text_emp_name;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btn_update;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}