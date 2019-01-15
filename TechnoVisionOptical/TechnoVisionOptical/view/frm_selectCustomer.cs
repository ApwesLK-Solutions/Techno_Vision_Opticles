using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVisionOptical.controller;
namespace TechnoVisionOptical.view
{
    public partial class frm_selectCustomer : MetroFramework.Forms.MetroForm
    {

        private string InvoiceType;
        public frm_selectCustomer(string type)
        {
            InitializeComponent();
            InvoiceType = type;
        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
            if(InvoiceType == "L")
            {
                new frm_contactlenses().Show();
            }
            else
            {
                new frm_specs().Show();
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (InvoiceType == "L")
            {
                customerController.fillLenseFormDataByCustomerID(1, this);
            }
            else
            {
                customerController.fillSpecFormDataByCustomerID(1, this);
            }
        }

        private void frm_selectCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
