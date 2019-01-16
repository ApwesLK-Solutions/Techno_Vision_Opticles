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
            Customer.name = txt_name.Text;
            Customer.address = txt_address.Text;
            Customer.email = txt_email.Text;
            Customer.phone = txt_phone.Text;
            Customer.profession = txt_proffession.Text;
            Customer.age = int.Parse(txt_age.Text);
            NewContactLenseInvoice.fillFormOne(txt_order_no.Text, txt_orderdate.Value.ToString("yyyy-MM-dd"), txt_duedate.Value.ToString("yyyy-MM-dd"),cmb_pay_method.Text, cmb_pay_plan.Text, double.Parse(txt_lenseRs.Text), double.Parse(txt_lensRef.Text), double.Parse(txt_advRs.Text), txt_advRef.Text, double.Parse(txt_balRs.Text), txt_lensRef.Text);
            new frm_contactlenses2(newCustomer).Show();
        }

        private void frm_contactlenses_Load(object sender, EventArgs e)
        {

        }

        
    }
}
