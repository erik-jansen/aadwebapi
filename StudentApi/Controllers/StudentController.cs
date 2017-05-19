using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace StudentApi.Controllers
{
    [Authorize]
    public class StudentController : ApiController
    {
        public string Get()
        {
            return "This is a fake student API";
        }
    }
}