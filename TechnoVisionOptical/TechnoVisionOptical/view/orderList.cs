using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.order_summaryTableAdapter.Fill(this.technovisionDataSet.order_summary);

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if(grid_order_list.SelectedRows[0].Cells[3].Value.ToString() == "L")
            {
                lenseOrders.UpdateStatusByOrderNumber(grid_order_list.SelectedRows[0].Cells[0].Value.ToString(), "CANCELED");
                order_summaryTableAdapter.UpdateStatusByID("CANCELED", grid_order_list.SelectedRows[0].Cells[0].Value.ToString());
                this.order_summaryTableAdapter.Fill(this.technovisionDataSet.order_summary);

            }
            if(grid_order_list.SelectedRows[0].Cells[3].Value.ToString() == "S")
            {
                spec_orders.UpdateStatusByOrderNumber(grid_order_list.SelectedRows[0].Cells[0].Value.ToString(), "CANCELED");
                order_summaryTableAdapter.UpdateStatusByID("CANCELED", grid_order_list.SelectedRows[0].Cells[0].Value.ToString());
                this.order_summaryTableAdapter.Fill(this.technovisionDataSet.order_summary);

            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }
    }
}
