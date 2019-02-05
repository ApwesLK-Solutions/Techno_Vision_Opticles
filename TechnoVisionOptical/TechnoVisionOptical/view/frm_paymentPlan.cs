﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVisionOptical.model;
using TechnoVisionOptical.reports;
namespace TechnoVisionOptical.view
{
    public partial class frm_paymentPlan : MetroFramework.Forms.MetroForm
    {
        public frm_paymentPlan()
        {
            InitializeComponent();
        }

        private void frm_paymentPlan_Load(object sender, EventArgs e)
        {
            try
            {
                 // TODO: This line of code loads data into the 'technovisionDataSet.CustomerPayments' table. You can move, or remove it, as needed.
            this.customerPaymentsTableAdapter.Fill(this.technovisionDataSet.CustomerPayments);
            }
           catch(Exception)
            {
                MSG.ERROR(this, "Can not Load Data. Try Again...");
            }
        }

        private Customer c;

      

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_order_no_TextChanged(object sender, EventArgs e)
        {
            customerPaymentsBindingSource.Filter = ("order_number LIKE '%" + txt_order_no.Text + "%' OR reciept_no LIKE '%" + txt_order_no.Text + "%'");
            
        }

        private void btn_new_payment_Click(object sender, EventArgs e)
        {
            this.Close();
            new frm_newPayment(metroGrid1.SelectedRows[0].Cells[0].Value.ToString()).Show();
            
        }

        private void PrintReceipt_Click(object sender, EventArgs e)
        {
            paymentReceipt rpt = new paymentReceipt();
            rpt.RecordSelectionFormula = "{payments1.reciept_no} = " + "\"" + metroGrid1.SelectedRows[0].Cells[1].Value.ToString() +"\"";
            new reportViewer(rpt).Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            metroGrid1.Refresh();
        }
        
        
    }
}
