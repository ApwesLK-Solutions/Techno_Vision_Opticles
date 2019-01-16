using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoVisionOptical.model;
using MetroFramework.Forms;
namespace TechnoVisionOptical.controller
{
    class specInvoiceController
    {
        private static technovisionDataSetTableAdapters.order_summaryTableAdapter summary = new technovisionDataSetTableAdapters.order_summaryTableAdapter();
        private static technovisionDataSetTableAdapters.specs_ordersTableAdapter spec_order = new technovisionDataSetTableAdapters.specs_ordersTableAdapter();
        public static void saveLenseOrder(MetroForm f)
        {
            //update summary
            summary.Insert(NewContactLenseInvoice.OrderNumber, NewContactLenseInvoice.ReceiptNumber, Customer.id, "L");

            //update order
            //spec_order.Insert()
        }
    }
}
