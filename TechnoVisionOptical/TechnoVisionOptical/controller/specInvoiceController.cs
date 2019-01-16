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
            spec_order.Insert(NewSpectaclesInvoice.receiptNumber, NewSpectaclesInvoice.OrderNumber, Customer.id, NewSpectaclesInvoice.TestedBy, NewSpectaclesInvoice.EyeWear, NewSpectaclesInvoice.Lense, NewSpectaclesInvoice.Total, NewSpectaclesInvoice.Advance, NewSpectaclesInvoice.Discount, NewSpectaclesInvoice.Balance, NewSpectaclesInvoice.DistRightSph, NewSpectaclesInvoice.DistRightCyl, NewSpectaclesInvoice.DistRightAxis, NewSpectaclesInvoice.DistLeftSph, NewSpectaclesInvoice.DistLeftCyl, NewSpectaclesInvoice.DistLeftAxis, NewSpectaclesInvoice.AddRightSph, NewSpectaclesInvoice.AddRightCyl, NewSpectaclesInvoice.AddRightAxis, NewSpectaclesInvoice.AddLeftSph, NewSpectaclesInvoice.AddLeftCyl, NewSpectaclesInvoice.AddLeftAxis, NewSpectaclesInvoice.LensType, NewSpectaclesInvoice.Frame, NewSpectaclesInvoice.PD, NewSpectaclesInvoice.SegmentHeight, NewSpectaclesInvoice.SpecialInc, NewSpectaclesInvoice.Remarks, NewSpectaclesInvoice.OrderStatus, DateTime.Parse(NewSpectaclesInvoice.OrderDate), DateTime.Parse(NewSpectaclesInvoice.DueDate), NewSpectaclesInvoice.PayMethod, NewSpectaclesInvoice.PayPlan);
            MSG.SUCCESS(f, "Saved!");
        }
    }
}
