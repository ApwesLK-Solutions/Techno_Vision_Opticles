using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoVisionOptical.model;
namespace TechnoVisionOptical.controller
{
    class customerController
    {
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
    }
}
