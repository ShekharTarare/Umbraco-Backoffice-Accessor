using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.Controllers;

namespace InstallingUmbracoDemo.Controllers
{
    public class MyAPIController : UmbracoApiController
    {
        [HttpGet]
        public string GetGreeting()
        {
            return "Hello, Umbraco API!";
        }
    }
}
