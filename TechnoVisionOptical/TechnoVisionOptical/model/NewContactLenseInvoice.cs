using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoVisionOptical.model
{
    class NewContactLenseInvoice
    {
        public static string _OrderNumber;
        public static string _OrderDate;
        public static string _DueDate;
        public static string _Name;
        public static string _Address;
        public static string _PhoneNumber;
        public static string _EmailAddress;
        public static int    _Age;
        public static string _Profesion;
        public static string _PaymentMethod;
        public static string _PaymentPlan;
        public static double _LenseTotal;
        public static double _LenseTotalRef;
        public static double _LenseAdvance;
        public static string _LenseAdvanceRef;
        public static double _LenseBalance;
        public static string _LenseBalanceRef;

        public static void fillFormOne(string OrderNumber, string OrderDate, string DueDate, string Name, string Address, string PhoneNumber, string EmailAddress, int Age, string Profesion, string PaymentMethod, string PaymentPlan, double LenseTotal, double LenseTotalRef, double LenseAdvance, string LenseAdvanceRef, double LenseBalance, string LenseBalanceRef)
        {
            _OrderNumber = OrderNumber;
            _OrderDate = OrderDate;
            _DueDate = DueDate;
            _Name = Name;
            _Address = Address;
            _PhoneNumber = PhoneNumber;
            _EmailAddress = EmailAddress;
            _Age = Age;
            _Profesion = Profesion;
            _PaymentMethod = PaymentMethod;
            _PaymentPlan = PaymentPlan;
            _LenseTotal = LenseTotal;
            _LenseTotalRef = LenseTotalRef;
            _LenseAdvance = LenseAdvance;
            _LenseAdvanceRef = LenseAdvanceRef;
            _LenseBalance = LenseBalance;
            _LenseBalanceRef = LenseBalanceRef;
        }
        
    }
}
