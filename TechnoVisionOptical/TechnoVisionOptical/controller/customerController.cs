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
        private static technovisionDataSet.customersDataTable dtable = new technovisionDataSet.customersDataTable();
        private static technovisionDataSet.customersRow row;
        private static technovisionDataSetTableAdapters.customersTableAdapter CustTable = new technovisionDataSetTableAdapters.customersTableAdapter();

        public static bool register(MetroFramework.Forms.MetroForm ui)
        {
            try
            {
                CustTable.Insert(Customer.name, Customer.address, Customer.profession, Customer.age, Customer.phone, Customer.email);
                return true;
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                return false;
            }
        }

        public static void fillSpecFormDataByCustomerID(int custID , MetroFramework.Forms.MetroForm ui)
        {
            try
            {
                custID = 2;
                row = dtable.FindBycustomerId(custID);
                string name = row.name;
                string address = row.address;
                string phone = row.phone;
                string email = row.email;
                string profession = row.profession;
                int age = row.age;
                new frm_specs(name, address, phone, email, profession, age).Show();
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
                new frm_contactlenses().Show();
                //new frm_contactlenses(row.name, row.address, row.phone, row.email, row.profession, row.age).Show();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                //show msg (Error Loading Customer Details)
            }

        }
    }
}
