
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using SimpleAzureFunctionExtension;

namespace SimpleAzureFunctionApp
{
    public static class SimpleAzureFunction
    {
        [FunctionName("SimpleAzureFunction")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequest req, 
            [SimpleExtension(Name = "Dave")] string result,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            return new OkObjectResult(result);
        }
    }
}
