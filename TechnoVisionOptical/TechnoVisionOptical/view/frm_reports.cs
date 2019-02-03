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
            new orderList().ShowDialog();
        }

        private void btn_generate_date_report_Click(object sender, EventArgs e)
        {
            dailyLenseReport lense = new dailyLenseReport();           
            lense.RecordSelectionFormula = "{order_summary1.order_date} = Date(" + txt_select_date_report.Value.Year.ToString() + "," + txt_select_date_report.Value.Month.ToString() + "," + txt_select_date_report.Value.Day.ToString() + ")" + " and {order_summary1.order_type} = \"L\"";
            new reportViewer(lense).Show();
            
        }

        private void btn_specsSaleDaily_Click(object sender, EventArgs e)
        {
            dailyLenseReport specs = new dailyLenseReport();
            specs.RecordSelectionFormula = "{order_summary1.order_date} = Date(" + txt_select_date_report.Value.Year.ToString() + "," + txt_select_date_report.Value.Month.ToString() + "," + txt_select_date_report.Value.Day.ToString() + ")" + " and {order_summary1.order_type} = \"S\"";
            new reportViewer(specs).Show();
        }

        private void btn_lenseSaleMonthly_Click(object sender, EventArgs e)
        {
            dailyLenseReport lense = new dailyLenseReport();
            lense.RecordSelectionFormula = "{order_summary1.order_date} in DATE(" + txt_from_date.Value.Year.ToString() + "," + txt_from_date.Value.Month.ToString() + "," + txt_from_date.Value.Day.ToString() + ") to DATE(" + txt_to_date.Value.Year.ToString() + "," + txt_to_date.Value.Month.ToString() + "," + txt_to_date.Value.Day.ToString() + ")" + " and {order_summary1.order_type} = \"L\"";
            
            new reportViewer(lense).Show();
        }

        private void btn_specSaleMonthly_Click(object sender, EventArgs e)
        {
            dailyLenseReport specs = new dailyLenseReport();
            specs.RecordSelectionFormula = "{order_summary1.order_date} in DATE(" + txt_from_date.Value.Year.ToString() + "," + txt_from_date.Value.Month.ToString() + "," + txt_from_date.Value.Day.ToString() + ") to DATE(" + txt_to_date.Value.Year.ToString() + "," + txt_to_date.Value.Month.ToString() + "," + txt_to_date.Value.Day.ToString() + ")" + " and {order_summary1.order_type} = \"S\"";

            new reportViewer(specs).Show();
        }

       
    }
}
