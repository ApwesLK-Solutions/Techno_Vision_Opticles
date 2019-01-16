using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoVisionOptical.model;
using TechnoVisionOptical.view;
namespace TechnoVisionOptical.controller
{
    class customerController
    {
       
        
        private static technovisionDataSetTableAdapters.customersTableAdapter CustTable = new technovisionDataSetTableAdapters.customersTableAdapter();
        private static technovisionDataSet.customersDataTable dtable = CustTable.GetData();
        private static technovisionDataSet.customersRow row;

        public static bool register(MetroFramework.Forms.MetroForm ui)
        {
            CustTable.Insert(Customer.name, Customer.address, Customer.profession, Customer.age, Customer.phone, Customer.email);
            return true;
        }

        public static void fillSpecFormDataByCustomerID(int custID , MetroFramework.Forms.MetroForm ui)
        {
            try
            {
                row = dtable.FindBycustomerId(custID);
                new frm_specs(true, row.name, row.address, row.phone, row.email, row.profession, row.age).Show();
                Customer.id = custID;
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                //show msg (Error Loading Customer Details)
            }
            
        }

        public static void fillLenseFormDataByCustomerID(int custID, MetroFramework.Forms.MetroForm ui)
        {
            try
            {
                row = dtable.FindBycustomerId(custID);
                new frm_contactlenses(true , row.name, row.address, row.phone, row.email, row.profession, row.age).Show();
                Customer.id = custID;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                //show msg (Error Loading Customer Details)
            }

        }
    }
}
