namespace TechnoVisionOptical.view
{
    partial class frm_passwordReset
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btn_reset_pw = new MetroFramework.Controls.MetroTile();
            this.txt_nic = new MetroFramework.Controls.MetroTextBox();
            this.txt_phone = new MetroFramework.Controls.MetroTextBox();
            this.txt_new_pw = new MetroFramework.Controls.MetroTextBox();
            this.txt_confirm_pw = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Your NIC Number";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(130, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Your Phone Number";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 150);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(145, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Confirm New Password";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 121);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "New Password";
            // 
            // btn_reset_pw
            // 
            this.btn_reset_pw.ActiveControl = null;
            this.btn_reset_pw.Location = new System.Drawing.Point(131, 179);
            this.btn_reset_pw.Name = "btn_reset_pw";
            this.btn_reset_pw.Size = new System.Drawing.Size(128, 45);
            this.btn_reset_pw.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_reset_pw.TabIndex = 4;
            this.btn_reset_pw.Text = "Reset Password";
            this.btn_reset_pw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_reset_pw.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_reset_pw.UseSelectable = true;
            this.btn_reset_pw.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // txt_nic
            // 
            // 
            // 
            // 
            this.txt_nic.CustomButton.Image = null;
            this.txt_nic.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txt_nic.CustomButton.Name = "";
            this.txt_nic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_nic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nic.CustomButton.TabIndex = 1;
            this.txt_nic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nic.CustomButton.UseSelectable = true;
            this.txt_nic.CustomButton.Visible = false;
            this.txt_nic.Lines = new string[0];
            this.txt_nic.Location = new System.Drawing.Point(182, 61);
            this.txt_nic.MaxLength = 32767;
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.PasswordChar = '\0';
            this.txt_nic.PromptText = "Enter NIC";
            this.txt_nic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nic.SelectedText = "";
            this.txt_nic.SelectionLength = 0;
            this.txt_nic.SelectionStart = 0;
            this.txt_nic.ShortcutsEnabled = true;
            this.txt_nic.Size = new System.Drawing.Size(185, 23);
            this.txt_nic.TabIndex = 5;
            this.txt_nic.UseSelectable = true;
            this.txt_nic.WaterMark = "Enter NIC";
            this.txt_nic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nic.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txt_phone
            // 
            // 
            // 
            // 
            this.txt_phone.CustomButton.Image = null;
            this.txt_phone.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txt_phone.CustomButton.Name = "";
            this.txt_phone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_phone.CustomButton.TabIndex = 1;
            this.txt_phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_phone.CustomButton.UseSelectable = true;
            this.txt_phone.CustomButton.Visible = false;
            this.txt_phone.Lines = new string[0];
            this.txt_phone.Location = new System.Drawing.Point(182, 90);
            this.txt_phone.MaxLength = 32767;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.PromptText = "Enter Phone Number";
            this.txt_phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_phone.SelectedText = "";
            this.txt_phone.SelectionLength = 0;
            this.txt_phone.SelectionStart = 0;
            this.txt_phone.ShortcutsEnabled = true;
            this.txt_phone.Size = new System.Drawing.Size(185, 23);
            this.txt_phone.TabIndex = 6;
            this.txt_phone.UseSelectable = true;
            this.txt_phone.WaterMark = "Enter Phone Number";
            this.txt_phone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_phone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_new_pw
            // 
            // 
            // 
            // 
            this.txt_new_pw.CustomButton.Image = null;
            this.txt_new_pw.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txt_new_pw.CustomButton.Name = "";
            this.txt_new_pw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_new_pw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_new_pw.CustomButton.TabIndex = 1;
            this.txt_new_pw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_new_pw.CustomButton.UseSelectable = true;
            this.txt_new_pw.CustomButton.Visible = false;
            this.txt_new_pw.Lines = new string[0];
            this.txt_new_pw.Location = new System.Drawing.Point(182, 119);
            this.txt_new_pw.MaxLength = 32767;
            this.txt_new_pw.Name = "txt_new_pw";
            this.txt_new_pw.PasswordChar = '\0';
            this.txt_new_pw.PromptText = "Enter New Password";
            this.txt_new_pw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_new_pw.SelectedText = "";
            this.txt_new_pw.SelectionLength = 0;
            this.txt_new_pw.SelectionStart = 0;
            this.txt_new_pw.ShortcutsEnabled = true;
            this.txt_new_pw.Size = new System.Drawing.Size(185, 23);
            this.txt_new_pw.TabIndex = 7;
            this.txt_new_pw.UseSelectable = true;
            this.txt_new_pw.WaterMark = "Enter New Password";
            this.txt_new_pw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_new_pw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_confirm_pw
            // 
            // 
            // 
            // 
            this.txt_confirm_pw.CustomButton.Image = null;
            this.txt_confirm_pw.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txt_confirm_pw.CustomButton.Name = "";
            this.txt_confirm_pw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_confirm_pw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_confirm_pw.CustomButton.TabIndex = 1;
            this.txt_confirm_pw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_confirm_pw.CustomButton.UseSelectable = true;
            this.txt_confirm_pw.CustomButton.Visible = false;
            this.txt_confirm_pw.Lines = new string[0];
            this.txt_confirm_pw.Location = new System.Drawing.Point(182, 148);
            this.txt_confirm_pw.MaxLength = 32767;
            this.txt_confirm_pw.Name = "txt_confirm_pw";
            this.txt_confirm_pw.PasswordChar = '\0';
            this.txt_confirm_pw.PromptText = "Re-enter Password";
            this.txt_confirm_pw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_confirm_pw.SelectedText = "";
            this.txt_confirm_pw.SelectionLength = 0;
            this.txt_confirm_pw.SelectionStart = 0;
            this.txt_confirm_pw.ShortcutsEnabled = true;
            this.txt_confirm_pw.Size = new System.Drawing.Size(185, 23);
            this.txt_confirm_pw.TabIndex = 8;
            this.txt_confirm_pw.UseSelectable = true;
            this.txt_confirm_pw.WaterMark = "Re-enter Password";
            this.txt_confirm_pw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_confirm_pw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frm_passwordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 236);
            this.Controls.Add(this.txt_confirm_pw);
            this.Controls.Add(this.txt_new_pw);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.btn_reset_pw);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "frm_passwordReset";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Password Reset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile btn_reset_pw;
        private MetroFramework.Controls.MetroTextBox txt_nic;
        private MetroFramework.Controls.MetroTextBox txt_phone;
        private MetroFramework.Controls.MetroTextBox txt_new_pw;
        private MetroFramework.Controls.MetroTextBox txt_confirm_pw;
    }
}