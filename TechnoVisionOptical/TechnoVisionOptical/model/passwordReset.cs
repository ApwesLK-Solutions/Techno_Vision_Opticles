using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoVisionOptical.model
{
    class passwordReset
    {
        public string user;
        public string passwordOne;
        public string passwordTwo;
        public string nicNum;
        public string PhoneNum;
        
        public void passwordResetData(String userName, String passOne, String passTwo, String nic, String phn)
        {
            passwordOne = passOne;
            passwordTwo = passTwo;
            nicNum = nic;
            PhoneNum = phn;
            user = userName;
        }
    }
}
