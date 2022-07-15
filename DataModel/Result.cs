using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
    public class Result: BaseResult
    {
        public DateTime DataDate { get; set; } = DateTime.Now;
    }
    public abstract class BaseResult : IResult
    {
        public string ReturnCode { get; set; } = "0000";
        public string ReturnMessage { get; set; }
    }
}
