using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;

namespace WebApplication3
{
    [ApiController]
    [Route("api/[controller]")]
    public class QQController : ControllerBase
    {

        private readonly ILogger<QQController> _logger;

        public QQController(ILogger<QQController> logger)
        {
            _logger = logger;
        }


        [HttpGet()]
        public ActionResult GetQQ() 
        {
            string result = "QQ";
            return this.Content(result , "application/json");
        }

        [HttpGet()]
        [Route("GetQQ1")]

        
        public ActionResult GetQQ1(string Data)
        {
            string result = "QQ1" + Data;
            return this.Content(result, "application/json");
        }

        /// <summary>
        /// Post QQ with string parameter
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        [HttpPost()]
        [Route("PostQQ")]
        public ActionResult PostQQ(string Data) 
        {
            Result result = new Result() 
            {
                ReturnCode = "-1"
            };
            try 
            {
                result.ReturnCode = "0000";
                result.ReturnMessage = $"Got Data {Data}";
            }
            catch(Exception ex) 
            {
                result.ReturnMessage = $"處理資料發生例外，{ex.Message}，{ex.StackTrace}";
            }
           
            string jsonString = JsonSerializer.Serialize(result);

            return this.Content(jsonString, "application/json");
        }

        /// <summary>
        /// Post QQ with json parameter
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        [HttpPost()]
        [Route("PostQQ1")]
        public ActionResult PostQQ1([FromBody] Input Data)
        {
            Result result = new Result()
            {
                ReturnCode = "-1"
            };
            try
            {
                _logger.LogInformation($"ReceiveDataID : {Data.ID}");
                result.ReturnCode = "0000";
                result.ReturnMessage = $"Got Data {Data.ID}";
            }
            catch (Exception ex)
            {
                result.ReturnMessage = $"處理資料發生例外，{ex.Message}，{ex.StackTrace}";
            }

            string jsonString = JsonSerializer.Serialize(result);

            return this.Content(jsonString, "application/json");
        }



        [HttpGet()]
        [Route("GetQQ2")]


        public ActionResult GetQQ2()
        {
            string result = "QQ2";
            return this.Content(result, "application/json");
        }
    }
}
