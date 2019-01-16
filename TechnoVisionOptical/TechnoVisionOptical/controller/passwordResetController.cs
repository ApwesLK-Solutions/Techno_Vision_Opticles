using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoVisionOptical.model;
using MetroFramework.Forms;

namespace TechnoVisionOptical.controller
{
    class passwordResetController
    {
        public void resetPaswordFucntion(passwordReset resetPw, MetroForm ui) 
        {
            technovisionDataSetTableAdapters.usersTableAdapter UserAdapter = new technovisionDataSetTableAdapters.usersTableAdapter();
            technovisionDataSet.usersDataTable UserTable = UserAdapter.GetData();
            technovisionDataSet.usersRow row;

            try
            {
                row = UserTable.FindByusername(resetPw.user);

                String nic = row.nic.ToString();
                String phoneNumber = row.contactNumber.ToString();

                if (resetPw.nicNum == nic && resetPw.PhoneNum == phoneNumber)
                {


                    MSG.SUCCESS(ui, "Password Changed Successfully");
                }
                else if (resetPw.nicNum != nic && resetPw.PhoneNum == phoneNumber)
                {
                    MSG.ERROR(ui, "Your NIC Number is Incorrect");
                }
                else if (resetPw.nicNum == nic && resetPw.PhoneNum != phoneNumber)
                {
                    MSG.ERROR(ui, "Your Phone Number is Incorrect");
                }
                else if (resetPw.nicNum != nic && resetPw.PhoneNum != phoneNumber)
                {
                    MSG.ERROR(ui, "Both your NIC Number & Phone Number are Incorrect");
                }
            }
        }            
    }
}
