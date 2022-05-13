using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        private static User _testUser;
        public static User TestUser
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }
        

        static private void ResetTestUserData()
        {
            if (_testUser == null)
            {
                _testUser = new User();
                _testUser.UserName = "Yoana";
                _testUser.Password = "Ani2323";
                _testUser.FN = "121219009";
                _testUser.Role = UserRoles.ADMIN;
            }
        }

    }
}