namespace TechnoVisionOptical.view
{
    partial class frm_selectCustomer
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
            this.btn_new_customer = new MetroFramework.Controls.MetroTile();
            this.btn_existing_customer = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btn_new_customer
            // 
            this.btn_new_customer.ActiveControl = null;
            this.btn_new_customer.Location = new System.Drawing.Point(34, 47);
            this.btn_new_customer.Name = "btn_new_customer";
            this.btn_new_customer.Size = new System.Drawing.Size(233, 208);
            this.btn_new_customer.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_new_customer.TabIndex = 0;
            this.btn_new_customer.Text = "New Customer";
            this.btn_new_customer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_new_customer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_new_customer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_new_customer.UseSelectable = true;
            this.btn_new_customer.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btn_existing_customer
            // 
            this.btn_existing_customer.ActiveControl = null;
            this.btn_existing_customer.Location = new System.Drawing.Point(291, 47);
            this.btn_existing_customer.Name = "btn_existing_customer";
            this.btn_existing_customer.Size = new System.Drawing.Size(233, 208);
            this.btn_existing_customer.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_existing_customer.TabIndex = 1;
            this.btn_existing_customer.Text = "Existing Customer";
            this.btn_existing_customer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_existing_customer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_existing_customer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_existing_customer.UseSelectable = true;
            this.btn_existing_customer.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // frm_selectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 300);
            this.Controls.Add(this.btn_existing_customer);
            this.Controls.Add(this.btn_new_customer);
            this.Name = "frm_selectCustomer";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_selectCustomer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_new_customer;
        private MetroFramework.Controls.MetroTile btn_existing_customer;
    }
}