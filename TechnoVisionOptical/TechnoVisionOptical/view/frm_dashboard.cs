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

        private void btn_OrderCLense_Click(object sender, EventArgs e)
        {
            new frm_selectCustomer("L").Show();
        }

        private void btn_OrderSpecs_Click(object sender, EventArgs e)
        {
            new frm_selectCustomer("S").Show();
        }

        private void btn_ViewReports_Click(object sender, EventArgs e)
        {

        }

       
    }
}
