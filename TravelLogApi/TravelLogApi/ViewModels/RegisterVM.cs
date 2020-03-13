using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelLogApi.ViewModels
{
    public class RegisterVM
    {
        public string RegisterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string LandLine1 { get; set; }
        public string LandLine2 { get; set; }
        public string Email { get; set; }
        public int IdCity { get; set; }
        public int IdState { get; set; }
        public int IdCountry { get; set; }
    }
}
