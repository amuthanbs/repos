using System;

namespace TravelLogAzureRepo.Login
{
    public class LoginRepo
    {
        public LoginRepo()
        {

        }
        public  bool TryUserName(string userName)
        {
            return string.IsNullOrEmpty(userName) ? false : true;
        }
    }
}
