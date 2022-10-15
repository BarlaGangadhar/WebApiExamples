using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiExamples.Models;

namespace WebApiExamples.Models
{
    public class UserBL
    {
        public List<Users> GetUsers()
        {
            // In Real-time you need to get the data from any persistent storage
            // For Simplicity of this demo and to keep focus on Basic Authentication
            // Here we are hardcoded the data
            List<Users> userList = new List<Users>();
            userList.Add(new Users()
            {
                ID = 101,
                UserName = "MaleUser",
                Password = "123456"
            });
            userList.Add(new Users()
            {
                ID = 101,
                UserName = "FemaleUser",
                Password = "abcdef"
            });
            return userList;
        }
    }
}