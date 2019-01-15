using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoVisionOptical.model
{
    class NewContactLenseInvoice
    {
        public static string OrderNumber;
        public static string OrderDate;
        public static string DueDate;
        public static string Name;
        public static string Address;
        public static string PhoneNumber;
        public static string EmailAddress;
        public static int    Age;
        public static string Profesion;
        public static string PaymentMethod;
        public static string PaymentPlan;
        public static double LenseTotal;
        public static double LenseTotalRef;
        public static double LenseAdvance;
        public static string LenseAdvanceRef;
        public static double LenseBalance;
        public static string LenseBalanceRef;



        //
        public static string OldRightSph;
        public static string OldRightCyl;
        public static string OldRightAxis;
        public static string OldRightAdd;
        public static string OldLeftSph;
        public static string OldLeftCyl;
        public static string OldLeftAxis;
        public static string OldLeftAdd;
        public static string PresentLeftSph;
        public static string PresentLeftCyl;
        public static string PresentLeftAxis;
        public static string PresentLeftAdd;
        public static string PresentRightSph;
        public static string PresentRightCyl;
        public static string PresentRightAxis;
        public static string PresentRightAdd;

        public static string RightBc;
        public static string RightPow;
        public static string RightDia;
        public static string RightDesz;
        public static string LeftBc;
        public static string LeftPow;
        public static string LeftDia;
        public static string LeftDesz;

        public static string TrailLens;
        public static string OverRefract;
        public static string SpecialIns;
        public static string Remarks;
        public static string KReading;
        public static string BlinkTest;
        
        public static string RBefore;
        public static string LAfter;


        
        

        public static void fillFormOne(string _OrderNumber, string _OrderDate, string _DueDate, string _Name, string _Address, string _PhoneNumber, string _EmailAddress, int _Age, string _Profesion, string _PaymentMethod, string _PaymentPlan, double _LenseTotal, double _LenseTotalRef, double _LenseAdvance, string _LenseAdvanceRef, double _LenseBalance, string _LenseBalanceRef)
        {
            OrderNumber     = _OrderNumber;
            OrderDate       = _OrderDate;
            DueDate         = _DueDate;
            Name            = _Name;
            Address         = _Address;
            PhoneNumber     = _PhoneNumber;
            EmailAddress    = _EmailAddress;
            Age             = _Age;
            Profesion       = _Profesion;
            PaymentMethod   = _PaymentMethod;
            PaymentPlan     = _PaymentPlan;
            LenseTotal      = _LenseTotal;
            LenseTotalRef   = _LenseTotalRef;
            LenseAdvance    = _LenseAdvance;
            LenseAdvanceRef = _LenseAdvanceRef;
            LenseBalance    = _LenseBalance;
            LenseBalanceRef = _LenseBalanceRef;
        }
        
        public static void fillFormTwo(string _OldRightSph,string _OldRightCyl,string _OldRightAxis,string _OldRightAdd,string _OldLeftSph,string _OldLeftCyl,string _OldLeftAxis,string _OldLeftAdd,string _PresentLeftSph,string _PresentLeftCyl,string _PresentLeftAxis,string _PresentLeftAdd,string _PresentRightSph,string _PresentRightCyl,string _PresentRightAxis,string _PresentRightAdd,string _RightBc,string _RightPow,string _RightDia,string _RightDesz,string _LeftBc,string _LeftPow,string _LeftDia,string _LeftDesz,string _TrailLens,string _OverRefract,string _SpecialIns,string _Remarks,string _KReading,string _BlinkTest,string _RBefore,string _LAfter)
        {
             OldRightSph=_OldRightSph;
             OldRightCyl=_OldRightCyl;
             OldRightAxis=_OldRightAxis;
             OldRightAdd=_OldRightAdd;
             OldLeftSph=_OldLeftSph;
             OldLeftCyl=_OldLeftCyl;
             OldLeftAxis=_OldLeftAxis;
             OldLeftAdd=_OldLeftAdd;
             PresentLeftSph=_PresentLeftSph;
             PresentLeftCyl=_PresentLeftCyl;
             PresentLeftAxis=_PresentLeftAxis;
             PresentLeftAdd=_PresentLeftAdd;
             PresentRightSph=_PresentRightSph;
             PresentRightCyl=_PresentRightCyl;
             PresentRightAxis=_PresentRightAxis;
             PresentRightAdd=_PresentRightAdd;
             RightBc=_RightBc;
             RightPow=_RightPow;
             RightDia=_RightDia;
             RightDesz=_RightDesz;
             LeftBc=_LeftBc;
             LeftPow=_LeftPow;
             LeftDia=_LeftDia;
             LeftDesz=_LeftDesz;
             TrailLens=_TrailLens;
             OverRefract=_OverRefract;
             SpecialIns=_SpecialIns;
             Remarks=_Remarks;
             KReading=_KReading;
             BlinkTest=_BlinkTest;
             RBefore=_RBefore;
             LAfter=_LAfter;
        }

        public static void save(MetroFramework.Forms.MetroForm ui)
        {

        }
    }
}
