using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppAPI.Errors
{
    public class APIException
    {
        public APIException(int status, string message, string details)
        {
            Status = status;
            Message = message;
            Details = details;
        }

        public int Status { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }

    }
}