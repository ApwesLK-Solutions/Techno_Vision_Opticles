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
        private static technovisionDataSetTableAdapters.paymentsTableAdapter payments = new technovisionDataSetTableAdapters.paymentsTableAdapter();

        public static void saveLenseOrder(MetroForm f)
        {
            //update summary
            summary.Insert(NewSpectaclesInvoice.OrderNumber, NewSpectaclesInvoice.receiptNumber, Customer.id, "S",NewSpectaclesInvoice.OrderStatus,NewSpectaclesInvoice.Balance.ToString(),"UNPAID");
            //update order
            spec_order.Insert(NewSpectaclesInvoice.receiptNumber, NewSpectaclesInvoice.OrderNumber, Customer.id, NewSpectaclesInvoice.TestedBy, NewSpectaclesInvoice.EyeWear, NewSpectaclesInvoice.Lense, NewSpectaclesInvoice.Total, NewSpectaclesInvoice.Advance, NewSpectaclesInvoice.Discount, NewSpectaclesInvoice.Balance, NewSpectaclesInvoice.DistRightSph, NewSpectaclesInvoice.DistRightCyl, NewSpectaclesInvoice.DistRightAxis, NewSpectaclesInvoice.DistLeftSph, NewSpectaclesInvoice.DistLeftCyl, NewSpectaclesInvoice.DistLeftAxis, NewSpectaclesInvoice.AddRightSph, NewSpectaclesInvoice.AddRightCyl, NewSpectaclesInvoice.AddRightAxis, NewSpectaclesInvoice.AddLeftSph, NewSpectaclesInvoice.AddLeftCyl, NewSpectaclesInvoice.AddLeftAxis, NewSpectaclesInvoice.LensType, NewSpectaclesInvoice.Frame, NewSpectaclesInvoice.PD, NewSpectaclesInvoice.SegmentHeight, NewSpectaclesInvoice.SpecialInc, NewSpectaclesInvoice.Remarks, NewSpectaclesInvoice.OrderStatus, DateTime.Parse(NewSpectaclesInvoice.OrderDate), DateTime.Parse(NewSpectaclesInvoice.DueDate), NewSpectaclesInvoice.PayMethod, NewSpectaclesInvoice.PayPlan);

            //update receipt
            payments.Insert(NewSpectaclesInvoice.OrderNumber, NewSpectaclesInvoice.receiptNumber + "- 01", NewSpectaclesInvoice.Advance, DateTime.Now.Date);
            MSG.SUCCESS(f, "Saved!");
        }
    }
}
