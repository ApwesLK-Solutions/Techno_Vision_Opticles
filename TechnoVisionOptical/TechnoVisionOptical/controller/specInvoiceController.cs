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
            summary.Insert(NewSpectaclesInvoice.OrderNumber, Customer.id, "S", NewSpectaclesInvoice.Balance, NewSpectaclesInvoice.OrderStatus, DateTime.Parse(NewSpectaclesInvoice.OrderDate), DateTime.Parse(NewSpectaclesInvoice.DueDate), NewSpectaclesInvoice.PayMethod, NewSpectaclesInvoice.PayPlan, NewSpectaclesInvoice.Total, NewSpectaclesInvoice.Advance, NewSpectaclesInvoice.Discount);
            //update order
            spec_order.Insert(NewSpectaclesInvoice.OrderNumber, NewSpectaclesInvoice.TestedBy, NewSpectaclesInvoice.EyeWear.ToString(), NewSpectaclesInvoice.Lense.ToString(),NewSpectaclesInvoice.DistRightSph, NewSpectaclesInvoice.DistRightCyl, NewSpectaclesInvoice.DistRightAxis, NewSpectaclesInvoice.DistLeftSph, NewSpectaclesInvoice.DistLeftCyl, NewSpectaclesInvoice.DistLeftAxis, NewSpectaclesInvoice.AddRightSph, NewSpectaclesInvoice.AddRightCyl, NewSpectaclesInvoice.AddRightAxis, NewSpectaclesInvoice.AddLeftSph, NewSpectaclesInvoice.AddLeftCyl, NewSpectaclesInvoice.AddLeftAxis, NewSpectaclesInvoice.LensType, NewSpectaclesInvoice.Frame, NewSpectaclesInvoice.PD, NewSpectaclesInvoice.SegmentHeight, NewSpectaclesInvoice.SpecialInc, NewSpectaclesInvoice.Remarks);

            //update receipt
            payments.Insert(NewSpectaclesInvoice.OrderNumber, NewSpectaclesInvoice.receiptNumber + "- 01", NewSpectaclesInvoice.Advance, DateTime.Now.Date);
            //MSG.SUCCESS(f, "Saved!");
        }
    }
}
