using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factory
{
    public class UserFactory
    {
        public static User InsertUser(int roleid,string name, string email, string password, string gender,string status)
        {
            User u = new User()
            {
                RoleID = roleid,
                Name = name,
                Email = email,
                Password = password,
                Gender = gender,
                Status = status
            };
            return u;
        }
    }
}