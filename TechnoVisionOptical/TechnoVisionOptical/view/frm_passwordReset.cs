using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVisionOptical.model;
using TechnoVisionOptical.controller;

namespace TechnoVisionOptical.view
{
    public partial class frm_passwordReset : MetroFramework.Forms.MetroForm
    {
        public frm_passwordReset()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (txt_new_pw.Text == txt_confirm_pw.Text)
            {
                user u = new user(txt_userName.Text, txt_nic.Text, txt_phone.Text);
                userController.reset(u, txt_new_pw.Text, this);
            }
            else
            {
                MSG.ERROR(this, "Confirmation Password is not matching...");
            }
                
            
        }

        private void frm_passwordReset_Load(object sender, EventArgs e)
        {

        }
 
    }
}
