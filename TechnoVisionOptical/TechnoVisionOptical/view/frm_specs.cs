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
    public partial class frm_specs : MetroFramework.Forms.MetroForm
    {
        public frm_specs()
        {
            InitializeComponent();
        }
        public frm_specs(bool exists, string _name, string _address, string _phone, string _email, string _profession, int _age)
        {
            /*InitializeComponent();
            txt_address.Text = _address;
            txt_name.Text = _name;
            txt_phone.Text = _phone;
            txt_email.Text = _email;
            txt_proffession.Text = _profession;
            txt_age.Text = _age.ToString();
            newCustomer = exists;*/
        }
        public void getNewNumbers()
        {
            technovisionDataSetTableAdapters.order_summaryTableAdapter t = new technovisionDataSetTableAdapters.order_summaryTableAdapter();
            string newID = t.getMaxId().ToString();
            if (newID == "")
            {
                newID = "0";
            }
            newID = (int.Parse(newID) + 1).ToString();
            if (newID.Length < 4)
            {
                while (newID.Length < 4)
                {
                    newID = "0" + newID;
                }
            }
            newID = DateTime.Now.ToString("yy") + newID;
            txt_order.Text = newID;
            lbl_receiptNo.Text = "R" + newID;
            
        }
        private void frm_specs_Load(object sender, EventArgs e)
        {
            getNewNumbers();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {                   
            NewSpectaclesInvoice.FillFormOne(txt_order.Text, txt_orderdate.Value.ToString("yyyy-MM-dd"), txt_duedate.Value.ToString("yyyy-MM-dd"),double.Parse(txt_eyeWear.Text),double.Parse( txt_lenses.Text), double.Parse(txt_total.Text), cmb_pay_method.Text, cmb_pay_plan.Text, cmb_testedby.Text, double.Parse(txt_advance.Text), double.Parse(txt_discount.Text), double.Parse(txt_balance.Text),cmb_orderStatus.Text,lbl_receiptNo.Text);
            new frm_specs2().Show();
        }
    }
}
