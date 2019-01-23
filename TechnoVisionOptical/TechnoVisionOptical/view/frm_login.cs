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
    public partial class frm_login : MetroFramework.Forms.MetroForm
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if((txt_username.Text == "" )|| (txt_password.Text==""))
                {
                    MSG.ERROR(this, "Username or Password Empty...");
                }
                else
                {
                    user u = new user(txt_username.Text, txt_password.Text);
                    u.Login(this); 
                }

            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MSG.ERROR(this, "Can not Login. Please Try Again... "+ex.Message);
            }
            
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frm_passwordReset().Show();
        }

       
    }
}
