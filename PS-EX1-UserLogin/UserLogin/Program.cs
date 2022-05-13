using System;

namespace UserLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var LV = new LoginValidation();

            if (LV.ValidateUserInput())
            {
                Console.WriteLine(UserData.TestUser.UserName);
                Console.WriteLine(LoginValidation.CurrentUserRole);
            }
        }
    }
}