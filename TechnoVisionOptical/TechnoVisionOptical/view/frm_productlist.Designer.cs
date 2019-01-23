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
            this.btn_delete = new MetroFramework.Controls.MetroTile();
            this.btn_add = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_model_name = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.ActiveControl = null;
            this.btn_delete.Location = new System.Drawing.Point(513, 447);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(85, 45);
            this.btn_delete.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_delete.UseSelectable = true;
            // 
            // btn_add
            // 
            this.btn_add.ActiveControl = null;
            this.btn_add.Location = new System.Drawing.Point(422, 447);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(85, 45);
            this.btn_add.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_add.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(139, 460);
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
            this.txt_model_name.Location = new System.Drawing.Point(232, 458);
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
            this.txt_model_name.TabIndex = 7;
            this.txt_model_name.UseSelectable = true;
            this.txt_model_name.WaterMark = "Enter Model Name";
            this.txt_model_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_model_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frm_productlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 515);
            this.Controls.Add(this.txt_model_name);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.MinimizeBox = false;
            this.Name = "frm_productlist";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Frame List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_delete;
        private MetroFramework.Controls.MetroTile btn_add;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_model_name;
    }
}