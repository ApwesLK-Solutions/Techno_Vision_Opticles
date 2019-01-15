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
        private bool newCustomer = false;
        public frm_contactlenses()
        {
            InitializeComponent();
        }
        public frm_contactlenses(bool exists , string _name , string _address , string _phone , string _email , string _profession , int _age)
        {
            InitializeComponent();
            txt_address.Text = _address;
            txt_name.Text = _name;
            txt_phone.Text = _phone;
            txt_email.Text = _email;
            txt_proffession.Text = _profession;
            txt_age.Text = _age.ToString();
            newCustomer = exists;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            NewContactLenseInvoice.fillFormOne(txt_order_no.Text, txt_orderdate.Value.ToString("yy-MM-dd"), txt_duedate.Value.ToString("yy-MM-dd"), txt_name.Text, txt_address.Text, txt_address.Text, txt_email.Text, int.Parse(txt_age.Text), txt_proffession.Text, cmb_pay_method.Text, cmb_pay_plan.Text, Double.Parse(txt_lenseRs.Text), Double.Parse(txt_lensRef.Text), Double.Parse(txt_advRs.Text), txt_advRef.Text, Double.Parse(txt_balRs.Text), txt_balRef.Text);
            new frm_contactlenses2(newCustomer).Show();
        }

        private void frm_contactlenses_Load(object sender, EventArgs e)
        {

        }

        
    }
}
