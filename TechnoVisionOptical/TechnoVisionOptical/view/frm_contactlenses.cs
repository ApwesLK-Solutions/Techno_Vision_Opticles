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
            NewContactLenseInvoice.fillFormOne(txt_order_no.Text, txt_orderdate.Value.ToString("yyyy-MM-dd"), txt_duedate.Value.ToString("yyyy-MM-dd"), cmb_pay_method.Text, cmb_pay_plan.Text, double.Parse(txt_lenseRs.Text), double.Parse(txt_advRs.Text), double.Parse(txt_balRs.Text), cmb_testby.Text,lbl_receiptNo.Text , cmb_jobType.Text , cmb_orderStatus.Text);
            new frm_contactlenses2().Show();
            
        }

        private void frm_contactlenses_Load(object sender, EventArgs e)
        {
            getNewNumbers();
        }

        public void getNewNumbers()
        {
            technovisionDataSetTableAdapters.order_summaryTableAdapter t = new technovisionDataSetTableAdapters.order_summaryTableAdapter();
            string newID = t.getMaxID().ToString();
            if(newID == "")
            {
                newID = "0";
            }
            newID = (int.Parse(newID) + 1).ToString();
            if(newID.Length < 4)
            {
                while(newID.Length < 4)
                {
                    newID = "0" + newID;
                }
            }
            newID = DateTime.Now.ToString("yy") + newID;
            txt_order_no.Text = newID;
            lbl_receiptNo.Text = "R" + newID;
        }

        private void txt_lensRef_Click(object sender, EventArgs e)
        {

        }

        private void cmb_pay_plan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_orderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_jobType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_testby_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
