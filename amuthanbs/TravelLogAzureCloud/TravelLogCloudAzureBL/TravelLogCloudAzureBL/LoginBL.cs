using System;

namespace TravelLogCloudAzureBL.Login
{
    using TravelLogAzureRepo.Login;
    public class LoginBL
    {
        public  LoginBL()
        {
            
        }

        public bool CheckLoginUserName(string userName)
        {
            LoginRepo loginRepo = loginRepo = new LoginRepo();
            return loginRepo.TryUserName(userName);
        }
    }
}
