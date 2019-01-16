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
            passwordReset pr = new passwordReset();
            pr.passwordResetData(txt_userName.Text, txt_new_pw.Text, txt_confirm_pw.Text, txt_nic.Text, txt_phone.Text);

            passwordResetController prc = new passwordResetController();
            prc.resetPaswordFucntion(pr,this);
        }

        private void frm_passwordReset_Load(object sender, EventArgs e)
        {

        }
    }
}
