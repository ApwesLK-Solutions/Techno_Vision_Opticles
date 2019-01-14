using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnoVisionOptical.view
{
    public partial class frm_dashboard : MetroFramework.Forms.MetroForm
    {
        public frm_dashboard()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this,"Test Message", "Tset");
            //MessageBox.Show("Hello this is a msgbox", "Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
