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
            // TODO: This line of code loads data into the 'technovisionDataSet.lense_orders' table. You can move, or remove it, as needed.
            this.lense_ordersTableAdapter.Fill(this.technovisionDataSet.lense_orders);
            // TODO: This line of code loads data into the 'technovisionDataSet.order_summary' table. You can move, or remove it, as needed.
            this.order_summaryTableAdapter.Fill(this.technovisionDataSet.order_summary);
            // TODO: This line of code loads data into the 'technovisionDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.technovisionDataSet.customers);

        }

        private Customer c;

        private void btn_new_payment_Click(object sender, EventArgs e)
        {
            
            new frm_newPayment().Show();
        }
    }
}
