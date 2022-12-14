using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiExamples.Models;
namespace WebApiExamples.Models
{
    public class UserValidate
    {
        //This method is used to check the user credentials
        public static bool Login(string username, string password)
        {
            UserBL userBL = new UserBL();
            var UserLists = userBL.GetUsers();
            return UserLists.Any(user =>
                user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
                && user.Password == password);
        }
    }
}