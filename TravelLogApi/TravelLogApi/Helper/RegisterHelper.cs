using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelLogApi.ViewModels;
using TravelLogDataAccess.Models;
namespace TravelLogApi.Helper
{
    public static class RegisterHelper
    {
        public static RegisterVM RegisterDAToVM(Register register)
        {
            RegisterVM registerVM;
            if (register != null)
            {
                registerVM = new RegisterVM();
                registerVM.Address1 = register.Address1;
                registerVM.Address2 = register.Address2;
                registerVM.Address3 = register.Address3;
                registerVM.DateOfBirth = register.DateOfBirth;
                registerVM.Email = register.Email;
                registerVM.FirstName = register.FirstName;
                registerVM.IdCity = register.IdCity;
                registerVM.IdCountry = register.IdCountry;
                registerVM.IdState = register.IdState;
                registerVM.LandLine1 = register.LandLine1;
                registerVM.LandLine2 = register.LandLine2;
                registerVM.LastName = register.LastName;
                registerVM.PhoneNumber1 = register.PhoneNumber1;
                registerVM.PhoneNumber2 = register.PhoneNumber2;
                registerVM.RegisterId = register.RegisterId;
                registerVM.Surname = register.Surname;
            }
            else
            {
                registerVM = null;
            }
            return registerVM;
        }
    }
}
