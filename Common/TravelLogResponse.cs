using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelLogApi.Common
{
    public class TravelLogResponse<T>
    {
        public T Data { set; get; }
        public bool success { get; set; }
    }
}
