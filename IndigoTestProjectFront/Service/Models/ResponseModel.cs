using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndigoTestProjectFront.Service.Models
{
    internal class ResponseModel
    {
        public bool Status { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
    }
}
