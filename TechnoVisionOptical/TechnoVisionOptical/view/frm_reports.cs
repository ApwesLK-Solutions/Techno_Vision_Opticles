using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoVisionOptical.reports;
using System.Windows.Forms;

namespace TechnoVisionOptical.view
{
    public partial class frm_reports : MetroFramework.Forms.MetroForm
    {
        public frm_reports()
        {
            InitializeComponent();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            new orderList().Show();
        }

        private void btn_generate_date_report_Click(object sender, EventArgs e)
        {
            dailyLenseReport lense = new dailyLenseReport();

        }
    }
}
