using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
    public interface IResult
    {
        string ReturnCode { get; set; }
        string ReturnMessage { get; set; }
    }
}
