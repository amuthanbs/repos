using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelLogDataAccess;
using TravelLogApi.ViewModels;
using TravelLogApi.Helper;
using TravelLogCommon;
using common = TravelLog.Common;
namespace TravelLogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegisterController : ControllerBase
    {
        [HttpGet]
        [Route("RegisterStatus")]
        public IActionResult GetRegisterStatus([FromQuery]string? registerID )
        {
            common.TravelLogResponse<RegisterVM> response = new common.TravelLogResponse<RegisterVM>();
            TravelLogDataAccess.DataAccess.RegisterDA registerDA = new TravelLogDataAccess.DataAccess.RegisterDA();
            response.Data= RegisterHelper.RegisterDAToVM(registerDA.Get(registerID));
            response.success = true;
            return StatusCode(200, response);// response.data RegisterHelper.RegisterDAToVM( registerDA.Get(registerID));
        }
        [HttpGet]
        public bool Get([FromQuery]string id)
        {
            return String.IsNullOrEmpty(id);
        }
    }
}