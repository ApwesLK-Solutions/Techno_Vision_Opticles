using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using TechnoVisionOptical.model;
namespace TechnoVisionOptical.controller
{
    class contactLenseInvoiceController
    {
        private static technovisionDataSetTableAdapters.order_summaryTableAdapter summary = new technovisionDataSetTableAdapters.order_summaryTableAdapter();
        
        public static void saveLenseOrder(MetroForm f)
        {
            //update summary
            summary.Insert(NewContactLenseInvoice.OrderNumber, NewContactLenseInvoice.ReceiptNumber, Customer.id, "L");
        }
    }
}
