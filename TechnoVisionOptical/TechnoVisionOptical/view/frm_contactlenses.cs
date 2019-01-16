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
    public partial class frm_contactlenses : MetroFramework.Forms.MetroForm
    {
        public frm_contactlenses()
        {
            InitializeComponent();
        }
        
        private void btn_next_Click(object sender, EventArgs e)
        {
            NewContactLenseInvoice.fillFormOne(txt_order_no.Text, txt_orderdate.Value.ToString("yyyy-MM-dd"), txt_duedate.Value.ToString("yyyy-MM-dd"), cmb_pay_method.Text, cmb_pay_plan.Text, double.Parse(txt_lenseRs.Text), double.Parse(txt_advRs.Text), double.Parse(txt_balRs.Text), cmb_testby.Text,lbl_receiptNo.Text);      
        }

        private void frm_contactlenses_Load(object sender, EventArgs e)
        {

        }

        
    }
}
