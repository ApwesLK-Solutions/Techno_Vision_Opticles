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
    public partial class frm_customer : MetroFramework.Forms.MetroForm
    {
        public frm_customer()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Customer.name = txt_name.Text;
            Customer.address = txt_address.Text;
            Customer.age = int.Parse(txt_age.Text);
            Customer.email = txt_email.Text;
            Customer.phone = txt_phone.Text;
            Customer.profession = txt_proffession.Text;
            Customer.saveCustomer(this);
            
                
            
        }

        
    }
}
