﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class LoginValidation
    {
        public static UserRoles CurrentUserRole { get; private set; }

        public bool ValidateUserInput()
        {
            CurrentUserRole = UserRoles.ADMIN;
            return true;
        }
    }
}