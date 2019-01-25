using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVisionOptical.reports;
using TechnoVisionOptical.model;
namespace TechnoVisionOptical.view
{
    public partial class frm_orderComplete : MetroFramework.Forms.MetroForm
    {
        private int customerID;
        private string orderID;
        private string orderType;
        public frm_orderComplete(int custid , string o_nu , string o_type)
        {
            InitializeComponent();
            customerID = custid;
            orderID = o_nu;
            orderType = o_type;
        }

        private void frm_orderComplete_Load(object sender, EventArgs e)
        {

        }

        private void btn_viewCustomer_Click(object sender, EventArgs e)
        {
            if(orderType == "SPEC")
            {
                Spec_customer rpt = new Spec_customer();
                rpt.RecordSelectionFormula = "{specs_orders1.order_number} = " + "\"" + NewSpectaclesInvoice.OrderNumber + "\"";
                new reportViewer(rpt).Show();             
            }
            if (orderType == "LENSE")
            {
                lensesCustomer rpt = new lensesCustomer();
                rpt.RecordSelectionFormula ="{lense_orders1.order_number} = "+ "\"" + NewContactLenseInvoice.OrderNumber + "\"";
                new reportViewer(rpt).Show();
            }
        }

        private void btn_viewCompany_Click(object sender, EventArgs e)
        {
            if(orderType == "SPEC")
            {
                spec_Company rpt = new spec_Company();
                rpt.RecordSelectionFormula = "{specs_orders1.order_number} = " + "\"" + NewSpectaclesInvoice.OrderNumber + "\"";
                new reportViewer(rpt).Show();
            }
            if(orderType == "LENSE")
            {
                lensesCompany rpt = new lensesCompany();
                rpt.RecordSelectionFormula = "{lense_orders1.order_number} = " + "\"" + NewContactLenseInvoice.OrderNumber + "\"";
                new reportViewer(rpt).Show();
            }
        }

        private void btn_PrintCustomer_Click(object sender, EventArgs e)
        {
            if(orderType == "SPEC")
            {
                Spec_customer rpt = new Spec_customer();
                rpt.RecordSelectionFormula = "{specs_orders1.order_number} = " + "\"" + NewSpectaclesInvoice.OrderNumber + "\"";
                rpt.PrintToPrinter(1, false, 1, 1);
            }
            if(orderType =="LENSE")
            {
                lensesCustomer rpt = new lensesCustomer();
                rpt.RecordSelectionFormula = "{lense_orders1.order_number} = " + "\"" + NewContactLenseInvoice.OrderNumber + "\"";
                rpt.PrintToPrinter(1, false, 1, 1);
            }

        }

        private void btn_printCompany_Click(object sender, EventArgs e)
        {
            if(orderType == "SPEC")
            {
                spec_Company rpt = new spec_Company();
                rpt.RecordSelectionFormula = "{specs_orders1.order_number} = " + "\"" + NewSpectaclesInvoice.OrderNumber + "\"";
                rpt.PrintToPrinter(1, false, 1, 1);
            }
            if(orderType =="LENSE")
            {
                lensesCompany rpt = new lensesCompany();
                rpt.RecordSelectionFormula = "{lense_orders1.order_number} = " + "\"" + NewContactLenseInvoice.OrderNumber + "\"";
                rpt.PrintToPrinter(1, false, 1, 1);
            }
        }

        private void btn_customerData_Click(object sender, EventArgs e)
        {

        }
    }
}
