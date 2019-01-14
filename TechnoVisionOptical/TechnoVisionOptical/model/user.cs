using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoVisionOptical.controller;
using MetroFramework.Forms;
namespace TechnoVisionOptical.model
{
    class user
    {
        public string username; 
        public string password;
        public string nic;
        public string fullName;
        public string contactNumber;

        public user(string username , string password)
        {
            this.username = username;
            this.password = password;
        }
        public user(string username, string password, string fullName, string nic, string contactNumber)
        {
            this.username = username;
            this.password = password;
            this.nic = nic;
            this.contactNumber = contactNumber;
            this.fullName = fullName;
        }
        public user(string username, string nic, string contactNumber)
        {
            this.username = username;
            this.contactNumber = contactNumber;
            this.nic = nic;
        }

        public void RegiserUser(MetroForm ui)
        {
            userController.register(this,ui);    
        }

        public void Login(MetroForm ui)
        {
            userController.login(this, ui);
        }

        public void ResetPassword(MetroForm ui)
        {
            userController.reset(this, "new",ui);
        }
    }
}
