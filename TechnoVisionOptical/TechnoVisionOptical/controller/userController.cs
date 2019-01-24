using TechnoVisionOptical.model;
using MetroFramework.Forms;
using System.Windows.Forms;
using TechnoVisionOptical;
using TechnoVisionOptical.view;

namespace TechnoVisionOptical.controller
{
    class userController
    {

        private static technovisionDataSetTableAdapters.usersTableAdapter UserTable = new technovisionDataSetTableAdapters.usersTableAdapter();
        private static technovisionDataSet.usersDataTable UserDataTable = UserTable.GetData();
        private static technovisionDataSet.usersRow row;
        public static bool register(user NewUser , MetroForm ui)
        {
            try
            {
                UserTable.Insert(NewUser.username, NewUser.password, NewUser.fullName, NewUser.nic, NewUser.contactNumber);
                MSG.SUCCESS(ui, "New User Registration Success!");
                return true;     
            }
            catch(MySql.Data.MySqlClient.MySqlException)
            {
                MSG.ERROR(ui, "New User Registration Failed!");
                return false;
            }
            
        }
        public static bool login(user ExisitingUser, MetroForm ui)
        {
            try
            {           
                row = UserDataTable.FindByusername(ExisitingUser.username);         
                if(row == null)
                {
                    MSG.ERROR(ui, "User Doesn't Exists in the System");
                    return false;
                }
                if((row.username.ToString() == ExisitingUser.username) && (row.password.ToString() == ExisitingUser.password))
                {
                    MSG.SUCCESS(ui,"Login Success.!");
                    ui.Hide();
                    frm_dashboard n = new frm_dashboard();
                    n.ShowDialog();
                    ui.Close();
                    return true;
                }
                else
                {
                    MSG.ERROR(ui, "Username and Password Doesn't Match!");
                    return false;
                }
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {    
               MSG.ERROR(ui,"Login Error.!, " + ex.Message);
               return false;
            }
        } 
        public static bool reset(user ExisitingUser, string NewPassword, MetroForm ui)
        {
            try
            {
                row = UserDataTable.FindByusername(ExisitingUser.username);
                if (row == null)
                {
                    MSG.ERROR(ui, "Invalid Username...!");
                    return false;
                }
                
                else if(row.nic != ExisitingUser.nic)
                {
                    MSG.ERROR(ui, "Invalid NIC...!");
                    return false;
                }
                else if (row.contactNumber != ExisitingUser.contactNumber)
                {
                    MSG.ERROR(ui, "Invalid Contact Number...!");
                    return false;
                }
                else if (NewPassword == "")
                {
                    MSG.ERROR(ui, "Password Can not be empty......!");
                    return false;
                }
                else if (row.username == ExisitingUser.username && row.nic == ExisitingUser.nic && row.contactNumber == ExisitingUser.contactNumber)
                {
                    UserTable.UpdatePasswordByUsername(NewPassword, ExisitingUser.username);
                    MSG.SUCCESS(ui, "Password Reset Success.!");
                    UserDataTable.Clear();
                    UserDataTable = UserTable.GetData();
                    return true;

                }
                else
                {
                    MSG.ERROR(ui, "Password Reset Error.!");
                    return false;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MSG.ERROR(ui, "Password Reset Error.Please Try again..." + ex.Message);
                return false;
            }
        }
    }
}
