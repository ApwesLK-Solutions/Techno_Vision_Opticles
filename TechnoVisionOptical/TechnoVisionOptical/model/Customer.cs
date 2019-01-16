using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoVisionOptical.controller;
namespace TechnoVisionOptical.model
{
    class Customer
    {
        public static int id;
        public static string name;
        public static string address;
        public static int age;
        public static string profession;
        public static string phone;
        public static string email;

        public static void SetCustomerData(string _name, string _address , int _age , string _profession , string _phone , string _email)
        {
            name = _name;
            address = _address;
            email = _email;
            phone = _phone;
            profession = _profession;
            age = _age;
        }
        public static void SetCustomerDataWithID(int _id , string _name, string _address, int _age, string _profession, string _phone, string _email)
        {
            id = _id;
            name = _name;
            address = _address;
            email = _email;
            phone = _phone;
            profession = _profession;
            age = _age;
        }

        public static bool saveCustomer(MetroFramework.Forms.MetroForm ui)
        {
            return customerController.register(ui);
        }
    }
}
