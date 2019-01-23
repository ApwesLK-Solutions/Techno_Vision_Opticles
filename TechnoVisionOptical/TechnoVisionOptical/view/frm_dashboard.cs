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
            new frm_customerList("L").Show();
        }

        private void btn_OrderSpecs_Click(object sender, EventArgs e)
        {
            new frm_customerList("S").Show();
        }

        private void btn_ViewReports_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            new frm_paymentPlan().Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            new frm_productlist().Show();
        }

       
    }
}
