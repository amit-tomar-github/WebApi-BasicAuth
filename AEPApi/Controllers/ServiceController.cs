using AEPApi.Dal;
using AEPApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace AEPApi.Controllers
{
    [BasicAuthentication]
    public class ServiceController : ApiController
    {
        //without parameter
        [HttpGet]
        public string GetTestValue()
        {
            return "Working";
        }
        //with default url parameter
        public string GetValue(string id)
        {
            return $"Hello {id} , how are you";
        }
        public List<Part> GetValue()
        {
            List<Part> parts = new List<Part>();
            parts.Add(new Part
            {
                BackNo = "b100", Description = "Test"
            });
            parts.Add(new Part
            {
                BackNo = "b200",
                Description = "Test2"
            });
            return parts;
        }
        //customer route here {} is mandatory
        [Route("api/getname/{name}")]
        public string GetMyName(string name)
        {
            return $"Hello {name} , how are you";
        }

    }
}
