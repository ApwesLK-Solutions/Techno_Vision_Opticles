using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVisionOptical.model;

namespace TechnoVisionOptical.view
{
    public partial class frm_newPayment : MetroFramework.Forms.MetroForm
    {
        private string OID;
        public frm_newPayment(string orderID)
        {
            InitializeComponent();
            this.OID = orderID;
            Txt_orderNum.Text = OID;
        }

        private string getReceiptNumber(string order_id)
        {
            try
            {
                TechnoVisionOptical.technovisionDataSetTableAdapters.paymentsTableAdapter payments = new technovisionDataSetTableAdapters.paymentsTableAdapter();
                technovisionDataSet.paymentsDataTable dt = payments.GetDataByOrderNumber(order_id);

                 int receiptCount = dt.Rows.Count;
                 decimal i = 0;
                 string postfix;
                 foreach (TechnoVisionOptical.technovisionDataSet.paymentsRow row in dt.Rows)
                 {

                     if(i < decimal.Parse(row.reciept_no.ToString().Substring(9,2)))
                     {
                         //MessageBox.Show(row.reciept_no.ToString().Substring(9, 2));
                         i = decimal.Parse(row.reciept_no.ToString().Substring(9, 2));
                     }
                 }
                 i += 1;
                 if (i.ToString().Length != 2)
                 {
                     postfix = "0" + i.ToString();
                 }
                 else
                 {
                     postfix = i.ToString();
                 }
                 return "R"+order_id+"- "+postfix;
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        private string getDueAmount(string order_id)
        {
            technovisionDataSetTableAdapters.order_summaryTableAdapter summary = new technovisionDataSetTableAdapters.order_summaryTableAdapter();
            return summary.GetDueAmountByOrderID(order_id).ToString();
        }
        private void frm_newPayment_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.technovisionDataSet.payments);
            paymentsBindingSource.Filter = "order_id = '" + OID + "'";
            txt_receiptNumber.Text = getReceiptNumber(OID);
            txt_dueAmount.Text = getDueAmount(OID);
            }
            catch(Exception)
            {
                MSG.ERROR(this, "can not Load. try again Later");
            }
            
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            try
            {
                //save the receipt
            technovisionDataSetTableAdapters.paymentsTableAdapter payments = new technovisionDataSetTableAdapters.paymentsTableAdapter();
            payments.Insert(Txt_orderNum.Text, txt_receiptNumber.Text, double.Parse(txt_amount.Text), DateTime.Now.Date);

            //update due amount
            technovisionDataSetTableAdapters.QueriesTableAdapter q = new technovisionDataSetTableAdapters.QueriesTableAdapter();
            double due = double.Parse(txt_dueAmount.Text);
            double amount = double.Parse(txt_amount.Text);
            double newDue = due - amount;
            q.UpdateDueAmount(newDue.ToString(), OID);
            MSG.SUCCESS(this, "Payment Made Successfully...");
            this.Close();
            }
            catch
            {
                MSG.ERROR(this, "Can not Pay amount. please Restart the application and Try again...");
            }
        }

       
    }
}
