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
namespace TechnoVisionOptical.view
{
    public partial class orderList : MetroFramework.Forms.MetroForm
    {
        private technovisionDataSetTableAdapters.lense_ordersTableAdapter lenseOrders = new technovisionDataSetTableAdapters.lense_ordersTableAdapter();
        private technovisionDataSetTableAdapters.specs_ordersTableAdapter spec_orders = new technovisionDataSetTableAdapters.specs_ordersTableAdapter();
        public orderList()
        {
            InitializeComponent();
        }

        private void orderList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.order_summary' table. You can move, or remove it, as needed.
            try
            {
                this.order_summaryTableAdapter.Fill(this.technovisionDataSet.order_summary);
                cmb_mark_as.SelectedIndex = 0;
            }
          catch(Exception)
            {
                MSG.ERROR(this, "UNKOWN ERROR. try Again Later");
            }

        }

        private void grid_order_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid_order_list.SelectedRows[0].Cells[2].Value.ToString() == "L")
                {
                    order_summaryTableAdapter.UpdateStatusByID(cmb_mark_as.Text, grid_order_list.SelectedRows[0].Cells[0].Value.ToString());
                    this.order_summaryTableAdapter.Fill(this.technovisionDataSet.order_summary);
                    MSG.SUCCESS(this, "Order Status Changed to " + cmb_mark_as.Text);
                }
                if (grid_order_list.SelectedRows[0].Cells[2].Value.ToString() == "S")
                {
                    order_summaryTableAdapter.UpdateStatusByID(cmb_mark_as.Text, grid_order_list.SelectedRows[0].Cells[0].Value.ToString());
                    this.order_summaryTableAdapter.Fill(this.technovisionDataSet.order_summary);
                    MSG.SUCCESS(this, "Order Status Changed to " + cmb_mark_as.Text);
                }
            }
            catch(Exception)
            {
                MSG.ERROR(this,"Can not change. Try again...");
            }
            
        }

        private void btn_print_comp_Click(object sender, EventArgs e)
        {
            string type = grid_order_list.SelectedRows[0].Cells[2].Value.ToString();
            string orderNumber = grid_order_list.SelectedRows[0].Cells[0].Value.ToString();
            if (type == "S")
            {
                spec_Company rpt = new spec_Company();
                rpt.RecordSelectionFormula = "{specs_orders1.order_number} = " + "\"" + orderNumber + "\"";
                new reportViewer(rpt).Show();
               
            }
            else
            {
                lensesCompany rpt = new lensesCompany();
                rpt.RecordSelectionFormula = "{lense_orders1.order_number} = " + "\"" + orderNumber + "\"";
                new reportViewer(rpt).Show();
            }
        }

        private void btn_print_cust_Click(object sender, EventArgs e)
        {
            string type = grid_order_list.SelectedRows[0].Cells[2].Value.ToString();
            string orderNumber = grid_order_list.SelectedRows[0].Cells[0].Value.ToString();
            string rno = "R" + orderNumber + "- 01";

            if (type == "S")
            {
                Spec_customer rpt = new Spec_customer();
                rpt.RecordSelectionFormula = "{specs_orders1.order_number} = " + "\"" + orderNumber + "\" and {payments1.reciept_no} = "+"\""+rno+"\"";
                new reportViewer(rpt).Show();
            }
            if (type == "L")
            {
                lensesCustomer rpt = new lensesCustomer();
                rpt.RecordSelectionFormula = "{lense_orders1.order_number} = " + "\"" + orderNumber + "\" and {payments1.reciept_no} = " + "\"" + rno + "\"";
                new reportViewer(rpt).Show();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            ordersummaryBindingSource.Filter = ("order_number LIKE '%" + txt_search.Text + "%'");
        }

    }
}
