﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Basic_Sigma.Controllers
{
   // [Route("api/v2")]
    public class DemoController: ControllerBase
    {
        public string GetHello()
        {
            return "Hello";
        }

        public int GetInt()
        {
            return 10;
        }
    }
}
