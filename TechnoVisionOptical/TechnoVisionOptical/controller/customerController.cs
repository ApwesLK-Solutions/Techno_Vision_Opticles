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
    }
}
