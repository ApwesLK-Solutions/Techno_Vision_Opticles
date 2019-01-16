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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btn_new_payment = new MetroFramework.Controls.MetroTile();
            this.btn_close = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_order_no = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(133, 111);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Customer Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(446, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Paid";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(510, 111);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Due Amount";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(623, 111);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Due Date";
            // 
            // btn_new_payment
            // 
            this.btn_new_payment.ActiveControl = null;
            this.btn_new_payment.Location = new System.Drawing.Point(510, 433);
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
            this.btn_close.Location = new System.Drawing.Point(632, 433);
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
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(366, 111);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Amount";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(49, 111);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(67, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Order No";
            // 
            // txt_order_no
            // 
            // 
            // 
            // 
            this.txt_order_no.CustomButton.Image = null;
            this.txt_order_no.CustomButton.Location = new System.Drawing.Point(84, 1);
            this.txt_order_no.CustomButton.Name = "";
            this.txt_order_no.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_order_no.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_order_no.CustomButton.TabIndex = 1;
            this.txt_order_no.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_order_no.CustomButton.UseSelectable = true;
            this.txt_order_no.CustomButton.Visible = false;
            this.txt_order_no.Lines = new string[0];
            this.txt_order_no.Location = new System.Drawing.Point(340, 35);
            this.txt_order_no.MaxLength = 32767;
            this.txt_order_no.Name = "txt_order_no";
            this.txt_order_no.PasswordChar = '\0';
            this.txt_order_no.PromptText = "Search Here";
            this.txt_order_no.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_order_no.SelectedText = "";
            this.txt_order_no.SelectionLength = 0;
            this.txt_order_no.SelectionStart = 0;
            this.txt_order_no.ShortcutsEnabled = true;
            this.txt_order_no.Size = new System.Drawing.Size(106, 23);
            this.txt_order_no.TabIndex = 8;
            this.txt_order_no.UseSelectable = true;
            this.txt_order_no.WaterMark = "Search Here";
            this.txt_order_no.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_order_no.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(245, 111);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(115, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "Customer Contact";
            // 
            // frm_paymentPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 515);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txt_order_no);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_new_payment);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frm_paymentPlan";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Payment Plan Manager";
            this.Load += new System.EventHandler(this.frm_paymentPlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile btn_new_payment;
        private MetroFramework.Controls.MetroTile btn_close;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_order_no;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}