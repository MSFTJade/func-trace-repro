using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace func_trace_repro {
    public static class HttpTrigger {
        [FunctionName("HttpTrigger")]
        public static async Task<IActionResult> Run( [HttpTrigger( AuthorizationLevel.Function, "get", "post", Route = null )] HttpRequest req, ILogger log ) {
            return new OkObjectResult( "Hello, World!" );
        }
    }
}
