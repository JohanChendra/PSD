using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factory;
using TokoBeDia.Model;

namespace TokoBeDia.Repository
{
    public class UserRepository
    {
        static TokoBeDiaEntities db = new TokoBeDiaEntities();
        public static List<User> GetUsers()
        {
            return (from user
                    in db.Users
                    select user).ToList();
        }
        public static User GetUser(string email, string password)
        {
          return (from user
                  in db.Users
                  where user.Email == email
                        &&
                        user.Password == password
                  select user).FirstOrDefault();
        }
        
        public static User GetUserid(int id)
        {
            return (from x
                    in db.Users
                    where x.ID == id
                    select x).FirstOrDefault();
        }

        public static User InsertUser(int roleid, string name, string email, string password, string gender, string status)
        {
            User u = UserFactory.InsertUser(roleid,name, email, password, gender, status);
            db.Users.Add(u);
            db.SaveChanges();
            return u;
        }
        public static void UpdateUserProfile(int id, string email, string name, string gender)
        {
            User u = GetUserid(id);
                u.Email = email;
                u.Name = name;
                u.Gender = gender;
                db.SaveChanges();
        }
        public static void UpdateUserPassword(int id, string password)
        {
            User u = GetUserid(id);
            u.Password = password;
            db.SaveChanges();
        }

        public static void ChangeUserRole(int id, int roleid)
        {
            User u = GetUserid(id);
            u.RoleID = roleid;
            db.SaveChanges();
        }

        public static void ChangeUserStatus(int id, string status)
        {
            User u = GetUserid(id);
            u.Status = status;
            db.SaveChanges();
        }
    }
}