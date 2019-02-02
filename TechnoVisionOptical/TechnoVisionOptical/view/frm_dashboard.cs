using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
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
            new frm_reports().Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            new frm_customerList("D").Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            new frm_productlist().Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            new frm_paymentPlan().Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            new frm_testersList().Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            try
            { 
                System.Diagnostics.Process.Start(Application.StartupPath + "\\mysqldump.exe","-uroot -p1234 technovision --result-file=D:\\DB-BACKUPS\\"+DateTime.Now.ToString("yyyy-MM-dd")+".sql");
                MSG.SUCCESS(this, "Database Backup Sucess");
            }
            catch (Exception ex)
            {
                MSG.ERROR(this,"Backup Failed, " + ex.Message);
            }


            //MSG.ERROR(this, "Backup will be enabled in the next Build");
        }       
    }
}
