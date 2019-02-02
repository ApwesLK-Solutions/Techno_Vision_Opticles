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
    public partial class frm_specs : MetroFramework.Forms.MetroForm
    {
        public frm_specs()
        {
            InitializeComponent();
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
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.testers' table. You can move, or remove it, as needed.
                this.testersTableAdapter.Fill(this.technovisionDataSet.testers);
                getNewNumbers();
                cmb_orderStatus.SelectedIndex = 0;
                cmb_pay_method.SelectedIndex = 0;
                cmb_pay_plan.SelectedIndex = 0;
                cmb_testedby.SelectedIndex = 0;
                txt_duedate.Value = DateTime.Now;
                txt_orderdate.Value = DateTime.Now;
            }
            catch(Exception)
            {
                MSG.ERROR(this, "Can not Load.Please Try again...");
            }
            
            
        }
        private void btn_next_Click(object sender, EventArgs e)
        {   
            if(txt_lenses.Text =="0"||txt_eyeWear.Text=="0" || txt_advance.Text=="0" || txt_total.Text =="0" ||txt_balance.Text=="" || txt_discount.Text=="")
            {
                MSG.ERROR(this, "Fields can not be empty...");
            }
            else
            {
                NewSpectaclesInvoice.FillFormOne(txt_order.Text, txt_orderdate.Value.ToString("yyyy-MM-dd"), txt_duedate.Value.ToString("yyyy-MM-dd"), double.Parse(txt_eyeWear.Text), double.Parse(txt_lenses.Text), double.Parse(txt_total.Text), cmb_pay_method.Text, cmb_pay_plan.Text, cmb_testedby.Text, double.Parse(txt_advance.Text), double.Parse(txt_discount.Text), double.Parse(txt_balance.Text), cmb_orderStatus.Text, lbl_receiptNo.Text);
                new frm_specs2().Show();
            }
            
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if(txt_total.Text=="0")
            {
                MSG.ERROR(this, "Total can not be Zero(0)");
            }
            else if (txt_advance.Text == "")
            {
                txt_advance.Text = "0";
            }
            
            else if(txt_discount.Text == "")
            {
                txt_discount.Text = "0";
            }

            double sellprice = double.Parse(txt_total.Text) - double.Parse(txt_discount.Text);
            double balance = sellprice - double.Parse(txt_advance.Text);
             txt_balance.Text = balance.ToString();
        }

        private void calc_total_Click(object sender, EventArgs e)
        {
            if (txt_eyeWear.Text == "")
            {
                txt_eyeWear.Text = "0";
            }
            else if(txt_lenses.Text =="0")
            {
                txt_lenses.Text = "0";
            }
            double total = double.Parse(txt_eyeWear.Text) + double.Parse(txt_lenses.Text);
            txt_total.Text = total.ToString();
        }

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            txt_advance.Text = "0";
            txt_discount.Text = "0";
            txt_eyeWear.Text = "0";
            txt_lenses.Text = "0";
            txt_total.Text = "0";
            txt_balance.Text = "0";

        }

        private void txt_eyeWear_TextChanged(object sender, EventArgs e)
        {
            double m;
            if (!double.TryParse(txt_eyeWear.Text, out m))
            {
                MSG.ERROR(this, "Eye Wear Amount must be in numbers");
                txt_eyeWear.Text = "0";
            }
        }

        private void txt_lenses_TextChanged(object sender, EventArgs e)
        {
            double m;
            if (!double.TryParse(txt_lenses.Text, out m))
            {
                MSG.ERROR(this, "Lenses Amount must be in numbers");
                txt_lenses.Text = "0";
            }
        }

        private void txt_advance_TextChanged(object sender, EventArgs e)
        {
            double m;
            if (!double.TryParse(txt_advance.Text, out m))
            {
                MSG.ERROR(this, "Advance Amount must be in numbers");
                txt_advance.Text = "0";
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            double m;
            if (!double.TryParse(txt_discount.Text, out m))
            {
                MSG.ERROR(this, "Discount Amount must be in numbers");
                txt_discount.Text = "0";
            }
        }
    }
}
