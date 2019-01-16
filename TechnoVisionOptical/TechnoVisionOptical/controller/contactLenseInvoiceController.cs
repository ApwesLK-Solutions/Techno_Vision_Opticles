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
        private static technovisionDataSetTableAdapters.lense_ordersTableAdapter lense_order = new technovisionDataSetTableAdapters.lense_ordersTableAdapter();
        public static void saveLenseOrder(MetroForm f)
        {
            //update summary
            summary.Insert(NewContactLenseInvoice.OrderNumber, NewContactLenseInvoice.ReceiptNumber, Customer.id, "L");

            //update order
            lense_order.Insert(NewContactLenseInvoice.ReceiptNumber, NewContactLenseInvoice.OrderNumber, int.Parse(Customer.id.ToString()), NewContactLenseInvoice.JobType, NewContactLenseInvoice.TestedBy, Double.Parse(NewContactLenseInvoice.LenseTotal.ToString()), Double.Parse(NewContactLenseInvoice.LenseAdvance.ToString()), Double.Parse(NewContactLenseInvoice.LenseBalance.ToString()), NewContactLenseInvoice.OldRightSph, NewContactLenseInvoice.OldRightCyl, NewContactLenseInvoice.OldRightAxis, NewContactLenseInvoice.OldRightAdd, NewContactLenseInvoice.OldLeftSph, NewContactLenseInvoice.OldLeftCyl, NewContactLenseInvoice.OldLeftAxis, NewContactLenseInvoice.OldLeftAdd, NewContactLenseInvoice.PresentRightSph, NewContactLenseInvoice.PresentRightCyl, NewContactLenseInvoice.PresentRightAxis, NewContactLenseInvoice.PresentRightAdd, NewContactLenseInvoice.PresentLeftSph, NewContactLenseInvoice.PresentLeftCyl, NewContactLenseInvoice.PresentLeftAxis, NewContactLenseInvoice.PresentLeftAdd, NewContactLenseInvoice.RightBc, NewContactLenseInvoice.RightPow, NewContactLenseInvoice.RightDia, NewContactLenseInvoice.RightDesz, NewContactLenseInvoice.LeftBc, NewContactLenseInvoice.LeftPow, NewContactLenseInvoice.LeftDia, NewContactLenseInvoice.LeftDesz, NewContactLenseInvoice.TrailLens, NewContactLenseInvoice.OverRefract, NewContactLenseInvoice.KReading, NewContactLenseInvoice.BlinkTest, NewContactLenseInvoice.SpecialIns, NewContactLenseInvoice.Remarks, NewContactLenseInvoice.OrderStatus,DateTime.Parse(NewContactLenseInvoice.OrderDate),DateTime.Parse(NewContactLenseInvoice.DueDate) , NewContactLenseInvoice.PaymentMethod , NewContactLenseInvoice.PaymentPlan);
        }
    }
}
