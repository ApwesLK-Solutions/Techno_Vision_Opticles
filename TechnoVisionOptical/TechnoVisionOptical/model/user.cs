using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoVisionOptical.model
{
    class user
    {
        public string username; 
        public string password;
        public string nic;
        public string fullName;
        public string contactNumber;

        public user(string username , string password , object UI)
        {

        }
        public user(string username, string password, string fullName, string nic, string contactNumber, object UI)
        {

        }
        public user(string username, string nic, string contactNumber, object UI)
        {

        }
    }
}
