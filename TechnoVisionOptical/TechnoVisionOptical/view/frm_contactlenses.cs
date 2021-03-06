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
            if (txt_advRs.Text == "" || txt_balRs.Text == "" || txt_duedate.Text == "" || txt_lenseRs.Text == "" || txt_order_no.Text == "" || txt_orderdate.Text == "")
            {
                MSG.ERROR(this, "Fields cannot be Empty...");
            }
            else 
            {
                try
                {
                    NewContactLenseInvoice.fillFormOne(txt_order_no.Text, txt_orderdate.Value.ToString("yyyy-MM-dd"), txt_duedate.Value.ToString("yyyy-MM-dd"), cmb_pay_method.Text, cmb_pay_plan.Text, double.Parse(txt_lenseRs.Text), double.Parse(txt_advRs.Text), double.Parse(txt_balRs.Text), cmb_testby.Text, lbl_receiptNo.Text, cmb_jobType.Text, cmb_orderStatus.Text);
                    new frm_contactlenses2(this).Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    MSG.ERROR(this, "Error Orccured");
                }          
            }          
            
        }

        private void frm_contactlenses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.testers' table. You can move, or remove it, as needed.
            this.testersTableAdapter.Fill(this.technovisionDataSet.testers);
            // TODO: This line of code loads data into the 'technovisionDataSet.testers' table. You can move, or remove it, as needed.
            try
            {
                getNewNumbers();
                cmb_jobType.SelectedIndex = 0;
                cmb_orderStatus.SelectedIndex = 0;
                cmb_pay_method.SelectedIndex = 0;
                cmb_pay_plan.SelectedIndex = 0;
                cmb_testby.SelectedIndex = 0;

            }
            catch(Exception)
            {
                MSG.ERROR(this, "There are no testers in the system.Add Tester to continue with Errors");
            }
           
        }

        public void getNewNumbers()
        {
            technovisionDataSetTableAdapters.order_summaryTableAdapter t = new technovisionDataSetTableAdapters.order_summaryTableAdapter();
            string newID = t.getMaxId().ToString();
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

        private void btn_cal_Click(object sender, EventArgs e)
        {
            if(txt_advRs.Text =="")
            {
                txt_advRs.Text = "0";
            }
            else if (txt_lenseRs.Text == "") 
            {
                txt_lenseRs.Text = "0";
            }

            double balance = double.Parse(txt_lenseRs.Text) - double.Parse(txt_advRs.Text);
            txt_balRs.Text = balance.ToString();
        }

        private void txt_lenseRs_TextChanged(object sender, EventArgs e)
        {
            double m;
            if (!double.TryParse(txt_lenseRs.Text, out m))
            {
                MSG.ERROR(this, "Total Amount must be in numbers");
                txt_lenseRs.Text = "0";
            }
        }

        private void txt_advRs_TextChanged(object sender, EventArgs e)
        {
            double m;
            if (!double.TryParse(txt_advRs.Text, out m))
            {
                MSG.ERROR(this, "Advance Amount must be in numbers");
                txt_advRs.Text = "0";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_advRs.Text = "0";
            txt_lenseRs.Text = "0";
            txt_balRs.Text = "0";
        }
    }
}
