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
            // TODO: This line of code loads data into the 'technovisionDataSet.payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.technovisionDataSet.payments);
           

        }

        private Customer c;

        private void btn_new_payment_Click(object sender, EventArgs e)
        {
            
            new frm_newPayment().Show();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
