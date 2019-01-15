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

        private void txt_order_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            NewSpectaclesInvoice.FillFormOne(txt_order.Text, txt_orderdate.Value.ToString("YY-mm-DD"), txt_duedate.Value.ToString("YY-mm-DD"), txt_phone.Text, txt_name.Text, txt_address.Text, txt_email.Text, int.Parse(txt_age.Text), txt_proffession.Text, txt_eyeWear.Text, txt_lenses.Text, Double.Parse(txt_total.Text), cmb_pay_method.Text, cmb_pay_plan.Text, cmb_testedby.Text, Double.Parse(txt_advance.Text), Double.Parse(txt_discount.Text), Double.Parse(txt_balance.Text);
        }
    }
}
