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
    public partial class frm_paymentPlan : MetroFramework.Forms.MetroForm
    {
        public frm_paymentPlan()
        {
            InitializeComponent();
        }

        private void frm_paymentPlan_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_payment_Click(object sender, EventArgs e)
        {
            Customer c;
            //new frm_newPayment(c).Show();
        }
    }
}
