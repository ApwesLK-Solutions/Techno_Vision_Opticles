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
        private bool newCustomer = false;
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

        private void frm_specs_Load(object sender, EventArgs e)
        {

        }
        private void btn_next_Click(object sender, EventArgs e)
        { 
            /*Customer.name = txt_name.Text;
            Customer.address = txt_address.Text;
            Customer.email = txt_email.Text;
            Customer.phone = txt_phone.Text;
            Customer.profession = txt_proffession.Text;
            Customer.age = int.Parse(txt_age.Text);          
            NewSpectaclesInvoice.FillFormOne(txt_order.Text, txt_orderdate.Value.ToString("yyyy-MM-dd"), txt_duedate.Value.ToString("yyyy-MM-dd"),txt_eyeWear.Text, txt_lenses.Text, double.Parse(txt_total.Text), cmb_pay_method.Text, cmb_pay_plan.Text, cmb_testedby.Text, double.Parse(txt_advance.Text), double.Parse(txt_discount.Text), double.Parse(txt_balance.Text));          
        
             */
        }
    }
}
