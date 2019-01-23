using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoVisionOptical.controller;

namespace TechnoVisionOptical.model
{
    class NewSpectaclesInvoice
    {
        public static string receiptNumber;
        public static string OrderNumber;
        public static string OrderDate;
        public static string DueDate;
        public static double EyeWear;
        public static double Lense;
        public static double Total;
        public static string PayMethod;
        public static string PayPlan;
        public static string TestedBy;
        public static double Advance;
        public static double Discount;
        public static double Balance;
        public static string OrderStatus;

        public static string DistRightSph;
        public static string DistRightCyl;
        public static string DistRightAxis;
        public static string DistLeftSph;
        public static string DistLeftCyl;
        public static string DistLeftAxis;
        public static string AddRightSph;
        public static string AddRightCyl;
        public static string AddRightAxis;
        public static string AddLeftSph;
        public static string AddLeftCyl;
        public static string AddLeftAxis;
        public static string LensType;
        public static string Frame;
        public static string PD;
        public static string SegmentHeight;
        public static string SpecialInc;
        public static string Remarks;

        public static void FillFormOne( string _OrderNumber, string _OrderDate, String _DueDate, double _EyeWear, double _Lense, double _Total, string _PayMethod, string _PayPlan, string _TestedBy, double _Advance, double _Discount, double _Balance , string _orderStatus , string _receiptNumber)
        {
            receiptNumber = _receiptNumber;
            OrderStatus = _orderStatus;
            OrderNumber = _OrderNumber;
            OrderDate = _OrderDate;
            DueDate = _DueDate;
            EyeWear = _EyeWear;
            Lense = _Lense;
            Total = _Total;
            PayMethod = _PayMethod;
            PayPlan = _PayPlan;
            TestedBy = _TestedBy;
            Advance = _Advance;
            Discount = _Discount;
            Balance = _Balance;
        }

        public static void FillFormTwo(string _DistRightSph, string _DistRightCyl, string _DistRightAxis, string _DistLeftSph, string _DistLeftCyl, string _DistLeftAxis, string _AddRightSph, string _AddRightCyl, string _AddRightAxis, string _AddLeftSph, string _AddLeftCyl, string _AddLeftAxis, string _LensType, string _Frame, string _PD, string _SegmentHeight, string _SpecialInc, string _Remarks)
        {
            DistRightSph = _DistRightSph;
            DistRightCyl = _DistRightCyl;
            DistRightAxis = _DistRightAxis;
            DistLeftSph = _DistLeftAxis;
            DistLeftCyl = _DistLeftCyl;
            DistLeftAxis = _DistLeftAxis;
            AddRightSph = _AddRightSph;
            AddRightCyl = _AddRightCyl;
            AddRightAxis = _AddRightAxis;
            AddLeftSph = _AddLeftSph;
            AddLeftCyl = _AddLeftCyl;
            AddLeftAxis = _AddLeftAxis;
            LensType = _LensType;
            Frame = _Frame;
            PD = _PD;
            SegmentHeight = _SegmentHeight;
            SpecialInc = _SpecialInc;
            Remarks = _Remarks;
        }

        public static void save(MetroFramework.Forms.MetroForm f)
        {
            specInvoiceController.saveLenseOrder(f);
        }


    }
}
