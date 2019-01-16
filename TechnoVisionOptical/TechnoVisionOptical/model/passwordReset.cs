using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoVisionOptical.model
{
    class passwordReset
    {
        private string passwordOne;
        private string passwordTwo;
        private string nicNum;
        private string PhoneNum;

        public void passwordReset(String passOne, String passTwo, String nic, String phn)
        {
            passwordOne = passOne;
            passwordTwo = passTwo;
            nicNum = nic;
            PhoneNum = phn;
        }
    }
}
