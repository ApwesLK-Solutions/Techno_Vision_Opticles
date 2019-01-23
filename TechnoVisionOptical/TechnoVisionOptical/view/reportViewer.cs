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
    public partial class reportViewer : Form
    {

        private CrystalDecisions.CrystalReports.Engine.ReportDocument rpt;
        public reportViewer(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt)
        {
            InitializeComponent();
            this.rpt = rpt;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
