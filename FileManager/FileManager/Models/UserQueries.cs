using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileManager.Models
{
    public static class UserQueries
    {
        private static FileManagerEntities entity = new FileManagerEntities();

        public static List<User> GetUsers()
        {
            return entity.Users.ToList();
        }

        public static bool ValidCredentials(string username, string password)
        {
            using (entity)
            {
                var query = (from user in entity.Users where username == user.User_Username && password == user.User_Password select user).Count();

                if(query == 1)
                {
                    return true;
                }
                
            }
            return false;
        }

        public static UserSession GetUserSession(string username, string password)
        {
            UserSession userSession = null;
            using (entity)
            {
                var query = (from user in entity.Users where username == user.User_Username && password == user.User_Password select user);
                foreach(var result in query)
                {
                    userSession = new UserSession();
                    userSession.userID = result.User_Ref;
                    userSession.username = result.User_Username;
                    userSession.userType = result.User_Type;
                }
            }

            return userSession;
        }
    }
}