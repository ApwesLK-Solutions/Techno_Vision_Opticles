using TechnoVisionOptical.model;

namespace TechnoVisionOptical.controller
{
    class userController
    {

        private static technovisionDataSetTableAdapters.usersTableAdapter UserTable = new technovisionDataSetTableAdapters.usersTableAdapter();
        private static technovisionDataSet.usersRow row;
        private static technovisionDataSet.
        
        public static string register(user NewUser)
        {
            try
            {
                UserTable.Insert(NewUser.username, NewUser.password, NewUser.fullName, NewUser.nic, NewUser.contactNumber);
                return "New User Registration Success!";     
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                return "New User Registration Failed, " + ex.Message.ToString();
            }
            
        }
        public static string login(user ExisitingUser)
        {
           UserTable.GetDataByUsername(ExisitingUser.username);
        }
        public static string reset(user user)
        {
            return true;
        }
    }
}
