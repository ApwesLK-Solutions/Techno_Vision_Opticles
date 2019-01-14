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
            user u = new user("LOL", "password");
            u.Login(this);
        }
    }
}
